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

namespace software_Pet
{
    public partial class frm_alterafunc : Form
    {
        static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\André Victor\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        
        /*LBA01*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\INFOLABS\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*LAB03*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\INFOLABS\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*PC-Doreto*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Doreto\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*PC-Nigga*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Niga\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection conexao = new SqlConnection(strcon);

        public frm_alterafunc()
        {
            InitializeComponent();
        }

        private void btn_Vol_Click(object sender, EventArgs e)
        {
            frm_cadastrofunc cf = new frm_cadastrofunc();
            this.Visible = false;
            cf.ShowDialog();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            DialogResult d1 = MessageBox.Show("Quer alterar a senha?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d1 == DialogResult.Yes)
            {
                label12.Visible = true;
                txt_confS.Text = "";
                txt_confS.Visible = true;
                label10.Visible = true;
                txt_senha.Visible = true;
                btn_trocSen.Enabled = true;
                txt_confS.Focus();
                MessageBox.Show("Confirme sua senha atual e pressione Trocar Senha", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se desejar Trocar sua Senha, pesquise o RG novamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string pesquisa = "SELECT * FROM TB_FUNCIONARIO WHERE RG= " + txt_pesquisa.Text + "";
            SqlCommand cmd = new SqlCommand(pesquisa, conexao);
            SqlDataReader DR;
            try
            {
                conexao.Open();
                DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    txt_nome.Text = DR.GetValue(1).ToString();
                    txt_sbr.Text = DR.GetValue(2).ToString();
                    txt_rg.Text = DR.GetValue(3).ToString();
                    txt_cpf.Text = DR.GetValue(4).ToString();
                    txt_bairro.Text = DR.GetValue(5).ToString();
                    txt_rua.Text = DR.GetValue(6).ToString();
                    txt_num.Text = DR.GetValue(7).ToString();
                    txt_compl.Text = DR.GetValue(8).ToString();
                    txt_telefone.Text = DR.GetValue(9).ToString();
                    txt_login.Text = DR.GetValue(10).ToString();
                    txt_senha.Text = DR.GetValue(11).ToString();
                    if (d1 == DialogResult.Yes)
                    {
                        btn_alterar.Enabled = false;
                    }
                    else
                    {
                        btn_alterar.Enabled = true;
                    }
                    btn_limpar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Registro não encontrado");
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
                conexao.Close();
            }
        }

        private void btn_trocSen_Click(object sender, EventArgs e)
        {
            if (txt_senha.Text == txt_confS.Text)
            {
                DialogResult d2 = MessageBox.Show("Tem realmente ceteza que quer alterar a senha?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d2 == DialogResult.Yes)
                {
                    txt_newsenha.Visible = true;
                    txt_confnewsenha.Visible = true;
                    label15.Visible = true;
                    label14.Visible = true;
                    btn_trocSen.Enabled = false;
                    btn_alterar.Enabled = true;
                    MessageBox.Show("Digite sua nova senha e pressione Alterar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_newsenha.Focus();
                }
                else
                {
                    label10.Visible = false;
                    txt_senha.Visible = false;
                    label12.Visible = false;
                    txt_confS.Visible = false;
                    btn_trocSen.Enabled = false;
                    btn_alterar.Enabled = true;
                    MessageBox.Show("Se desejar Trocar sua Senha, pesquise o RG novamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("As senhas não se coincidem", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confS.Text = "";
                txt_confS.Focus();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //Alterando os Registros (Exceto a Senha)
            string altera = "UPDATE TB_FUNCIONARIO SET NOME= '" + txt_nome.Text + "', SOBRENOME= '" + txt_sbr.Text + "', RG= '" + txt_rg.Text + "', CPF='" + txt_cpf.Text + "', BAIRRO='" + txt_bairro.Text + "', RUA='" + txt_rua.Text + "', NUMERO='" + txt_num.Text + "', COMPLEMENTO = '" + txt_compl.Text + "'";
            SqlCommand cmd = new SqlCommand(altera, conexao);

            try
            {
                conexao.Open();
                int resultado;
                resultado = cmd.ExecuteNonQuery();
                if (resultado >= 1)
                {
                    MessageBox.Show("Registro alterado com sucesso");
                }
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            //Alterando a Senha
            if (txt_newsenha.Visible == true && txt_confnewsenha.Visible == true)
            {
                if (txt_newsenha.Text == txt_confnewsenha.Text && txt_newsenha.Text != "" && txt_confnewsenha.Text != "")
                {
                    string trocsen = "UPDATE TB_FUNCIONARIO SET SENHA= '" + txt_newsenha.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(trocsen, conexao);

                    try
                    {
                        conexao.Open();
                        int resul;
                        resul = cmd2.ExecuteNonQuery();

                        if (resul >= 1)
                        {
                            MessageBox.Show("Senha alterada com sucesso", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_newsenha.Text = "";
                            txt_confnewsenha.Text = "";
                            txt_confS.Text = "";
                            txt_newsenha.Visible = false;
                            txt_confnewsenha.Visible = false;
                            txt_confS.Visible = false;
                            label15.Visible = false;
                            label14.Visible = false;
                            label12.Visible = false;
                        }
                        cmd2.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao alterar no Banco : " + ex.Message);
                        txt_newsenha.Text = "";
                        txt_confnewsenha.Text = "";
                        txt_newsenha.Focus();
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else
                {
                    MessageBox.Show("As novas senhas no se coincidem ou estão em branco", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_newsenha.Text = "";
                    txt_confnewsenha.Text = "";
                    txt_newsenha.Focus();
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_sbr.Text = "";
            txt_rg.Text = "";
            txt_cpf.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";
            txt_num.Text = "";
            txt_compl.Text = "";
            txt_login.Text = "";
            txt_telefone.Text = "";
            txt_senha.Text = "";
            txt_pesquisa.Text = "";
            txt_pesquisa.Focus();
            btn_alterar.Enabled = false;
            btn_limpar.Enabled = false;
            btn_trocSen.Enabled = false;
            label10.Visible = false;
            txt_senha.Visible = false;
            label12.Visible = false;
            txt_confS.Visible = false;
            label15.Visible = false;
            txt_newsenha.Visible = false;
            label14.Visible = false;
            txt_confnewsenha.Visible = false;
        }

    }
}
