namespace AulaBancoDeDadosMySQL
{
    partial class frmNewCalculation
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(162, 178);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 32);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenName.Location = new System.Drawing.Point(162, 33);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(131, 25);
            this.lblScreenName.TabIndex = 32;
            this.lblScreenName.Text = "Information";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(228, 129);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(122, 32);
            this.btnLimparCampos.TabIndex = 31;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(92, 129);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 32);
            this.btnInserir.TabIndex = 30;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(136, 87);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(41, 13);
            this.lblCnpj.TabIndex = 25;
            this.lblCnpj.Text = "Nome: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 24;
            // 
            // frmNewCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 255);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblScreenName);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtName);
            this.Name = "frmNewCalculation";
            this.Text = "Novo Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtName;
    }
}