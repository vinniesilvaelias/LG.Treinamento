using LG.Treinamento.Data;
using LG.Treinamento.Negocio.Models;
using System;
using System.Windows.Forms;
using static LG.Prateleira.UI.Windows.TreinamentoDataSet;

namespace LG.Prateleira.UI.Windows
{
    public partial class FuncionarioEditForm : Form
    {
        private readonly bool novoRegistro;
        private Funcionario funcionario;
        private readonly FuncionarioDataTable dataSet;

        public FuncionarioEditForm(Funcionario funcionario, FuncionarioDataTable dataSet)
        {
            InitializeComponent();
            this.novoRegistro = funcionario == null;
            this.funcionario = funcionario;
            this.dataSet = dataSet;
        }

        private void FuncionarioEditForm_Load(object sender, EventArgs e)
        {
            if (novoRegistro)
            {
                this.deleteButton.Enabled = false;
            }
            else
            {
                nameTextBox.Text = funcionario.Nome;
                lastNameTextBox.Text = funcionario.SobreNome;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (novoRegistro)
            {
                CreateMy();
            }
            else
            {
                UpdateMy();
            }

            this.Close();
        }

        private void CreateMy()
        {
            funcionario = new Funcionario()
            {
                Id = dataSet.Rows.Count + 1,
                Nome = nameTextBox.Text,
                SobreNome = lastNameTextBox.Text
            };

            var tmpRow = dataSet.NewFuncionarioRow();
            ConvertInRow(funcionario, tmpRow);

            dataSet.AddFuncionarioRow(tmpRow);
            dataSet.AcceptChanges();

            using (var dao = new Dao<Funcionario>())
            {
                dao.Create(funcionario);
            }
        }

        private void UpdateMy()
        {
            funcionario.Nome = nameTextBox.Text;
            funcionario.SobreNome = lastNameTextBox.Text;

            var funcionarioRow = dataSet.FindById(funcionario.Id);
            ConvertInRow(funcionario, funcionarioRow);

            funcionarioRow.AcceptChanges();

            using (var dao = new Dao<Funcionario>())
            {
                dao.Update(funcionario);
            }
        }

        private void ConvertInRow(Funcionario funcionario, FuncionarioRow row)
        {
            row.Id = funcionario.Id;
            row.Nome = funcionario.Nome;
            row.SobreNome = funcionario.SobreNome;
        }

        private void Cancel_Click(object sender, EventArgs e) => this.Close();

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataSet.RemoveFuncionarioRow(dataSet.FindById(funcionario.Id));
            dataSet.AcceptChanges();

            using (var dao = new Dao<Funcionario>())
            {
                dao.Delete(funcionario);
            }

            this.Close();
        }
    }
}
