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
using MaterialSkin;
using MaterialSkin.Controls;

namespace software_Pet
{
    public partial class frm_alterafunc : MaterialForm
    {
        public frm_alterafunc()
        {
            InitializeComponent();
        }

        //Void uitilizada para voltar a posição inicial
        void limpar()
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
            txt_pesquisa.Focus();
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_limpar.Enabled = false;
            btn_trocSen.Enabled = false;
            label1.Visible = false;
            txt_nome.Visible = false;
            label2.Visible = false;
            txt_sbr.Visible = false;
            label3.Visible = false;
            txt_rg.Visible = false;
            label4.Visible = false;
            txt_cpf.Visible = false;
            label5.Visible = false;
            txt_bairro.Visible = false;
            label6.Visible = false;
            txt_rua.Visible = false;
            label7.Visible = false;
            txt_num.Visible = false;
            label8.Visible = false;
            txt_compl.Visible = false;
            label9.Visible = false;
            txt_login.Visible = false;
            label13.Visible = false;
            txt_telefone.Visible = false;
            label10.Visible = false;
            txt_senha.Visible = false;
            label12.Visible = false;
            txt_confS.Visible = false;
            label15.Visible = false;
            txt_newsenha.Visible = false;
            label14.Visible = false;
            txt_confnewsenha.Visible = false;
            label11.Visible = false;         
        }

