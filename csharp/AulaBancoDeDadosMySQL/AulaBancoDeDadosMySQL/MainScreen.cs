using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaBancoDeDadosMySQL
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnOpenSystem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmScreenSelection TelaSelecao = new frmScreenSelection();
                TelaSelecao.ShowDialog();
            }
            finally
            {
                this.Show();
            }
        }

        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
