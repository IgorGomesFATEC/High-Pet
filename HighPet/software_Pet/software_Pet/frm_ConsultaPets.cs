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
    public partial class frm_ConsultaPets : MaterialForm
    {
        public frm_ConsultaPets()
        {
            InitializeComponent();
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO DONO (Objeto txt_pesquisa)
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

        //Evento do formulario utilazado para coletar as informações vindas do banco
        private void frm_consultaPets_Load(object sender, EventArgs e)
        {
            string sclt = "SELECT D.NOME, D.RG, D.TELEFONE, A.NOME_ANIMAL, A.RACA, A.PROTOCOLO_ANIMAL FROM TB_DONO D, TB_ANIMAL A WHERE D.ID_DONO = A.COD_DONO ";
            SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());
            try
            {
                DataBase.obterConexao();
                DataTable Dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Dt);
                dgv_ConsultaPets.DataSource = Dt;
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
            txt_pesquisa.Text = "";
            txt_pesquisa.Focus();

            //Fazendo atualização na DataGridView
            string sclt = "SELECT D.NOME, D.RG, D.TELEFONE, A.NOME_ANIMAL, A.RACA, A.PROTOCOLO_ANIMAL FROM TB_DONO D, TB_ANIMAL A WHERE D.ID_DONO = A.COD_DONO ";
            SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());
            try
            {
                DataBase.obterConexao();
                DataTable Dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Dt);
                dgv_ConsultaPets.DataSource = Dt;
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
            if (txt_pesquisa.Text != "")
            {
                string sclt = "SELECT D.NOME, D.RG, D.TELEFONE, A.NOME_ANIMAL, A.RACA, A.PROTOCOLO_ANIMAL FROM TB_DONO D, TB_ANIMAL A WHERE D.ID_DONO = A.COD_DONO AND D.RG LIKE '%" + txt_pesquisa.Text + "%'";
                SqlCommand cmd = new SqlCommand(sclt, DataBase.obterConexao());
                try
                {
                    DataBase.obterConexao();
                    DataTable Dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(Dt);
                    dgv_ConsultaPets.DataSource = Dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txt_pesquisa.Text = "";
                }
                finally
                {
                    DataBase.fecharConexao();
                }
            }
            else
            {
                txt_pesquisa.Focus();
                MessageBox.Show("digite o RG do Dono e pressione Filtrar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_menu_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
