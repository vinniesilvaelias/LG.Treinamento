using LG.Treinamento.Negocio.Models;
using System;
using System.Windows.Forms;

namespace LG.Prateleira.UI.Windows
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void FuncionarioForm_Load(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.Fill(this.prateleiraDataSet.Funcionario);

            funcionarioGrid.RowHeadersVisible = false;
            foreach (DataGridViewBand band in funcionarioGrid.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void funcionarioGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var funcionario = new Funcionario()
            {
                Id = this.prateleiraDataSet.Funcionario[e.RowIndex].Id,
                Nome = this.prateleiraDataSet.Funcionario[e.RowIndex].Nome,
                SobreNome = this.prateleiraDataSet.Funcionario[e.RowIndex].SobreNome
            };

            var funcionarioEdit = new FuncionarioEditForm(funcionario, this.prateleiraDataSet.Funcionario);
            funcionarioEdit.Show();
        }

        private void newButton_Click(object sender, EventArgs e) => new FuncionarioEditForm(null, this.prateleiraDataSet.Funcionario).Show();

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();
    }
}
