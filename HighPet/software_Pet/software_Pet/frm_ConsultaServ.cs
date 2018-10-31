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
    public partial class frm_ConsultaServ : MaterialForm
    {
        public frm_ConsultaServ()
        {
            InitializeComponent();
        }

        //CODIGO UTILIZADO PARA IMPEDIR QUE O USUARIO NÃO UTILIZE AS TECLAS DE LETRAS DO TECLADO
        private void txt_pesquisa_prot_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_pesquisa_prot.MaxLength = 6;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO FUNCIONARIO (Objeto txt_pesquisa_rg)
        private void txt_pesquisa_rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_pesquisa_rg.MaxLength = 12;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_pesquisa_rg.TextLength)
                {
                    case 2:
                        txt_pesquisa_rg.Text = txt_pesquisa_rg.Text + ".";
                        txt_pesquisa_rg.SelectionStart = 3;
                        break;
                    case 6:
                        txt_pesquisa_rg.Text = txt_pesquisa_rg.Text + ".";
                        txt_pesquisa_rg.SelectionStart = 8;
                        break;
                    case 10:
                        txt_pesquisa_rg.Text = txt_pesquisa_rg.Text + "-";
                        txt_pesquisa_rg.SelectionStart = 11;
                        break;
                }
            }
        }

        //Evento do formulario utilazado para coletar as informações vindas do banco
        private void frm_ConsultaServ_Load(object sender, EventArgs e)
        {
            String sclt = "SELECT F.NOME, F.SOBRENOME, F.RG, S.DESCRICAO_SERVICO, S.PROTOCOLO_SERVICO, S.PRECO_SERVICO, ASERV.DATA_SERVICO, ";
            sclt += "A.NOME_ANIMAL, A.PROTOCOLO_ANIMAL, A.RACA ";
            sclt += "FROM TB_ANIMAL_SERVICO ASERV, TB_FUNCIONARIO F, TB_SERVICO S, TB_ANIMAL A ";
            sclt += "WHERE F.ID_FUNCIONARIO = ASERV.COD_FUNCIONARIO ";
            sclt += "AND ASERV.COD_SERVICO = S.ID_SERVICO ";
            sclt += "AND ASERV.COD_ANIMAL = A.ID_ANIMAL";

            SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());

            try
            {
                DataBase.obterConexao();
                DataTable Dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Dt);
                dgv_serv.DataSource = Dt;
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

        //Botão utilazado para atualizar as informações vindas do banco
        private void btn_atualizar_Click_1(object sender, EventArgs e)
        {
            //Deixando objetos na posição inicial
            txt_pesquisa_prot.Text = "";
            txt_pesquisa_rg.Text = "";
            txt_pesquisa_prot.Focus();

            //Fazendo atualização na DataGridView
            String sclt = "SELECT F.NOME, F.SOBRENOME, F.RG, S.DESCRICAO_SERVICO, S.PROTOCOLO_SERVICO, S.PRECO_SERVICO, ASERV.DATA_SERVICO, ";
            sclt += "A.NOME_ANIMAL, A.PROTOCOLO_ANIMAL, A.RACA ";
            sclt += "FROM TB_ANIMAL_SERVICO ASERV, TB_FUNCIONARIO F, TB_SERVICO S, TB_ANIMAL A ";
            sclt += "WHERE F.ID_FUNCIONARIO = ASERV.COD_FUNCIONARIO ";
            sclt += "AND ASERV.COD_SERVICO = S.ID_SERVICO ";
            sclt += "AND ASERV.COD_ANIMAL = A.ID_ANIMAL";

            SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());

            try
            {
                DataBase.obterConexao();
                DataTable Dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Dt);
                dgv_serv.DataSource = Dt;
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

        //Botão utilazado para filtrar as informações vindas do banco
        private void btn_filtrar_Click_1(object sender, EventArgs e)
        {
            //Se o objeto txt_pesquisa_prot estiver diferente de branco
            if (txt_pesquisa_prot.Text != "")
            {
                String sclt = "SELECT F.NOME, F.SOBRENOME, F.RG, S.DESCRICAO_SERVICO, S.PROTOCOLO_SERVICO, S.PRECO_SERVICO, ASERV.DATA_SERVICO, ";
                sclt += "A.NOME_ANIMAL, A.PROTOCOLO_ANIMAL, A.RACA ";
                sclt += "FROM TB_ANIMAL_SERVICO ASERV, TB_FUNCIONARIO F, TB_SERVICO S, TB_ANIMAL A ";
                sclt += "WHERE F.ID_FUNCIONARIO = ASERV.COD_FUNCIONARIO ";
                sclt += "AND ASERV.COD_SERVICO = S.ID_SERVICO ";
                sclt += "AND ASERV.COD_ANIMAL = A.ID_ANIMAL ";
                sclt += "AND S.PROTOCOLO_SERVICO = '" + txt_pesquisa_prot.Text + "'";

                SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());

                try
                {
                    DataBase.obterConexao();
                    DataTable Dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(Dt);
                    dgv_serv.DataSource = Dt;
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

            //Se o objeto txt_pesquisa_rg estiver diferente de branco
            if (txt_pesquisa_rg.Text != "")
            {
                String sclt = "SELECT F.NOME, F.SOBRENOME, F.RG, S.DESCRICAO_SERVICO, S.PROTOCOLO_SERVICO, S.PRECO_SERVICO, ASERV.DATA_SERVICO, ";
                sclt += "A.NOME_ANIMAL, A.PROTOCOLO_ANIMAL, A.RACA ";
                sclt += "FROM TB_ANIMAL_SERVICO ASERV, TB_FUNCIONARIO F, TB_SERVICO S, TB_ANIMAL A ";
                sclt += "WHERE F.ID_FUNCIONARIO = ASERV.COD_FUNCIONARIO ";
                sclt += "AND ASERV.COD_SERVICO = S.ID_SERVICO ";
                sclt += "AND ASERV.COD_ANIMAL = A.ID_ANIMAL ";
                sclt += "AND F.RG LIKE '%" + txt_pesquisa_rg.Text + "%'";

                SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());

                try
                {
                    DataBase.obterConexao();
                    DataTable Dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(Dt);
                    dgv_serv.DataSource = Dt;
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

            //Se não, se ambos estiverem diferente de brancos
            else if(txt_pesquisa_prot.Text == "" && txt_pesquisa_rg.Text == "")
            {
                txt_pesquisa_prot.Focus();
                MessageBox.Show("Por favor, digite o RG do Funcionario ou o protocolo do Serviço", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Menu_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
