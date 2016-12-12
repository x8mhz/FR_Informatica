using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FR_Informatica
{
    class Conexao
    {
        private string str_Con;
        private SqlConnection con;
        public SqlCommand cmd { get; set; }

        public Conexao(string cmd)
        {
            this.str_Con = @"Data Source=DESKTOP-RC8UBSB\SQLEXPRESS;Initial Catalog=BD_FRInformatica;Integrated Security=True";
            this.con = new SqlConnection(str_Con);
            this.cmd = new SqlCommand(cmd, con);
        }

        public bool AbrirConexao()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (SqlException ex)
            {           
                return false;
            }
        }

        public bool FecharConexao()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao encessar a conexão com o banco de dados", "Informação", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
