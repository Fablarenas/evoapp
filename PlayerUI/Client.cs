using EvorodApp.Controllers;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace PlayerUI
{
    public partial class Client : Form
    {
        private readonly ClientsController _ClientsController;
        private readonly GroupsController _GroupsController;
        public Client(ClientsController ClientsController, GroupsController groupsController)
        {
            _ClientsController = ClientsController;
            _GroupsController = groupsController;
            InitializeComponent();
            this.Load += Client_Load;

        }
        private async void Client_Load(object sender, EventArgs e)
        {
            await LoadData().ConfigureAwait(false);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            TestEvolutiaWorker.Infraestructure.Entities.Client Client = await _ClientsController.Details(id);
            textBoxName.Text = Client.Name;
            textBoxGrade.Text = Client.Note == null ? "" : Client.Note.ToString();
            cifBox.Text = Client.CIF;
            gruposComboBox.SelectedValue = Client.IdGroup;
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            int grupoId = (int)gruposComboBox.SelectedValue;
            string name = textBoxName.Text;
            string grade = textBoxGrade.Text;
            string cif = cifBox.Text;
            TestEvolutiaWorker.Infraestructure.Entities.Client Client = new TestEvolutiaWorker.Infraestructure.Entities.Client() { Name = name, Note = grade , IdGroup = grupoId , CIF = cif };

            await _ClientsController.Create(Client);
            await LoadData();
            ClearInputs();
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                string name = textBoxName.Text;
                string grade = textBoxGrade.Text;

                TestEvolutiaWorker.Infraestructure.Entities.Client Client = new TestEvolutiaWorker.Infraestructure.Entities.Client() { Id = id, Name = name, Note = grade };

                bool result = await _ClientsController.Edit(id, Client);

                if (result)
                {
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to edit the Client. The Client might not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el grupo seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await _ClientsController.DeleteConfirmed(id);
                await LoadData();
                ClearInputs();
            }
        }

        private async Task LoadData()
        {
            try
            {
                var groups = await _GroupsController.GetGroupsAsync();

                var groupList = groups.ToList();

                groupList.Insert(0, new TestEvolutiaWorker.Infraestructure.Entities.Group { Name = "Selecciona una opción", Id = 0 });

                gruposComboBox.DataSource = groupList;
                gruposComboBox.DisplayMember = "Name";
                gruposComboBox.ValueMember = "Id";
                dataGridView1.DataSource = await _ClientsController.GetClientsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearInputs()
        {
            textBoxName.Text = "";
            textBoxGrade.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
