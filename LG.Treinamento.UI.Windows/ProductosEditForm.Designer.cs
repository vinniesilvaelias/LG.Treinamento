
using System.Windows.Forms;

namespace LG.Prateleira.UI.Windows
{
    partial class ProdutosEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.aisleLabel = new System.Windows.Forms.Label();
            this.aisleTextBox = new System.Windows.Forms.TextBox();
            this.shelfLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(102, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nome";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(16, 77);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(102, 20);
            this.priceTextBox.TabIndex = 0;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(13, 61);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Preço";
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.Location = new System.Drawing.Point(16, 133);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(48, 20);
            this.shelfTextBox.TabIndex = 0;
            this.shelfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // aisleLabel
            // 
            this.aisleLabel.AutoSize = true;
            this.aisleLabel.Location = new System.Drawing.Point(13, 117);
            this.aisleLabel.Name = "aisleLabel";
            this.aisleLabel.Size = new System.Drawing.Size(51, 13);
            this.aisleLabel.TabIndex = 1;
            this.aisleLabel.Text = "Prateleira";
            // 
            // aisleTextBox
            // 
            this.aisleTextBox.Location = new System.Drawing.Point(70, 133);
            this.aisleTextBox.Name = "aisleTextBox";
            this.aisleTextBox.Size = new System.Drawing.Size(48, 20);
            this.aisleTextBox.TabIndex = 0;
            this.aisleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // shelfLabel
            // 
            this.shelfLabel.AutoSize = true;
            this.shelfLabel.Location = new System.Drawing.Point(67, 117);
            this.shelfLabel.Name = "shelfLabel";
            this.shelfLabel.Size = new System.Drawing.Size(47, 13);
            this.shelfLabel.TabIndex = 1;
            this.shelfLabel.Text = "Corredor";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(162, 85);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(162, 53);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Excluir";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(162, 24);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ProdutosEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 186);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.shelfLabel);
            this.Controls.Add(this.aisleLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.aisleTextBox);
            this.Controls.Add(this.shelfTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ProdutosEditForm";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ProdutosEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox shelfTextBox;
        private System.Windows.Forms.Label aisleLabel;
        private System.Windows.Forms.TextBox aisleTextBox;
        private System.Windows.Forms.Label shelfLabel;
        private Button Cancel;
        private Button deleteButton;
        private Button saveButton;
    }
}