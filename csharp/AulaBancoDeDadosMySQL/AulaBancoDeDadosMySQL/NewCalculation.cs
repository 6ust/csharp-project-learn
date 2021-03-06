﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AulaBancoDeDadosMySQL
{
    public partial class frmNewCalculation : Form
    {
        public frmNewCalculation()
        {
            InitializeComponent();

            lblScreenName.Text = "Novo Calculo";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                //Passa String para o Banco de Dados
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=ambiente_de_testes_001;password=123456");

                //Abre a conexão com o Banco de Dados
                connection.Open();

                //Comando MySQL
                String querySQL = "insert into calculos (nome_calc) values (?)";
                MySqlCommand commandMySQL = new MySqlCommand(querySQL, connection);
                commandMySQL.Parameters.Clear();
                commandMySQL.Parameters.Add("@nome_calc", MySqlDbType.VarChar).Value = txtName.Text;


                //Comando para executar a Query de INSERT
                commandMySQL.ExecuteNonQuery();

                //Fecha conexão
                connection.Close();

                MessageBox.Show("Inserido com Sucesso");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
