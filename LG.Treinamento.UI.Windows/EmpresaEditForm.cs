using LG.Treinamento.Data;
using LG.Treinamento.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LG.Prateleira.UI.Windows
{
    public partial class EmpresaEditForm : Form
    {
        private readonly bool novoRegistro;
        private Empresa empresa;
        private List<Produto> produtos;

        public EmpresaEditForm(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            novoRegistro = empresa == null;
            produtos = new List<Produto>();
        }

        private void StoreFormEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prateleiraDataSet.Produto' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.prateleiraDataSet.Produto);
            if (novoRegistro)
            {
                this.deleteButton.Enabled = false;
            }
            else
            {
                nameTextBox.Text = empresa.Nome;
                
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
            empresa = new Empresa()
            {
                Nome = nameTextBox.Text,
                Produtos = produtos
            };

            using (var dao = new Dao<Empresa>())
            {
                dao.Create(empresa);
            }
        }

        private void UpdateMy()
        {
            //funcionario.Nome = nameTextBox.Text;
            //funcionario.SobreNome = lastNameTextBox.Text;

            //var funcionarioRow = dataSet.FindById(funcionario.Id);
            //ConvertInRow(funcionario, funcionarioRow);

            //funcionarioRow.AcceptChanges();

            //using (var dao = new Dao<Funcionario>())
            //{
            //    dao.Update(funcionario);
            //}
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //dataSet.RemoveFuncionarioRow(dataSet.FindById(funcionario.Id));
            //dataSet.AcceptChanges();

            //using (var dao = new Dao<Funcionario>())
            //{
            //    dao.Delete(funcionario);
            //}

            //this.Close();
        }

        private void addButton_Click(object sender, EventArgs e) => produtos.Add(ProdutoById(this.produtcsComboBox.SelectedIndex + 1));

        private Produto ProdutoById(int item)
        {
            using (var dao = new Dao<Produto>())
            {
                return dao.Select(item);
            }
        }

        private void Cancel_Click(object sender, EventArgs e) => this.Close();

    }
}
