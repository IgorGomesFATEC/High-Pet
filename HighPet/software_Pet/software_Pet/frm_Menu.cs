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
    public partial class frm_Menu : MaterialForm
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void pct_cadpet_Click(object sender, EventArgs e)
        {
            frm_Cadastro cad = new frm_Cadastro();
            cad.ShowDialog();
        }

        private void pct_listpet_Click(object sender, EventArgs e)
        {
            frm_ConsultaPets conpet = new frm_ConsultaPets();
            conpet.ShowDialog();
        }

        private void pct_bonfidel_Click(object sender, EventArgs e)
        {
            frm_BonusFidelidade fidel = new frm_BonusFidelidade();
            fidel.ShowDialog();
        }

        private void pct_serv_Click(object sender, EventArgs e)
        {
            frm_Serviços serv = new frm_Serviços();
            serv.ShowDialog();
        }

        private void pct_listserv_Click(object sender, EventArgs e)
        {
            frm_ConsultaServ consrv = new frm_ConsultaServ();
            consrv.ShowDialog();
        }

        private void pcb_log_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja sair da sua Conta ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            string pesq = "SELECT * FROM TB_DADOS_LOG";
            SqlCommand cmd2 = new SqlCommand(pesq, DataBase.obterConexao());
            SqlDataReader DR2;
            try
            {
                DataBase.obterConexao();
                DR2 = cmd2.ExecuteReader();

                if (DR2.Read())
                {
                    lbl_nome.Text = DR2.GetValue(0).ToString();
                    lbl_rg.Text = DR2.GetValue(2).ToString();
                }
                DR2.Close();
                cmd2.Dispose();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Tem certeza que você quer alterar o seu cadastro?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                frm_alterafunc altera = new frm_alterafunc();
                altera.ShowDialog();
            }
        }
    }
}
