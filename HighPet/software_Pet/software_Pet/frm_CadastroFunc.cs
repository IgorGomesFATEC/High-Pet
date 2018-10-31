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
    public partial class frm_CadastroFunc : MaterialForm
    {
        public frm_CadastroFunc()
        {
            InitializeComponent();
        }

        void limpar()
        {
            txt_bairro.Clear();
            txt_compl.Clear();
            txt_confS.Clear();
            txt_cpf.Clear();
            txt_login.Clear();
            txt_nome.Clear();
            txt_num.Clear();
            txt_rg.Clear();
            txt_rua.Clear();
            txt_sbr.Clear();
            txt_senha.Clear();
            txt_telefone.Clear();

            txt_nome.Focus();
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

        private void btn_Vol_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_conf_Click_1(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && txt_sbr.Text != "" && txt_rg.Text != "" && txt_cpf.Text != "" && txt_bairro.Text != "" && txt_rua.Text != "" && txt_num.Text != "" && txt_login.Text != "" && txt_senha.Text != "" && txt_confS.Text != "")
            {
                if (txt_senha.Text != txt_confS.Text)
                {
                    MessageBox.Show("As Senhas não são iguais","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else if (txt_senha.Text == txt_confS.Text)
                {
                    string add = "INSERT INTO TB_FUNCIONARIO(NOME,SOBRENOME,RG,CPF,BAIRRO,RUA,NUMERO,COMPLEMENTO,TELEFONE,LOGIN,SENHA)VALUES(" + "'" + txt_nome.Text + "','" + txt_sbr.Text + "','" + txt_rg.Text + "','" + txt_cpf.Text + "','" + txt_bairro.Text + "','" + txt_rua.Text + "','" + txt_num.Text + "','" + txt_compl.Text + "','" + txt_telefone.Text + "','" + txt_login.Text + "','" + txt_senha.Text + "')";
                    SqlCommand cmd = new SqlCommand(add, DataBase.obterConexao());

                    try
                    {
                        DataBase.obterConexao();
                        int resultado;
                        resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro adicionado com SUCESSO", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            limpar();
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
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_nome.Focus();
            }
        }
    }
}
