using EvorodApp.Controllers;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace PlayerUI
{
    public partial class Contract : Form
    {
        private readonly ContractController _ContractsController;
        public Contract(ContractController ContractsController)
        {
            _ContractsController = ContractsController;
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

            TestEvolutiaWorker.Infraestructure.Entities.ContractType Contract = await _ContractsController.Details(id);
            //textBoxName.Text = Contract.Name;
            //textBoxGrade.Text = Contract.Note == null ? "" : Contract.Note.ToString();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string grade = textBoxGrade.Text;
            TestEvolutiaWorker.Infraestructure.Entities.ContractType Contract = new TestEvolutiaWorker.Infraestructure.Entities.ContractType() {  };

            await _ContractsController.Create(Contract);
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

                TestEvolutiaWorker.Infraestructure.Entities.ContractType Contract = new TestEvolutiaWorker.Infraestructure.Entities.ContractType() { Id = id };

                bool result = await _ContractsController.Edit(id, Contract);

                if (result)
                {
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to edit the Contract. The Contract might not exist.");
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
                await _ContractsController.DeleteConfirmed(id);
                await LoadData();
                ClearInputs();
            }
        }

        private async Task LoadData()
        {
            try
            {
                // Usa ConfigureAwait para evitar volver al subproceso de la interfaz
                dataGridView1.DataSource = await _ContractsController.GetContractAsync();
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
