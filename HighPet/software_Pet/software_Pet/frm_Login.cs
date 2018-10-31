using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace software_Pet
{
    public partial class frm_Login : MaterialForm
    {     
        public frm_Login()
        {
            InitializeComponent();
        }

        //inicialização sempre vazia
        private string Sql = string.Empty;
        public bool logado = false;

        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
            //Fazendo registro da conta que será logada ***************************************************************************************
            DataBase.obterConexao();
            string altera = "UPDATE TB_DADOS_LOG SET NOME_LOGADO= '" + lbl_nome_log.Text + "',SOBRENOME_LOGADO= '" + lbl_sbre.Text + "',RG_LOGADO= '" + lbl_rg.Text + "'";
            SqlCommand cmd2 = new SqlCommand(altera, DataBase.obterConexao());

            try
            {
                DataBase.obterConexao();
                int resultado;
                resultado = cmd2.ExecuteNonQuery();

                if(resultado >= 1)
                {

                }
                cmd2.Dispose();
            }
            catch
            {
                MessageBox.Show("Erro ao logar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //Logando *************************************************************************************************************************
            String usu, sen;
            try
            {
                usu = txt_login.Text;
                sen = txt_senha.Text;

                Sql = "SELECT COUNT (ID_FUNCIONARIO) FROM TB_FUNCIONARIO WHERE LOGIN = @LOGIN  AND SENHA = @SENHA  ";
                SqlCommand cmd = new SqlCommand(Sql, DataBase.obterConexao());

                cmd.Parameters.Add("@LOGIN", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = sen;

                DataBase.obterConexao();

                int V = (int)cmd.ExecuteScalar();

                if (V > 0)
                {
                    this.Dispose();
                    logado = true;
                    frm_Menu menu = new frm_Menu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao logar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    logado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataBase.fecharConexao();
            }
            txt_login.Text = "";
            txt_senha.Text = "";
            txt_login.Focus();
        }
        
        private void lbl_cad_Click(object sender, EventArgs e)
        {    
            frm_CadastroFunc cad = new frm_CadastroFunc();
            cad.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Creditos cr = new frm_Creditos();
            cr.ShowDialog();
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            DataBase.obterConexao();
            string pesq = "SELECT * FROM TB_FUNCIONARIO WHERE SENHA= '" + txt_senha.Text + "'";
            SqlCommand cmd = new SqlCommand(pesq, DataBase.obterConexao());
            SqlDataReader DR;
            try
            {
                DataBase.obterConexao();
                DR = cmd.ExecuteReader();

                if(DR.Read())
                {
                    lbl_nome_log.Text = DR.GetValue(1).ToString();
                    lbl_sbre.Text = DR.GetValue(2).ToString();
                    lbl_rg.Text = DR.GetValue(3).ToString();
                }
                DR.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DataBase.fecharConexao();
            }
        }
    }
}
