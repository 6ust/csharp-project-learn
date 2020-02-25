namespace AulaBancoDeDadosMySQL
{
    partial class frmMainScreen
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
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.btnOpenSystem = new System.Windows.Forms.Button();
            this.btnCloseSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameProgram
            // 
            this.lblNameProgram.AutoSize = true;
            this.lblNameProgram.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProgram.Location = new System.Drawing.Point(23, 26);
            this.lblNameProgram.Name = "lblNameProgram";
            this.lblNameProgram.Size = new System.Drawing.Size(399, 28);
            this.lblNameProgram.TabIndex = 0;
            this.lblNameProgram.Text = "C# - Acesso ao Banco  de Dados - Exemplo";
            // 
            // btnOpenSystem
            // 
            this.btnOpenSystem.Location = new System.Drawing.Point(63, 93);
            this.btnOpenSystem.Name = "btnOpenSystem";
            this.btnOpenSystem.Size = new System.Drawing.Size(133, 41);
            this.btnOpenSystem.TabIndex = 1;
            this.btnOpenSystem.Text = "Entrar";
            this.btnOpenSystem.UseVisualStyleBackColor = true;
            this.btnOpenSystem.Click += new System.EventHandler(this.btnOpenSystem_Click);
            // 
            // btnCloseSystem
            // 
            this.btnCloseSystem.Location = new System.Drawing.Point(247, 93);
            this.btnCloseSystem.Name = "btnCloseSystem";
            this.btnCloseSystem.Size = new System.Drawing.Size(133, 41);
            this.btnCloseSystem.TabIndex = 2;
            this.btnCloseSystem.Text = "Fechar Sistema";
            this.btnCloseSystem.UseVisualStyleBackColor = true;
            this.btnCloseSystem.Click += new System.EventHandler(this.btnCloseSystem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 192);
            this.Controls.Add(this.btnCloseSystem);
            this.Controls.Add(this.btnOpenSystem);
            this.Controls.Add(this.lblNameProgram);
            this.Name = "frmMainScreen";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameProgram;
        private System.Windows.Forms.Button btnOpenSystem;
        private System.Windows.Forms.Button btnCloseSystem;
    }
}