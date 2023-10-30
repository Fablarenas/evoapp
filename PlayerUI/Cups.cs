using EvorodApp.Controllers;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace PlayerUI
{
    public partial class Cups : Form
    {
        private readonly CupsController _CupsController;
        public Cups(CupsController CupsController)
        {
            _CupsController = CupsController;
            InitializeComponent();
            this.Load += Cups_Load;
        }
        private async void Cups_Load(object sender, EventArgs e)
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

            TestEvolutiaWorker.Infraestructure.Entities.Cups Cups = await _CupsController.Details(id);
            //textBoxName.Text = Cups.Name;
            textBoxGrade.Text = Cups.Note == null ? "" : Cups.Note.ToString();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string grade = textBoxGrade.Text;
            TestEvolutiaWorker.Infraestructure.Entities.Cups Cups = new TestEvolutiaWorker.Infraestructure.Entities.Cups() { Note = grade };

            await _CupsController.Create(Cups);
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

                TestEvolutiaWorker.Infraestructure.Entities.Cups Cups = new TestEvolutiaWorker.Infraestructure.Entities.Cups() { Id = id, Note = grade };

                bool result = await _CupsController.Edit(id, Cups);

                if (result)
                {
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to edit the Cups. The Cups might not exist.");
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
                await _CupsController.DeleteConfirmed(id);
                await LoadData();
                ClearInputs();
            }
        }

        private async Task LoadData()
        {
            try
            {
                // Usa ConfigureAwait para evitar volver al subproceso de la interfaz
                dataGridView1.DataSource = await _CupsController.GetCupsAsync();
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
