namespace AulaBancoDeDadosMySQL
{
    partial class frmScreenSelection
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
            this.dgvTablesDB = new System.Windows.Forms.DataGridView();
            this.lblNameTable = new System.Windows.Forms.Label();
            this.cboTabela = new System.Windows.Forms.ComboBox();
            this.lblSelecaoTabela = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.btnInsertInTable = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablesDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablesDB
            // 
            this.dgvTablesDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablesDB.Location = new System.Drawing.Point(11, 81);
            this.dgvTablesDB.Name = "dgvTablesDB";
            this.dgvTablesDB.Size = new System.Drawing.Size(681, 150);
            this.dgvTablesDB.TabIndex = 0;
            // 
            // lblNameTable
            // 
            this.lblNameTable.AutoSize = true;
            this.lblNameTable.Location = new System.Drawing.Point(12, 56);
            this.lblNameTable.Name = "lblNameTable";
            this.lblNameTable.Size = new System.Drawing.Size(71, 13);
            this.lblNameTable.TabIndex = 1;
            this.lblNameTable.Text = "Nome Tabela";
            // 
            // cboTabela
            // 
            this.cboTabela.FormattingEnabled = true;
            this.cboTabela.Location = new System.Drawing.Point(130, 23);
            this.cboTabela.Name = "cboTabela";
            this.cboTabela.Size = new System.Drawing.Size(281, 21);
            this.cboTabela.TabIndex = 2;
            // 
            // lblSelecaoTabela
            // 
            this.lblSelecaoTabela.AutoSize = true;
            this.lblSelecaoTabela.Location = new System.Drawing.Point(12, 26);
            this.lblSelecaoTabela.Name = "lblSelecaoTabela";
            this.lblSelecaoTabela.Size = new System.Drawing.Size(103, 13);
            this.lblSelecaoTabela.TabIndex = 3;
            this.lblSelecaoTabela.Text = "Seleção de Tabela: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 258);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(193, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(358, 258);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(159, 31);
            this.btnRefreshTable.TabIndex = 6;
            this.btnRefreshTable.Text = "Atualizar";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // btnInsertInTable
            // 
            this.btnInsertInTable.Location = new System.Drawing.Point(533, 17);
            this.btnInsertInTable.Name = "btnInsertInTable";
            this.btnInsertInTable.Size = new System.Drawing.Size(159, 31);
            this.btnInsertInTable.TabIndex = 7;
            this.btnInsertInTable.Text = "Inserir";
            this.btnInsertInTable.UseVisualStyleBackColor = true;
            this.btnInsertInTable.Click += new System.EventHandler(this.btnInsertInTable_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(523, 258);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 31);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remover Dado";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmScreenSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 314);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsertInTable);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelecaoTabela);
            this.Controls.Add(this.cboTabela);
            this.Controls.Add(this.lblNameTable);
            this.Controls.Add(this.dgvTablesDB);
            this.Name = "frmScreenSelection";
            this.Text = "Tela De Selecao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablesDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablesDB;
        private System.Windows.Forms.Label lblNameTable;
        private System.Windows.Forms.ComboBox cboTabela;
        private System.Windows.Forms.Label lblSelecaoTabela;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Button btnInsertInTable;
        private System.Windows.Forms.Button btnRemove;
    }
}