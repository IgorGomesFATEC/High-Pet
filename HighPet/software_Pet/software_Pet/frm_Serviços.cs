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
    public partial class frm_Serviços : MaterialForm
    {
        //Variavel utilizada para guardar o preço do "serviço" e calcular os pontos de fidelidade
        Double precoServ;

        //variavel utilizada para guardar o "bonus"
        Double bonus;

        //Variaveis para guardarem as chaves estrangeiras (foreign key)
        string COD_FUNCIONARIO;
        string COD_SERVICO;
        string COD_ANIMAL;

        public frm_Serviços()
        {
            InitializeComponent();       
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO FUNCIONARIO (Objeto txt_rg_func)
        private void txt_rg_func_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_rg_func.MaxLength = 12;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_rg_func.TextLength)
                {
                    case 2:
                        txt_rg_func.Text = txt_rg_func.Text + ".";
                        txt_rg_func.SelectionStart = 3;
                        break;
                    case 6:
                        txt_rg_func.Text = txt_rg_func.Text + ".";
                        txt_rg_func.SelectionStart = 8;
                        break;
                    case 10:
                        txt_rg_func.Text = txt_rg_func.Text + "-";
                        txt_rg_func.SelectionStart = 11;
                        break;
                }
            }
        }

        //CODIGO UTILIZADO PARA COLOCAR BARRAS NAS DATAS DO SERVIÇOS
        private void txt_data_serv_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_data_serv.MaxLength = 10;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_data_serv.TextLength)
                {
                    case 2:
                        txt_data_serv.Text = txt_data_serv.Text + "/";
                        txt_data_serv.SelectionStart = 3;
                        break;
                    case 5:
                        txt_data_serv.Text = txt_data_serv.Text + "/";
                        txt_data_serv.SelectionStart = 6;
                        break;
                }
            }
        }

        //Selecionar Nome e Sobrenome do Funcionario pelo seu RG
        private void txt_rg_func_Leave(object sender, EventArgs e)
        {
            /*if (txt_rg_func.Text != "")
            {
                string pesquisa = "SELECT NOME, SOBRENOME FROM TB_FUNCIONARIO WHERE RG= '" + txt_rg_func.Text + "'";
                SqlCommand cmd = new SqlCommand(pesquisa, conexao);
                SqlDataReader DR;

                try
                {
                    conexao.Open();
                    DR = cmd.ExecuteReader();

                    if (DR.Read())
                    {
                        lbl_exp_nome_func.Text = DR["NOME"].ToString();
                        lbl_exp_sbrnome_func.Text = DR["SOBRENOME"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Registros do Funcionario não encontrados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_rg_func.Text = "";
                        txt_rg_func.Focus();
                    }
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
            else
            {
                txt_rg_func.Focus();
                MessageBox.Show("Informe o RG do Funcionario", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        //CODIGO UTILIZADO PARA IMPEDIR QUE O USUARIO NÃO UTILIZE AS TECLAS DE LETRAS DO TECLADO
        private void txt_protocolo_animal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_protocolo_animal.MaxLength = 6;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //Selecionar Nome do Animal pelo seu Protocolo
        private void txt_protocolo_animal_Leave(object sender, EventArgs e)
        {
            if (txt_protocolo_animal.Text != "")
            {
                string pesquisa = "SELECT NOME_ANIMAL FROM TB_ANIMAL WHERE PROTOCOLO_ANIMAL = '" + txt_protocolo_animal.Text + "'";
                SqlCommand cmd = new SqlCommand(pesquisa, DataBase.obterConexao());
                SqlDataReader DR;

                try
                {
                    DataBase.obterConexao();
                    DR = cmd.ExecuteReader();

                    if (DR.Read())
                    {
                        lbl_exp_nome_animal.Text = DR["NOME_ANIMAL"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Não há um Animal com esse Protocolo registrado no Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_protocolo_animal.Text = "";
                        txt_protocolo_animal.Focus();
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
            else
            {
                txt_protocolo_animal.Focus();
                MessageBox.Show("Informe o Protocolo do Animal", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Quando formulario é iniciado é selecionado o ultimo protocolo que foi adicionado no banco
        //Quando formulário é iniciado seleciona o usuario logado
        private void frm_Serviços_Load(object sender, EventArgs e)
        {
            //PROTOCOLO
            string pesquisa = "SELECT * FROM TB_PROTOCOLO";
            SqlCommand cmd = new SqlCommand(pesquisa, DataBase.obterConexao());
            SqlDataReader DR;

            try
            {
                DataBase.obterConexao();
                DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    lbl_prot_ocult.Text = DR.GetValue(0).ToString();
                }
                else
                {
                    MessageBox.Show("Erro para pegar o valor do protocolo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            //USUARIO
            string pesq = "SELECT * FROM TB_DADOS_LOG";
            SqlCommand cmd2 = new SqlCommand(pesq, DataBase.obterConexao());
            SqlDataReader DR2;
            try
            {
                DataBase.obterConexao();
                DR2 = cmd2.ExecuteReader();

                if (DR2.Read())
                {
                    txt_rg_func.Text = DR2.GetValue(2).ToString();
                    lbl_exp_nome_func.Text = DR2.GetValue(0).ToString();
                    lbl_exp_sbrnome_func.Text = DR2.GetValue(1).ToString();
                }
                DR2.Close();
                cmd2.Dispose();
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

        //EVENTO QUE VAI GERAR O PROTOCOLO DO SERVIÇO E EXPOR NO OBJETO lbl_exp_protocolo
        private void txt_data_serv_Leave(object sender, EventArgs e)
        {
            if (txt_data_serv.Text != "")
            {
                int ValorProt;
                ValorProt = Convert.ToInt32(lbl_prot_ocult.Text);

                int NovoValorProt;
                NovoValorProt = ValorProt + 1;

                string alteraProt = "UPDATE TB_PROTOCOLO SET PROTOCOLO_VALOR = '" + NovoValorProt + "'";
                lbl_prot_ocult.Text = Convert.ToString(NovoValorProt);

                SqlCommand cmd = new SqlCommand(alteraProt, DataBase.obterConexao());

                try
                {
                    DataBase.obterConexao();
                    int resultado;
                    resultado = cmd.ExecuteNonQuery();

                    if (resultado >= 1)
                    {
                        lbl_exp_protocolo.Visible = true;
                        lbl_exp_protocolo.Text = Convert.ToString(NovoValorProt);
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
            else
            {
                txt_data_serv.Focus();
                MessageBox.Show("Informe a Data do Serviço", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gerar_pontos_Click_1(object sender, EventArgs e)
        {
            if (txt_preco_serv.Text != "") //Verificando se há algo digitado no txt_preco_serv
            {
                try //Verificando se é um valor numérico
                {
                    //Coletando o valor do serviço e colocando na variavel
                    precoServ = Convert.ToDouble(txt_preco_serv.Text);
                    if (precoServ > 0)
                    {
                        //Fazendo o calculo
                        bonus = precoServ * 0.1;

                        //Exibindo resultado após o calculo
                        lbl_exp_pontos.Visible = true;
                        lbl_exp_pontos.Text = Convert.ToString(bonus);
                    }
                    else
                    {
                        MessageBox.Show("Para serviços GRATUITOS, não há Bonus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bonus = precoServ * 0.1;
                        lbl_exp_pontos.Visible = true;
                        lbl_exp_pontos.Text = Convert.ToString(bonus);
                    }
                }
                catch
                {
                    MessageBox.Show("Informe valores numéricos para o Preço do Serviço", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_preco_serv.Text = "";
                    txt_preco_serv.Focus();
                }
            }
            else
            {
                txt_preco_serv.Focus();
                MessageBox.Show("Informe o Preço do Serviço", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            if (txt_rg_func.Text != "" && lbl_exp_nome_func.Text != "" && lbl_exp_sbrnome_func.Text != "" && txt_protocolo_animal.Text != "" && lbl_exp_nome_animal.Text != "" && txt_data_serv.Text != "" && cbo_descri_serv.Text != "" && lbl_exp_protocolo.Visible == true && lbl_exp_protocolo.Text != "" && txt_preco_serv.Text != "" && lbl_exp_pontos.Text != "")
            {
                if (lbl_exp_pontos.Visible == true)
                {
                    //EFETUANDO CADASTRO DO SERVIÇO *****************************************************************************************************

                    //TABELA TB_SERVICO *****************************************************************************************************************

                    //Covertendo o Protocolo do Serviço
                    int protocolo_servico = Convert.ToInt32(lbl_exp_protocolo.Text);

                    //Inserindo dados na TABELA TB_SERVICO
                    string add = "INSERT INTO TB_SERVICO(DESCRICAO_SERVICO, PROTOCOLO_SERVICO, PRECO_SERVICO) VALUES (" + "'" + cbo_descri_serv.Text + "', '" + protocolo_servico + "', '" + precoServ + "')";
                    SqlCommand cmd1 = new SqlCommand(add, DataBase.obterConexao());
                    try
                    {
                        DataBase.obterConexao();
                        int resultado;
                        resultado = cmd1.ExecuteNonQuery();

                        if (resultado > 0)
                        {
       
                        }
                        cmd1.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        DataBase.fecharConexao();
                    }

                    //CRIAÇÃO DAS CHAVES ESTRANGEIRAS (FOREIGN KEY) **********************************************************************************************

                    //COD_FUNCIONARIO
                    string sclt = "SELECT ID_FUNCIONARIO FROM TB_FUNCIONARIO WHERE RG= '" + txt_rg_func.Text + "'";
                    DataBase.obterConexao();
                    SqlCommand cmd2 = new SqlCommand(sclt, DataBase.obterConexao());
                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        COD_FUNCIONARIO = dr["ID_FUNCIONARIO"].ToString();
                    }
                    DataBase.fecharConexao();

                    //COD_SERVICO
                    string sclt2 = "SELECT ID_SERVICO FROM TB_SERVICO WHERE PROTOCOLO_SERVICO= '" + protocolo_servico + "'";
                    DataBase.obterConexao();
                    SqlCommand cmd3 = new SqlCommand(sclt2, DataBase.obterConexao());
                    SqlDataReader dr2 = cmd3.ExecuteReader();

                    if (dr2.Read())
                    {
                        COD_SERVICO = dr2["ID_SERVICO"].ToString();
                    }
                    DataBase.fecharConexao();

                    //COD_ANIMAL

                    //Covertendo o Protocolo do Animal
                    int protocolo_animal = Convert.ToInt32(txt_protocolo_animal.Text);

                    string sclt3 = "SELECT ID_ANIMAL FROM TB_ANIMAL WHERE PROTOCOLO_ANIMAL= '" + protocolo_animal + "'";
                    DataBase.obterConexao();
                    SqlCommand cmd4 = new SqlCommand(sclt3, DataBase.obterConexao());
                    SqlDataReader dr3 = cmd4.ExecuteReader();

                    if (dr3.Read())
                    {
                        COD_ANIMAL = dr3["ID_ANIMAL"].ToString();
                    }
                    DataBase.fecharConexao();

                    //TABELA TB_ANIMAL_SERVICO ********************************************************************************************************

                    //Inserindo dados na TABELA TB_ANIMAL_SERVICO
                    string add2 = "INSERT INTO TB_ANIMAL_SERVICO(COD_FUNCIONARIO, COD_SERVICO, COD_ANIMAL, DATA_SERVICO) VALUES (" + "'" + COD_FUNCIONARIO + "', '" + COD_SERVICO + "', '" + COD_ANIMAL + "', '" + txt_data_serv.Text + "')";
                    SqlCommand cmd5 = new SqlCommand(add2, DataBase.obterConexao());
                    try
                    {
                        DataBase.obterConexao();
                        int resultado;
                        resultado = cmd5.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                          
                        }
                        cmd5.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        DataBase.fecharConexao();
                    }

                    //TABELA TB_BONUS_FIDELIDADE *****************************************************************************************************

                    //Inserindo dados na TABELA TB_BONUS_FIDELIDADE
                    string add3 = "INSERT INTO TB_BONUS_FIDELIDADE(COD_ANIMAL, COD_SERVICO, PONTOS_FIDELIDADE) VALUES (" + "'" + COD_ANIMAL + "', '" + COD_SERVICO + "', '" + bonus + "')";
                    SqlCommand cmd6 = new SqlCommand(add3, DataBase.obterConexao());
                    try
                    {
                        DataBase.obterConexao();
                        int resultado;
                        resultado = cmd6.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            //Mensagem de confirmação para o usuário
                            MessageBox.Show("Registros adicionados com sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Limpando todos os objetos e voltando a posição inicial
                            txt_protocolo_animal.Text = "";
                            lbl_exp_nome_animal.Text = "";
                            txt_data_serv.Text = "";
                            cbo_descri_serv.Text = "";
                            lbl_exp_protocolo.Visible = false;
                            lbl_exp_protocolo.Text = "";
                            txt_preco_serv.Text = "";
                            lbl_exp_pontos.Visible = false;
                            lbl_exp_pontos.Text = "";
                            txt_rg_func.Focus();
                        }
                        cmd6.Dispose();
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
                else
                {
                    txt_preco_serv.Focus();
                    MessageBox.Show("Informe o Preço do Serviço e pressione Gerar Pontos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Mensagem de orientação
                MessageBox.Show("Por favor preencha todos os campos e pressione Gerar Pontos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpando todos os objetos e voltando a posição inicial
                txt_protocolo_animal.Text = "";
                lbl_exp_nome_animal.Text = "";
                txt_data_serv.Text = "";
                cbo_descri_serv.Text = "";
                lbl_exp_protocolo.Visible = false;
                lbl_exp_protocolo.Text = "";
                txt_preco_serv.Text = "";
                lbl_exp_pontos.Visible = false;
                lbl_exp_pontos.Text = "";
                txt_rg_func.Focus();
            }
        }

        //LEMBRETE DAS PROPRIEDADES DO OBJETO COMBOBOX
        /*A propriedade SelectedIndex é utilida para se trabalhar com os elementos que serão escolhido em um ComboBox
         EXEMPLOS: if (ComboBox.SelectedIndex == -1) é a condição utilizada para verificar se há algum elemento para ser escolhido no objeto
                   ComboBox.Clear() é o comundo utilizado para se limpar (apagar) todos os elementos (inclusive os da propriedade Text) do objeto*/

        //EVENTO LEAVE EM UM TEXTBOX QUE FAZ APARECER TODOS OS ANIMAIS DE UM DONO PELO SEU RG EM UM COMBOBOX
        //Variavel para pesquisar animais referentes ao RG do Dono
        //string NomeAnimal;
        /*private void txt_rg_dono_Leave(object sender, EventArgs e)
        {
            if (txt_rg_dono.Text != "")
            {
                string slct = "SELECT A.NOME_ANIMAL, D.RG FROM TB_DONO D, TB_ANIMAL A WHERE D.ID_DONO = A.COD_DONO AND D.RG='" + txt_rg_dono.Text + "'";
                SqlCommand cmd = new SqlCommand(slct, conexao);
                SqlDataReader dr;

                try
                {
                    conexao.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        NomeAnimal = dr["NOME_ANIMAL"].ToString();
                        cbo_nome_animal.Items.Add(NomeAnimal);
                    }
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
            else
            {
                txt_rg_dono.Focus();
                MessageBox.Show("Informe o RG do Dono", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}
