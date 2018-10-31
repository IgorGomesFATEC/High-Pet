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
    public partial class frm_BonusFidelidade : MaterialForm
    {
        //Variavel para o Comando SELECT SUM
        string COD_ANIMAL;

        //Variaveis utilizadas para Calcular os Pontos de Fidelidade
        Double pontos_acumulados;
        Double pontos_antes_remov;
        Double pontuacao_final_antes_rmv_pontos;

        public frm_BonusFidelidade()
        {
            InitializeComponent();
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

        //CODIGO UTILIZADO PARA IMPEDIR QUE O USUARIO NÃO UTILIZE AS TECLAS DE LETRAS DO TECLADO
        private void txt_pontos_rmv_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_pontos_rmv.MaxLength = 7;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_protocolo_animal_Leave(object sender, EventArgs e)
        {
            if (txt_protocolo_animal.Text != "")
            {
                //BUSCANDO O NOME DO ANIMAL PELO SEU PROTOCOLO **********************************************************************************************************
                string pesquisa = "SELECT NOME_ANIMAL FROM TB_ANIMAL WHERE PROTOCOLO_ANIMAL = '" + txt_protocolo_animal.Text + "'";
                SqlCommand cmd = new SqlCommand(pesquisa, DataBase.obterConexao());
                SqlDataReader dr;

                try
                {
                    DataBase.obterConexao();
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lbl_exp_nome_animal.Text = dr["NOME_ANIMAL"].ToString();
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

                //BUSCANDO A QUANTIDADE DE PONTOS DO ANIMAL PELA SUA CHAVE ESTRANGEIRA (FOREIGN KEY) ***********************************************************************

                //COD_ANIMAL
                if (lbl_exp_nome_animal.Text != "")
                {
                    //Covertendo o Protocolo do Animal
                    int protocolo_animal = Convert.ToInt32(txt_protocolo_animal.Text);

                    string sclt = "SELECT ID_ANIMAL FROM TB_ANIMAL WHERE PROTOCOLO_ANIMAL= '" + protocolo_animal + "'";
                    DataBase.obterConexao();
                    SqlCommand cmd2 = new SqlCommand(sclt, DataBase.obterConexao());
                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.Read())
                    {
                        COD_ANIMAL = dr2["ID_ANIMAL"].ToString();
                    }
                    DataBase.fecharConexao();
                }

                //COLETANDO PONTOS CONQUISTADOS COM TODOS OS SERVIÇO JÁ FEITOS PARA O ANIMAL *******************************************************************************
                //Coletando o total de pontos de fidelidade
                DataBase.obterConexao();
                string sclt2 = "SELECT SUM(PONTOS_FIDELIDADE) AS TOTAL FROM TB_BONUS_FIDELIDADE WHERE COD_ANIMAL = '" + COD_ANIMAL + "'";
                SqlCommand cmd3 = new SqlCommand(sclt2, DataBase.obterConexao());
                SqlDataReader dr3 = cmd3.ExecuteReader();

                try
                {
                    if (dr3.Read())
                    {
                        lbl_exp_pontos_acumulados.Text = dr3["TOTAL"].ToString();
                        pontos_acumulados = Convert.ToDouble(lbl_exp_pontos_acumulados.Text);
                    }
                }
                catch
                {
                    lbl_exp_pontos_acumulados.Text = "0";
                    pontos_acumulados = Convert.ToDouble(lbl_exp_pontos_acumulados.Text);
                }
                finally
                {
                    DataBase.fecharConexao();
                }

                //COLETANDO A PONTAÇÃO FINAL DO ANIMAL ANTES DE ROMONER NOVOS PONTOS *****************************************************************************************
                if (pontos_acumulados > 0) //Se achou algum registro é porque o animal possui pontuação
                {
                    //CHECANDO SE JÁ FOI DESCANTODO PONTOS DO ANIMAL
                    DataBase.obterConexao();
                    string sclt3 = "SELECT SUM(PONTOS_RETIRADOS) AS TOTAL FROM TB_OPERACAO_PONTOS WHERE COD_ANIMAL = '" + COD_ANIMAL + "'";
                    SqlCommand cmd4 = new SqlCommand(sclt3, DataBase.obterConexao());
                    SqlDataReader dr4 = cmd4.ExecuteReader();

                    try
                    {
                        if (dr4.Read())
                        {
                            lbl_pontos_antes_remov.Text = dr4["TOTAL"].ToString();
                            pontos_antes_remov = Convert.ToDouble(lbl_pontos_antes_remov.Text);
                        }
                    }
                    catch
                    {
                        lbl_pontos_antes_remov.Text = "0";
                        pontos_antes_remov = Convert.ToDouble(lbl_pontos_antes_remov.Text);
                    }
                    finally
                    {
                        DataBase.fecharConexao();
                    }

                    if (pontos_antes_remov > 0) //SE TEVE ALGUM REGISTRO ENCONTRADO OCORRE UMA ATUALIZAÇÃO DA PONTUAÇÃO FINAL ANTES DE REMOVER MAIS PONTOS
                    {
                        pontuacao_final_antes_rmv_pontos = pontos_acumulados - pontos_antes_remov;
                        lbl_exp_pontos_acumulados.Text = Convert.ToString(pontuacao_final_antes_rmv_pontos);
                        btn_RmvPnts.Enabled = true;
                    }

                    else if (pontos_antes_remov == 0) //SE NÃO SE, SIMPLESMENTE SE PEGA AS INFORMAÇÕES DA PRIMEIRA PESQUISA
                    {
                        DataBase.obterConexao();
                        string sclt4 = "SELECT SUM(PONTOS_FIDELIDADE) AS TOTAL FROM TB_BONUS_FIDELIDADE WHERE COD_ANIMAL = '" + COD_ANIMAL + "'";
                        SqlCommand cmd5 = new SqlCommand(sclt4, DataBase.obterConexao());
                        SqlDataReader dr5 = cmd5.ExecuteReader();

                        try
                        {
                            if (dr5.Read())
                            {
                                lbl_exp_pontos_acumulados.Text = dr5["TOTAL"].ToString();
                                pontuacao_final_antes_rmv_pontos = Convert.ToDouble(lbl_exp_pontos_acumulados.Text);
                                btn_RmvPnts.Enabled = true;
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
                }

                else if (pontos_acumulados == 0) //Se não se, não possui pontos de fidelidade o animal do protocolo informado
                {
                    MessageBox.Show("O Animal informado não possui Pontos de Fidelidade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_protocolo_animal.Text = "";
                    lbl_exp_nome_animal.Text = "";
                    lbl_exp_pontos_acumulados.Text = "";
                    txt_protocolo_animal.Focus();
                }
            }
            else
            {
                txt_protocolo_animal.Focus();
                MessageBox.Show("Informe o Protocolo do Animal", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_RmvPnts_Click_1(object sender, EventArgs e)
        {
            Double pontos_agr = Convert.ToDouble(lbl_exp_pontos_acumulados.Text);
            Double pontos_rmv = Convert.ToDouble(txt_pontos_rmv.Text);

            if (pontos_agr >= pontos_rmv)
            {
                if (txt_pontos_rmv.Text != "")
                {
                    try
                    {
                        Double pontos_remov_agr = Convert.ToDouble(txt_pontos_rmv.Text);

                        if (pontos_remov_agr > 0)
                        {
                            string add = "INSERT INTO TB_OPERACAO_PONTOS(COD_ANIMAL, PONTOS_RETIRADOS) VALUES (" + "'" + COD_ANIMAL + "', '" + pontos_remov_agr + "')";
                            SqlCommand cmd5 = new SqlCommand(add, DataBase.obterConexao());
                            try
                            {
                                DataBase.obterConexao();
                                int resultado;
                                resultado = cmd5.ExecuteNonQuery();

                                if (resultado > 0)
                                {
                                    //Mostrando para o usuário os Pontos Removidos
                                    MessageBox.Show("Foram Removidos " + pontos_remov_agr + " Ponto(s) de Fidelidade", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                            //Calculando Pontuação Final
                            Double pontuacao_final = pontuacao_final_antes_rmv_pontos - pontos_remov_agr;

                            //Mostrando para o usuário os Pontos que Restaram
                            MessageBox.Show("Restaram na sua Pontuação " + pontuacao_final + " Ponto(s) de Fidelidade", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Deixando objetos na posição inicial
                            txt_protocolo_animal.Text = "";
                            lbl_exp_nome_animal.Text = "";
                            lbl_exp_pontos_acumulados.Text = "";
                            lbl_pontos_antes_remov.Text = "";
                            txt_pontos_rmv.Text = "";
                            txt_protocolo_animal.Focus();
                            btn_RmvPnts.Enabled = false;
                        }
                        else
                        {
                            //Mostrando para o usuário os Pontos Removidos
                            MessageBox.Show("Não foi Removido nenhum Ponto de Fidelidade", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Deixando objetos na posição inicial
                            txt_protocolo_animal.Text = "";
                            lbl_exp_nome_animal.Text = "";
                            lbl_exp_pontos_acumulados.Text = "";
                            lbl_pontos_antes_remov.Text = "";
                            txt_pontos_rmv.Text = "";
                            txt_protocolo_animal.Focus();
                            btn_RmvPnts.Enabled = false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Informe valores numéricos para os Pontos a Serem Removidos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_pontos_rmv.Text = "";
                        txt_pontos_rmv.Focus();
                    }
                }
                else
                {
                    txt_pontos_rmv.Focus();
                    MessageBox.Show("Informe os Pontos a Serem Removidos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não se pode Remover essa Quantidade de Pontos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Deixando objetos na posição inicial
                txt_protocolo_animal.Text = "";
                lbl_exp_nome_animal.Text = "";
                lbl_exp_pontos_acumulados.Text = "";
                lbl_pontos_antes_remov.Text = "";
                txt_pontos_rmv.Text = "";
                txt_protocolo_animal.Focus();
                btn_RmvPnts.Enabled = false;
            }
        }
    }
}
