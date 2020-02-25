using System;
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
    public partial class frmScreenSelection : Form
    {
        public frmScreenSelection()
        {
            InitializeComponent();

            try
            {
                //Passa String para o Banco de Dados
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=ambiente_de_testes_001;password=123456");

                //Abre a conexão com o Banco de Dados
                connection.Open();

                //---------------------------------------
                // SHOW tables
                //---------------------------------------

                //Comando MySQL
                var showTablesSQL = "SHOW TABLES";
                MySqlCommand showTablesCommandSQL = new MySqlCommand(showTablesSQL, connection);

                MySqlDataReader sqlReaderShowTables = showTablesCommandSQL.ExecuteReader();

                while (sqlReaderShowTables.Read())
                {
                    cboTabela.Items.Add(sqlReaderShowTables["Tables_in_ambiente_de_testes_001"].ToString());
                }

                //---------------------------------------
                //Comando Select
                //---------------------------------------

                //Comando SELECT MySQL
                var selectSQL = "SELECT * FROM empresa";
                MySqlDataAdapter commandMySQLSelect = new MySqlDataAdapter(selectSQL, connection);

                //CommandBuilder SELECT
                var commandBuilder = new MySqlCommandBuilder(commandMySQLSelect);

                //Recebimento de dados SELECT
                var ds = new DataSet();
                commandMySQLSelect.Fill(ds);

                //Visualização dos dados na DataGridView
                dgvTablesDB.ReadOnly = true;
                dgvTablesDB.DataSource = ds.Tables[0];


                

                //Fecha conexão
                connection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro --> " + ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        { 
            Object nomeTb = cboTabela.SelectedItem;

            try
            {
                //Passa String para o Banco de Dados
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=ambiente_de_testes_001;password=123456");

                //Abre a conexão com o Banco de Dados
                connection.Open();

                //---------------------------------------
                //Comando Select
                //---------------------------------------

                //Comando SELECT MySQL
                var selectSQL = "SELECT * FROM " + nomeTb.ToString();
                MySqlDataAdapter commandMySQLSelect = new MySqlDataAdapter(selectSQL, connection);

                //CommandBuilder SELECT
                var commandBuilder = new MySqlCommandBuilder(commandMySQLSelect);

                //Recebimento de dados SELECT
                var ds = new DataSet();
                commandMySQLSelect.Fill(ds);

                //Visualização dos dados na DataGridView
                dgvTablesDB.ReadOnly = true;
                dgvTablesDB.DataSource = ds.Tables[0];

                //Fecha conexão
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex);
            }
        }

        private void btnInsertInTable_Click(object sender, EventArgs e)
        {
            try
            {
                Object nomeTb = cboTabela.SelectedItem;

                this.Hide();
                if (nomeTb.ToString() == "calculos")
                {
                    frmNewCalculation newCalculation = new frmNewCalculation();
                    newCalculation.ShowDialog();
                }
                else if (nomeTb.ToString() == "pessoa")
                {
                    frmNewPerson newPerson = new frmNewPerson();
                    newPerson.ShowDialog();
                }
                else if (nomeTb.ToString() == "empresa")
                {
                    frmNewCompany newCompany = new frmNewCompany();
                    newCompany.ShowDialog();
                }
                else
                {
                    //MessageBox.Show("Opção Invalida");
                }
            } 
            finally
            {
                this.Show();
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTablesDB.SelectedCells.Count > 0 )
            {
                // Identificação do Item Selecionado na DataGridView na Coluna Id
                int selectedRowIndex = dgvTablesDB.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTablesDB.Rows[selectedRowIndex];


                //Identificação de ID para Exclusão
                Object nomeTb = cboTabela.SelectedItem;

                if (nomeTb.ToString() == "calculos")
                {
                    int indexCalc = Convert.ToInt16(selectedRow.Cells["id_calc"].Value);
                    //MessageBox.Show(indexCalc);

                    try
                    {
                        //Passa String para o Banco de Dados
                        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=ambiente_de_testes_001;password=123456");

                        //Abre a conexão com o Banco de Dados
                        connection.Open();


                        //---------------------------------------
                        //Comando DELETE
                        //---------------------------------------

                        //Comando DELETE MySQL
                        var selectSQL = "DELETE FROM calculos WHERE id_calc = ?";
                        MySqlCommand commandMySQLSelect = new MySqlCommand(selectSQL, connection);

                        //Preencher validação WHERE
                        commandMySQLSelect.Parameters.Clear();
                        commandMySQLSelect.Parameters.Add("@id_calc", MySqlDbType.Int16).Value = indexCalc;

                        //Executa comando DELETE
                        commandMySQLSelect.ExecuteNonQuery();

                        //Fecha conexão
                        connection.Close();

                        MessageBox.Show("Dado Excluido com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Erro --> " + ex);
                    }

                }
                else if (nomeTb.ToString() == "pessoa")
                {
                    int indexPessoa = Convert.ToInt16(selectedRow.Cells["id_pessoa"].Value);

                    try
                    {
                        //Passa String para o Banco de Dados
                        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=ambiente_de_testes_001;password=123456");

                        //Abre a conexão com o Banco de Dados
                        connection.Open();


                        //---------------------------------------
                        //Comando DELETE
                        //---------------------------------------

                        //Comando DELETE MySQL
                        var selectSQL = "DELETE FROM pessoa WHERE id_pessoa = ?";
                        MySqlCommand commandMySQLSelect = new MySqlCommand(selectSQL, connection);

                        //Preencher validação WHERE
                        commandMySQLSelect.Parameters.Clear();
                        commandMySQLSelect.Parameters.Add("@id_pessoa", MySqlDbType.Int16).Value = indexPessoa;

                        //Executa comando DELETE
                        commandMySQLSelect.ExecuteNonQuery();

                        //Fecha conexão
                        connection.Close();

                        MessageBox.Show("Dado Excluido com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Erro --> " + ex);
                    }
                }
                else if (nomeTb.ToString() == "empresa")
                {
                    int indexEmpresa = Convert.ToInt16(selectedRow.Cells["id_empresa"].Value);

                    try
                    {
                        //Passa String para o Banco de Dados
                        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;User Id=root;database=ambiente_de_testes_001;password=123456");

                        //Abre a conexão com o Banco de Dados
                        connection.Open();


                        //---------------------------------------
                        //Comando DELETE
                        //---------------------------------------

                        //Comando DELETE MySQL
                        var selectSQL = "DELETE FROM empresa WHERE id_empresa = ?";
                        MySqlCommand commandMySQLSelect = new MySqlCommand(selectSQL, connection);

                        //Preencher validação WHERE
                        commandMySQLSelect.Parameters.Clear();
                        commandMySQLSelect.Parameters.Add("@id_empresa", MySqlDbType.Int16).Value = indexEmpresa;

                        //Executa comando DELETE
                        commandMySQLSelect.ExecuteNonQuery();

                        //Fecha conexão
                        connection.Close();

                        MessageBox.Show("Dado Excluido com Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Erro --> " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tabela Inexistente");    
                }

            }
           
        }
    }
}
