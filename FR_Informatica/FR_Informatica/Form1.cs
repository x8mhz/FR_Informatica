using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FR_Informatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_FRInformaticaDataSet.tb_FRInformatica' table. You can move, or remove it, as needed.
            this.tb_FRInformaticaTableAdapter.Fill(this.bD_FRInformaticaDataSet.tb_FRInformatica);

            //  Invisibilidade a Labels e Buttons
            lbl_Logo.Parent = pic_Banner;
            lbl_SubLogo.Parent = pic_Banner;
            tabControl1.Parent = pic_Banner;
            btn_Calculadora.Parent = pic_Banner;
            btn_Fechar.Parent = pic_Banner;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {       
                Perfil perfil = new Perfil(txt_Nome.Text, txt_Telefone.Text, txt_Aparelho.Text, txt_Endereco.Text, txt_Defeito.Text, dateTimePicker1.Value, Decimal.Parse(txt_Valor.Text));

                string str_cmd = "INSERT INTO tb_FRInformatica(Nome, Telefone, Aparelho, Endereco, Defeito, data, Valor) VALUES ('" 
                    + perfil.Nome + "','" 
                    + perfil.Telefone + "','" 
                    + perfil.Aparelho + "','" 
                    + perfil.Endereco + "','" 
                    + perfil.Defeito + "','" 
                    + perfil.Data.Date + "','" 
                    + perfil.Valor + "')";

                Conexao conexao = new Conexao(str_cmd);

                conexao.AbrirConexao();
                conexao.cmd.ExecuteNonQuery();
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veja se os campos fornecidos estão corretamente inseridos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            this.txt_Nome.Clear();
            this.txt_Telefone.Clear();
            this.txt_Endereco.Clear();
            this.txt_Aparelho.Clear();
            this.txt_Defeito.Clear();
            this.dateTimePicker1.ResetText();
            this.txt_Valor.Clear();
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