        private void btn_Vol_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO FUNCIONARIO (Objeto txt_pesquisa)
        private void txt_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_pesquisa.MaxLength = 12;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_pesquisa.TextLength)
                {
                    case 2:
                        txt_pesquisa.Text = txt_pesquisa.Text + ".";
                        txt_pesquisa.SelectionStart = 3;
                        break;
                    case 6:
                        txt_pesquisa.Text = txt_pesquisa.Text + ".";
                        txt_pesquisa.SelectionStart = 8;
                        break;
                    case 10:
                        txt_pesquisa.Text = txt_pesquisa.Text + "-";
                        txt_pesquisa.SelectionStart = 11;
                        break;
                }
            }
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO FUNCIONARIO (Objeto txt_rg)
        private void txt_rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_rg.MaxLength = 12;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_rg.TextLength)
                {
                    case 2:
                        txt_rg.Text = txt_rg.Text + ".";
                        txt_rg.SelectionStart = 3;
                        break;
                    case 6:
                        txt_rg.Text = txt_rg.Text + ".";
                        txt_rg.SelectionStart = 8;
                        break;
                    case 10:
                        txt_rg.Text = txt_rg.Text + "-";
                        txt_rg.SelectionStart = 11;
                        break;
                }
            }
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO CPF DO FUNCIONARIO (Objeto txt_cpf)
        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_cpf.MaxLength = 14;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_cpf.TextLength)
                {
                    case 3:
                        txt_cpf.Text = txt_cpf.Text + ".";
                        txt_cpf.SelectionStart = 4;
                        break;
                    case 7:
                        txt_cpf.Text = txt_cpf.Text + ".";
                        txt_cpf.SelectionStart = 8;
                        break;
                    case 11:
                        txt_cpf.Text = txt_cpf.Text + "-";
                        txt_cpf.SelectionStart = 12;
                        break;
                }
            }
        }

        //CODIGO UTILIZADO PARA IMPEDIR QUE O USUARIO NÃO UTILIZE AS TECLAS DE LETRAS DO TECLADO
        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_num.MaxLength = 4;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //CODIGO UTILIZADO PARA ADICINAR PARENTESES E TRAÇOS AUTOMATICAMENTE NO TELEFONE DO FUNCIONARIO (Objeto txt_telefone)
        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_telefone.MaxLength = 14;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_telefone.TextLength)
                {
                    case 0:
                        txt_telefone.Text = txt_telefone.Text + "(";
                        txt_telefone.SelectionStart = 2;
                        break;
                    case 3:
                        txt_telefone.Text = txt_telefone.Text + ")";
                        txt_telefone.SelectionStart = 5;
                        break;
                    case 9:
                        txt_telefone.Text = txt_telefone.Text + "-";
                        txt_telefone.SelectionStart = 11;
                        break;
                }
            }
        }

        private void btn_pesquisa_Click_1(object sender, EventArgs e)
        {
            DialogResult d1 = MessageBox.Show("Quer alterar a senha?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d1 == DialogResult.Yes)
            {
                //Deixando os demais objetos de Dados Invisiveis
                label1.Visible = false;
                txt_nome.Visible = false;
                label2.Visible = false;
                txt_sbr.Visible = false;
                label3.Visible = false;
                txt_rg.Visible = false;
                label4.Visible = false;
                txt_cpf.Visible = false;
                label5.Visible = false;
                txt_bairro.Visible = false;
                label6.Visible = false;
                txt_rua.Visible = false;
                label7.Visible = false;
                txt_num.Visible = false;
                label8.Visible = false;
                txt_compl.Visible = false;
                label9.Visible = false;
                txt_login.Visible = false;
                label13.Visible = false;
                txt_telefone.Visible = false;
                label11.Visible = true;

                //Deixando os objetos da Senha Visiveis
                label10.Visible = true;
                txt_senha.Text = ""; //Limpando o campo para não haver indicios da pesquisa anterior
                txt_senha.Visible = true;

                label12.Visible = true;
                txt_confS.Text = ""; //Limpando o campo para não haver indicios da pesquisa anterior
                txt_confS.Visible = true;

                btn_trocSen.Enabled = true;
                txt_confS.Focus();
                MessageBox.Show("Confirme sua senha atual e pressione Trocar Senha", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Limpando os objetos (TextBox) caso ja tenha ocorrido uma pesquisa anteriormente
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

                //Deixando os demais objetos de Dados Visiveis
                label1.Visible = true;
                txt_nome.Visible = true;
                label2.Visible = true;
                txt_sbr.Visible = true;
                label3.Visible = true;
                txt_rg.Visible = true;
                label4.Visible = true;
                txt_cpf.Visible = true;
                label5.Visible = true;
                txt_bairro.Visible = true;
                label6.Visible = true;
                txt_rua.Visible = true;
                label7.Visible = true;
                txt_num.Visible = true;
                label8.Visible = true;
                txt_compl.Visible = true;
                label9.Visible = true;
                txt_login.Visible = true;
                label13.Visible = true;
                txt_telefone.Visible = true;
                label11.Visible = true;

                //Deixando os objetos da Senha Invisiveis
                label12.Visible = false;
                txt_confS.Visible = false;
                label10.Visible = false;
                txt_senha.Visible = false;
                btn_trocSen.Enabled = false;
                txt_nome.Focus();
            }

            string pesquisa = "SELECT * FROM TB_FUNCIONARIO WHERE RG= '" + txt_pesquisa.Text + "'";
            SqlCommand cmd = new SqlCommand(pesquisa, DataBase.obterConexao());
            SqlDataReader DR;
            try
            {
                DataBase.obterConexao();
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
                        btn_excluir.Enabled = false;
                    }
                    else
                    {
                        btn_alterar.Enabled = true;
                        btn_excluir.Enabled = true;
                    }
                    btn_limpar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Registro não encontrado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    //Deixando os objetos invisiveis
                    label1.Visible = false;
                    txt_nome.Visible = false;
                    label2.Visible = false;
                    txt_sbr.Visible = false;
                    label3.Visible = false;
                    txt_rg.Visible = false;
                    label4.Visible = false;
                    txt_cpf.Visible = false;
                    label5.Visible = false;
                    txt_bairro.Visible = false;
                    label6.Visible = false;
                    txt_rua.Visible = false;
                    label7.Visible = false;
                    txt_num.Visible = false;
                    label8.Visible = false;
                    txt_compl.Visible = false;
                    label9.Visible = false;
                    txt_login.Visible = false;
                    label13.Visible = false;
                    txt_telefone.Visible = false;
                    label11.Visible = false;

                    //Deixando txt_pesquisa em branco
                    txt_pesquisa.Text = "";

                    //Dando faco no TextView pesqisar
                    txt_pesquisa.Focus();
                    btn_alterar.Enabled = false;
                    btn_excluir.Enabled = false;
                    btn_limpar.Enabled = false;
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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string remove = "DELETE FROM TB_FUNCIONARIO WHERE RG= '" + txt_rg.Text + "'";
            SqlCommand cmd = new SqlCommand(remove, DataBase.obterConexao());
            try
            {
                DataBase.obterConexao();
                int resultado;

                if (MessageBox.Show("Tem certeza que deseja remover este registro ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    if (resultado >= 1)
                    { 
                        MessageBox.Show("Registro removido com sucesso","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        //Deixando os objetos invisiveis
                        label1.Visible = false;
                        txt_nome.Visible = false;
                        label2.Visible = false;
                        txt_sbr.Visible = false;
                        label3.Visible = false;
                        txt_rg.Visible = false;
                        label4.Visible = false;
                        txt_cpf.Visible = false;
                        label5.Visible = false;
                        txt_bairro.Visible = false;
                        label6.Visible = false;
                        txt_rua.Visible = false;
                        label7.Visible = false;
                        txt_num.Visible = false;
                        label8.Visible = false;
                        txt_compl.Visible = false;
                        label9.Visible = false;
                        txt_login.Visible = false;
                        label13.Visible = false;
                        txt_telefone.Visible = false;
                        btn_alterar.Enabled = false;
                        btn_excluir.Enabled = false;
                        btn_limpar.Enabled = false;
                        label11.Visible = false;

                        //Dando faco no TextView pesqisar
                        btn_pesquisa.Focus();

                        Application.Restart();
                    }
                    cmd.Dispose();
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
        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            //Alterando os Registros (Exceto a Senha)
            if (txt_newsenha.Visible != true && txt_confnewsenha.Visible != true)
            {
                string altera = "UPDATE TB_FUNCIONARIO SET NOME= '" + txt_nome.Text + "', SOBRENOME= '" + txt_sbr.Text + "', BAIRRO='" + txt_bairro.Text + "', RUA='" + txt_rua.Text + "', NUMERO='" + txt_num.Text + "', COMPLEMENTO='" + txt_compl.Text + "', TELEFONE='" + txt_telefone.Text + "', LOGIN='" + txt_login.Text + "' WHERE RG='" + txt_rg.Text + "'";
                SqlCommand cmd = new SqlCommand(altera, DataBase.obterConexao());

                try
                {
                    DataBase.obterConexao();
                    int resultado;
                    resultado = cmd.ExecuteNonQuery();

                    if (resultado >= 1)
                    {
                        MessageBox.Show("Registro alterado com sucesso","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        //Deixando os objetos invisiveis
                        label1.Visible = false;
                        txt_nome.Visible = false;
                        label2.Visible = false;
                        txt_sbr.Visible = false;
                        label3.Visible = false;
                        txt_rg.Visible = false;
                        label4.Visible = false;
                        txt_cpf.Visible = false;
                        label5.Visible = false;
                        txt_bairro.Visible = false;
                        label6.Visible = false;
                        txt_rua.Visible = false;
                        label7.Visible = false;
                        txt_num.Visible = false;
                        label8.Visible = false;
                        txt_compl.Visible = false;
                        label9.Visible = false;
                        txt_login.Visible = false;
                        label13.Visible = false;
                        txt_telefone.Visible = false;
                        btn_alterar.Enabled = false;
                        btn_excluir.Enabled = false;
                        btn_limpar.Enabled = false;
                        label11.Visible = false;

                        //Dando faco no botão pesqisar
                        btn_pesquisa.Focus();

                        Application.Restart();
                    }
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

            //Alterando a Senha
            else if (txt_newsenha.Visible == true && txt_confnewsenha.Visible == true)
            {
                if (txt_newsenha.Text == txt_confnewsenha.Text && txt_newsenha.Text != "" && txt_confnewsenha.Text != "")
                {
                    string trocsen = "UPDATE TB_FUNCIONARIO SET SENHA= '" + txt_newsenha.Text + "' WHERE RG='" + txt_rg.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(trocsen, DataBase.obterConexao());

                    try
                    {
                        DataBase.obterConexao();
                        int resul;
                        resul = cmd2.ExecuteNonQuery();

                        if (resul >= 1)
                        {
                            MessageBox.Show("Senha alterada com sucesso", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_newsenha.Text = "";
                            txt_confnewsenha.Text = "";
                            txt_confS.Text = "";
                            label10.Visible = false;
                            txt_senha.Visible = false;
                            label12.Visible = false;
                            txt_confS.Visible = false;
                            label15.Visible = false;
                            txt_newsenha.Visible = false;
                            label14.Visible = false;
                            txt_confnewsenha.Visible = false;
                            btn_alterar.Enabled = false;
                            label11.Visible = false;
                            btn_limpar.Enabled = false;
                        }
                        cmd2.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txt_newsenha.Text = "";
                        txt_confnewsenha.Text = "";
                        txt_newsenha.Focus();
                    }
                    finally
                    {
                        DataBase.fecharConexao();
                    }
                }
                else
                {
                    MessageBox.Show("As novas senhas não se coincidem ou estão em branco", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_newsenha.Text = "";
                    txt_confnewsenha.Text = "";
                    txt_newsenha.Focus();
                }
            }
        }

        private void btn_trocSen_Click_1(object sender, EventArgs e)
        {
            if (txt_senha.Text == txt_confS.Text)
            {
                    label15.Visible = true;
                    txt_newsenha.Visible = true;
                    label14.Visible = true;
                    txt_confnewsenha.Visible = true;
                    btn_trocSen.Enabled = false;
                    btn_alterar.Enabled = true;
                    label11.Visible = false;
                    MessageBox.Show("Digite sua nova senha e pressione Alterar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_newsenha.Focus();
            }
            else
            {
                MessageBox.Show("As senhas não se coincidem", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confS.Text = "";
                txt_confS.Focus();
            }
        }

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void frm_alterafunc_Load(object sender, EventArgs e)
        {
            string pesq = "SELECT * FROM TB_DADOS_LOG";
            SqlCommand cmd = new SqlCommand(pesq, DataBase.obterConexao());
            SqlDataReader DR;
            try
            {
                DataBase.obterConexao();
                DR = cmd.ExecuteReader();

                if(DR.Read())
                {
                    txt_pesquisa.Text = DR.GetValue(2).ToString();
                }
                DR.Close();
                cmd.Dispose();
            }
            catch(Exception ex)
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
