
namespace LG.Prateleira.UI.Windows
{
    partial class FuncionarioForm
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
            this.components = new System.ComponentModel.Container();
            this.funcionarioGrid = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prateleiraDataSet = new LG.Prateleira.UI.Windows.TreinamentoDataSet();
            this.funcionarioTableAdapter = new LG.Prateleira.UI.Windows.TreinamentoDataSetTableAdapters.FuncionarioTableAdapter();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prateleiraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionarioGrid
            // 
            this.funcionarioGrid.AutoGenerateColumns = false;
            this.funcionarioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.funcionarioGrid.DataSource = this.funcionarioBindingSource;
            this.funcionarioGrid.Location = new System.Drawing.Point(12, 41);
            this.funcionarioGrid.Name = "funcionarioGrid";
            this.funcionarioGrid.Size = new System.Drawing.Size(303, 150);
            this.funcionarioGrid.TabIndex = 0;
            this.funcionarioGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionarioGrid_CellContentClick);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(13, 13);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "Novo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "SobreNome";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "SobreNome";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.prateleiraDataSet;
            // 
            // prateleiraDataSet
            // 
            this.prateleiraDataSet.DataSetName = "TreinamentoDataSet";
            this.prateleiraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(94, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 203);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.funcionarioGrid);
            this.Name = "FuncionarioForm";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.FuncionarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prateleiraDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TreinamentoDataSet prateleiraDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private TreinamentoDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridView funcionarioGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button cancelButton;
    }
}