using EvorodApp.Controllers;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace PlayerUI
{
    public partial class Device : Form
    {
        private readonly GroupsController _groupsController;
        public Device(GroupsController groupsController)
        {
            _groupsController = groupsController;
            InitializeComponent();
            LoadData().ConfigureAwait(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

            TestEvolutiaWorker.Infraestructure.Entities.Group group = await _groupsController.Details(id);
            textBoxName.Text = group.Name;
            textBoxGrade.Text = group.Note == null ? "" : group.Note.ToString();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string grade = textBoxGrade.Text;
            TestEvolutiaWorker.Infraestructure.Entities.Group group = new TestEvolutiaWorker.Infraestructure.Entities.Group() { Name = name, Note = grade };

            await _groupsController.Create(group);
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

                TestEvolutiaWorker.Infraestructure.Entities.Group group = new TestEvolutiaWorker.Infraestructure.Entities.Group() { Id = id, Name = name, Note = grade };

                bool result = await _groupsController.Edit(id, group);

                if (result)
                {
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to edit the group. The group might not exist.");
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
                await _groupsController.DeleteConfirmed(id);
                await LoadData();
                ClearInputs();
            }
        }

        private async Task LoadData()
        {
            try
            {
                // Usa ConfigureAwait para evitar volver al subproceso de la interfaz
                dataGridView1.DataSource = await _groupsController.GetGroupsAsync();
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
    }
}
