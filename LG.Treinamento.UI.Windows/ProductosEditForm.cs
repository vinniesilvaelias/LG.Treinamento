using LG.Treinamento.Data;
using LG.Treinamento.Negocio.Models;
using System;
using System.Windows.Forms;

namespace LG.Prateleira.UI.Windows
{
    public partial class ProdutosEditForm : Form
    {
        private readonly bool novoRegistro;
        private Produto product;

        public ProdutosEditForm(Produto product)
        {
            InitializeComponent();
            this.product = product;
            novoRegistro = product == null;
        }

        private void ProdutosEditForm_Load(object sender, EventArgs e)
        {
            if (novoRegistro)
            {
                this.deleteButton.Enabled = false;
            }
            else
            {
                nameTextBox.Text = product.Nome;
            }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
            }

            this.Close();
        }

        private void CreateMy()
        {
            product = new Produto()
            {
                Nome = nameTextBox.Text,
                Preco = Convert.ToDouble(priceTextBox.Text),
                Prateleira = Convert.ToInt32(aisleTextBox.Text),
                Corredor = Convert.ToInt32(shelfTextBox.Text)
            };

            using (var dao = new Dao<Produto>())
            {
                dao.Create(product);
            }
        }
    }
}
