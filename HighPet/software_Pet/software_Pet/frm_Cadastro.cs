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
    public partial class frm_Cadastro : MaterialForm
    {
        //Variavel utilizada para fazer o cadastro da chave estrangeira (foreign key)
        string cod_dono;

        public frm_Cadastro()
        {
            InitializeComponent();
        }

        private void cbo_esp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_raca.Items.Clear();
            cbo_raca.Text = "";
            if (cbo_esp.Text == "Cachorro")
            {
                //--A
                cbo_raca.Items.Add("Afegão Hound");
                cbo_raca.Items.Add("Afenpinscher");
                cbo_raca.Items.Add("Airedale Terrier");
                cbo_raca.Items.Add("Akita Inu");
                cbo_raca.Items.Add("American Stanffordahire");
                cbo_raca.Items.Add("Akibash Dog");
                cbo_raca.Items.Add("Australian Shepherd");
                cbo_raca.Items.Add("American Pit Bull");
                cbo_raca.Items.Add("Australian Cattle");
                //--B
                cbo_raca.Items.Add("Basenji");
                cbo_raca.Items.Add("Basset Hound");
                cbo_raca.Items.Add("Beagle");
                cbo_raca.Items.Add("Beagle Harrier");
                cbo_raca.Items.Add("Beaschead Collie");
                cbo_raca.Items.Add("Bedlington Terrier");
                cbo_raca.Items.Add("Bloodhound");
                cbo_raca.Items.Add("Bobtail");
                cbo_raca.Items.Add("Boiadeiro Australiano");
                cbo_raca.Items.Add("Boiadeiro Barnês");
                cbo_raca.Items.Add("Border Collie");
                cbo_raca.Items.Add("Border Terrier");
                cbo_raca.Items.Add("Borgoi");
                cbo_raca.Items.Add("Boston Terrier");
                cbo_raca.Items.Add("Boxer");
                cbo_raca.Items.Add("Bulldog Françês");
                cbo_raca.Items.Add("Bulldog Ingles");
                cbo_raca.Items.Add("Bull Terrier");
                cbo_raca.Items.Add("Bullmastife");
                cbo_raca.Items.Add("Bulldog Campeiro");
                cbo_raca.Items.Add("Briard");
                cbo_raca.Items.Add("Braco Italiano");
                cbo_raca.Items.Add("Braco Alemão");
                cbo_raca.Items.Add("Bouver de Flancher");
                cbo_raca.Items.Add("Bornese Mountain Dog");
                cbo_raca.Items.Add("Basset Griffon");
                cbo_raca.Items.Add("Basset Fulvo");
                cbo_raca.Items.Add("Barbet");
                //--C
                cbo_raca.Items.Add("Cairn Terrier");
                cbo_raca.Items.Add("Cane Corso");
                cbo_raca.Items.Add("Cão de Água Português");
                cbo_raca.Items.Add("Cão de Crista Chinês");
                cbo_raca.Items.Add("Cavalier King");
                cbo_raca.Items.Add("Chesapeake B. Retriver");
                cbo_raca.Items.Add("Chihuahua");
                cbo_raca.Items.Add("Chow Chow");
                cbo_raca.Items.Add("Coker Spaniel(Americano)");
                cbo_raca.Items.Add("Coker Spaniel(Inglês)");
                cbo_raca.Items.Add("Collie");
                cbo_raca.Items.Add("Coton Tuléar");
                cbo_raca.Items.Add("Cão da Serra");
                cbo_raca.Items.Add("Cão Fila de São Miguel");
                cbo_raca.Items.Add("Columber Spaniel");
                cbo_raca.Items.Add("Cimmarón Ururgayio");
                cbo_raca.Items.Add("Cuvac");
                //--D
                cbo_raca.Items.Add("Dachshund");
                cbo_raca.Items.Add("Dálmata");
                cbo_raca.Items.Add("Dandie Dinmont Terrier");
                cbo_raca.Items.Add("Doberman");
                cbo_raca.Items.Add("Dogo Argentino");
                cbo_raca.Items.Add("Dogue Alemão");
                cbo_raca.Items.Add("Dogue de Bordeaux");
                //--F
                cbo_raca.Items.Add("Fila Brasileiro");
                cbo_raca.Items.Add("Fox Terrier");
                cbo_raca.Items.Add("Fox Hound Inglês");
                cbo_raca.Items.Add("Flat Coated Retriver");
                //--G
                cbo_raca.Items.Add("GalGo Escocês");
                cbo_raca.Items.Add("Galgo Irlandês");
                cbo_raca.Items.Add("Golden Retriver");
                cbo_raca.Items.Add("Grande Boiadeiro Suiço");
                cbo_raca.Items.Add("Greyhound");
                cbo_raca.Items.Add("Grifo da Bélgica");
                //--H
                cbo_raca.Items.Add("Husky Siberiano");
                //--I
                cbo_raca.Items.Add("Irish Setter");
                cbo_raca.Items.Add("Irish Wolfhound");
                //--J
                cbo_raca.Items.Add("Jack Russell Terrier");
                //--K
                cbo_raca.Items.Add("King Charles");
                cbo_raca.Items.Add("Komondor");
                cbo_raca.Items.Add("Keeshound");
                cbo_raca.Items.Add("Kurahoar");
                cbo_raca.Items.Add("Kerry Blue Terrier");
                cbo_raca.Items.Add("Kuvase");
                //--L
                cbo_raca.Items.Add("Labradoodle");
                cbo_raca.Items.Add("Labrador Retriever");
                cbo_raca.Items.Add("Lakeland Terrier");
                cbo_raca.Items.Add("Lhasa Apso");
                cbo_raca.Items.Add("Leanberger");
                cbo_raca.Items.Add("Lulu da Pomerânia");
                //--M
                cbo_raca.Items.Add("Malamute do Alasca");
                cbo_raca.Items.Add("Maltês");
                cbo_raca.Items.Add("Mastife Inglês");
                cbo_raca.Items.Add("Mastife Espanhol");
                cbo_raca.Items.Add("Mastim Napolitano");
                cbo_raca.Items.Add("Mastim Tibetano");
                cbo_raca.Items.Add("Maremmano");
                //--N
                cbo_raca.Items.Add("Norfolk Terrier");
                cbo_raca.Items.Add("Norwich Terrier");
                cbo_raca.Items.Add("Nova Scotia");
                //--O
                cbo_raca.Items.Add("Old English Sheepdog");
                cbo_raca.Items.Add("Otterhound");
                //--P
                cbo_raca.Items.Add("Papillan");
                cbo_raca.Items.Add("Pastor Alemão");
                cbo_raca.Items.Add("Pastor Australiano");
                cbo_raca.Items.Add("Pinscher Miniatura");
                cbo_raca.Items.Add("Podergo Português");
                cbo_raca.Items.Add("Poiter Inglês");
                cbo_raca.Items.Add("Puli");
                cbo_raca.Items.Add("Pumi");
                //--R
                cbo_raca.Items.Add("Rottweiler");
                cbo_raca.Items.Add("Rhodesian Ridgehack");
                //--S
                cbo_raca.Items.Add("Sem Raça Definida(S.R.D)");
                cbo_raca.Items.Add("Shih Tzu");
                cbo_raca.Items.Add("Silky Terrier");
                cbo_raca.Items.Add("Skye Terrier");
                cbo_raca.Items.Add("Staffordshire Bull Terrier");
                cbo_raca.Items.Add("Saluki");
                cbo_raca.Items.Add("Saimoieda");
                cbo_raca.Items.Add("São Benardo");
                cbo_raca.Items.Add("Schipperke");
                cbo_raca.Items.Add("Schnauzer");
                cbo_raca.Items.Add("Shar Pei");
                cbo_raca.Items.Add("Spaniel");
                cbo_raca.Items.Add("Spitz Alemão");
                cbo_raca.Items.Add("Scottish Terrier");
                cbo_raca.Items.Add("Setter Gordon");
                cbo_raca.Items.Add("Setter Inglês");
                cbo_raca.Items.Add("Setter Irlandês");
                cbo_raca.Items.Add("Spitz Japonês");
                cbo_raca.Items.Add("Springer Spaniel");
                cbo_raca.Items.Add("Springer Inglês");
                //--T
                cbo_raca.Items.Add("Terra Nova");
                cbo_raca.Items.Add("Terrier Escocês");
                cbo_raca.Items.Add("Terrier Tibetano");
                cbo_raca.Items.Add("Terrier Brasileiro");
                cbo_raca.Items.Add("Tosa Inu");
                cbo_raca.Items.Add("Vizsla");
                cbo_raca.Items.Add("Weimaranr");
                cbo_raca.Items.Add("Welsh Corgi (Cardigan)");
                cbo_raca.Items.Add("Welsh Corgi (Pembroke)");
                cbo_raca.Items.Add("West Highland White Terrier");
                cbo_raca.Items.Add("Whippet");
                cbo_raca.Items.Add("Walfhound Irlandês");
                cbo_raca.Items.Add("Xoloitzcuintli");
                cbo_raca.Items.Add("Yorkshire Terrier");
            }
            if (cbo_esp.Text == "Gato")
            {
                cbo_raca.Items.Add("Abissínio");
                cbo_raca.Items.Add("American Shorthair");
                cbo_raca.Items.Add("Angorá");
                cbo_raca.Items.Add("Azul Russo");
                cbo_raca.Items.Add("Bengal");
                cbo_raca.Items.Add("Brazilian Shorthair");
                cbo_raca.Items.Add("British Shorthair");
                cbo_raca.Items.Add("Burmese");
                cbo_raca.Items.Add("Chartreux");
                cbo_raca.Items.Add("Cornish Rex");
                cbo_raca.Items.Add("Devon Rex");
                cbo_raca.Items.Add("Egyptian Mau");
                cbo_raca.Items.Add("European Shorthair");
                cbo_raca.Items.Add("Exótico");
                cbo_raca.Items.Add("Himalaio");
                cbo_raca.Items.Add("Maine Coon");
                cbo_raca.Items.Add("Munchkin");
                cbo_raca.Items.Add("Norwegian Forest");
                cbo_raca.Items.Add("Oriental");
                cbo_raca.Items.Add("Persa");
                cbo_raca.Items.Add("Ragdoll");
                cbo_raca.Items.Add("Sagrado da Birmania");
                cbo_raca.Items.Add("Savannah");
                cbo_raca.Items.Add("Scottish Fold");
                cbo_raca.Items.Add("Siamês");
                cbo_raca.Items.Add("Sphynx");
            }
        }

        void limpar()
        {
            //Deixando o objeto lbl_protocolo visivel
            lbl_protocolo.Visible = true;

            //Limppando objetos da utilizados para pesquisar
            txt_rgDono.Text = "";
            txt_protocolo.Text = "";

            //Limpando Dados do Dono
            txt_nome_dono.Text = "";
            txt_sobrenome.Text = "";
            txt_bairro.Text = "";
            txt_rua.Text = "";
            txt_num.Text = "";
            txt_complemento.Text = "";
            txt_rg.Text = "";
            txt_telefone.Text = "";

            //Limpando Dados do Animal
            txt_animal.Text = "";
            lbl_exp_protocolo.Text = "";
            lbl_exp_protocolo.Visible = false;
            cbo_esp.Text = "";
            cbo_raca.Text = "";
            txt_data_nascimento.Text = "";
            cbo_vacinado.Text = "";
            cbo_castrado.Text = "";
            cbo_port.Text = "";

            //Voltando ao faco inicial
            txt_nome_dono.Focus();

            //Botões novamente do jeito inicial
            btn_cadastrar.Visible = true;
            btn_cna.Visible = false;
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
        }

        //Quando formulario é iniciado é selecionado o ultimo protocolo que foi adicionado no banco
        private void frm_Cadastro_Load(object sender, EventArgs e)
        {            
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
                    MessageBox.Show("Erro");
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

        //EVENTO QUE VAI GERAR O PROTOCOLO DO ANIMAL E EXPOR NO OBJETO lbl_exp_protocolo
        private void txt_animal_Leave(object sender, EventArgs e)
        {
            if (txt_protocolo.Text == "")
            {
                if (txt_animal.Text != "")
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
                    txt_animal.Focus();
                    MessageBox.Show("Informe o Nome do Animal", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lbl_exp_protocolo.Visible = false;
            }
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO DONO (Objeto txt_rgDono)
        private void txt_rgDono_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_rgDono.MaxLength = 12;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_rgDono.TextLength)
                {
                    case 2:
                        txt_rgDono.Text = txt_rgDono.Text + ".";
                        txt_rgDono.SelectionStart = 3;
                        break;
                    case 6:
                        txt_rgDono.Text = txt_rgDono.Text + ".";
                        txt_rgDono.SelectionStart = 8;
                        break;
                    case 10:
                        txt_rgDono.Text = txt_rgDono.Text + "-";
                        txt_rgDono.SelectionStart = 11;
                        break;
                }
            }
        }

        private void txt_nome_dono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar ))
            {
                e.Handled = true;
            }          
        }

        private void txt_sobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //CODIGO UTILIZADO PARA ADICIONAR PONTOS E TRAÇOS AUTOMATICAMENTE NO RG DO DONO (Objeto txt_rg)
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

        //CODIGO UTILIZADO PARA IMPEDIR QUE O USUARIO NÃO UTILIZE AS TECLAS DE LETRAS DO TECLADO
        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_num.MaxLength = 4;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //CODIGO UTILIZADO PARA ADICINAR PARENTESES E TRAÇOS AUTOMATICAMENTE NO TELEFONE DO DONO (Objeto txt_telefone)
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

        //CODIGO UTILIZADO PARA IMPEDIR QUE O USUARIO NÃO UTILIZE AS TECLAS DE LETRAS DO TECLADO
        private void txt_protocolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_protocolo.MaxLength = 6;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_animal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //CODIGO UTILIZADO PARA COLOCAR BARRAS NAS DATAS DE NASCIMENTO DOS ANIMAIS
        private void txt_data_nascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_data_nascimento.MaxLength = 10;
            if ((Char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txt_data_nascimento.TextLength)
                {
                    case 2:
                        txt_data_nascimento.Text = txt_data_nascimento.Text + "/";
                        txt_data_nascimento.SelectionStart = 3;
                        break;
                    case 5:
                        txt_data_nascimento.Text = txt_data_nascimento.Text + "/";
                        txt_data_nascimento.SelectionStart = 6;
                        break;
                }
            }
        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
             //PESQUISA DO DONO PELO SEU RG
            if (txt_rgDono.Text != "")
            {
                //Pesquisando Dono
                string pesquisa = "SELECT * FROM TB_DONO WHERE RG = '" + txt_rgDono.Text + "'";
                SqlCommand cmd = new SqlCommand(pesquisa, DataBase.obterConexao());
                SqlDataReader DR;

                try
                {
                    DataBase.obterConexao();
                    DR = cmd.ExecuteReader();

                    if (DR.Read())
                    {
                        //Campos do Dono
                        txt_nome_dono.Text = DR.GetValue(1).ToString();
                        txt_sobrenome.Text = DR.GetValue(2).ToString();
                        txt_bairro.Text = DR.GetValue(3).ToString();
                        txt_rua.Text = DR.GetValue(4).ToString();
                        txt_num.Text = DR.GetValue(5).ToString();
                        txt_complemento.Text = DR.GetValue(6).ToString();
                        txt_rg.Text = DR.GetValue(7).ToString();
                        txt_telefone.Text = DR.GetValue(8).ToString();

                        //Exibições dos botões
                        btn_cadastrar.Visible = false;
                        btn_cna.Visible = true;
                        btn_alterar.Enabled = true;
                        btn_excluir.Enabled = true;

                        //Limpando Dados do Animal caso tem ocorrido alguma pesquisa anteriormente pelo protocolo
                        txt_animal.Text = "";
                        lbl_exp_protocolo.Text = "";
                        lbl_exp_protocolo.Visible = false;
                        cbo_esp.Text = "";
                        cbo_raca.Text = "";
                        txt_data_nascimento.Text = "";
                        cbo_vacinado.Text = "";
                        cbo_castrado.Text = "";
                        cbo_port.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Registros do Dono não encontrados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Limpando o objeto da pesquisa (txt_rgDono)
                        txt_rgDono.Text = "";

                        //Voltanco ao foco incial (Objeto txt_nome_dono)
                        txt_nome_dono.Focus();
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

            //PESQUISA DO ANIMAL PELO SEU PROTOCOLO
            if (txt_protocolo.Text != "")
            {
                //Pesquisando Animal
                string pesquisa = "SELECT * FROM TB_ANIMAL WHERE PROTOCOLO_ANIMAL = '" + txt_protocolo.Text + "'";
                SqlCommand cmd2 = new SqlCommand(pesquisa, DataBase.obterConexao());
                SqlDataReader DR2;

                try
                {
                    DataBase.obterConexao();
                    DR2 = cmd2.ExecuteReader();

                    if (DR2.Read())
                    {
                        //Campos do Animal
                        txt_animal.Text = DR2["NOME_ANIMAL"].ToString();
                        lbl_protocolo.Visible = false;
                        cbo_esp.Text = DR2["ESPECIE"].ToString();
                        cbo_raca.Text = DR2["RACA"].ToString();
                        cbo_vacinado.Text = DR2["VACINADO"].ToString();
                        cbo_castrado.Text = DR2["CASTRADO"].ToString();
                        txt_data_nascimento.Text = DR2["DATA_NASCIMENTO"].ToString();
                        cbo_port.Text = DR2["PORTE"].ToString();

                        //Exibições dos botões
                        btn_cadastrar.Visible = false;
                        btn_cna.Visible = false;
                        btn_alterar.Enabled = true;
                        btn_excluir.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Registros do Animal não encontrados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Limpando o objeto da pesquisa (txt_protocolo)
                        txt_protocolo.Text = "";

                        //Voltanco ao foco incial (Objeto txt_nome_dono)
                        txt_nome_dono.Focus();
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

            else if (txt_rgDono.Text == "" && txt_protocolo.Text =="")
            {
                txt_rgDono.Focus();
                MessageBox.Show("Por favor, informe o RG do Dono ou o Protocolo do Animal", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cna_Click_1(object sender, EventArgs e)
        {
            if (txt_animal.Text != "" && lbl_exp_protocolo.Text != "" && cbo_esp.Text != "" && cbo_raca.Text != "" && cbo_vacinado.Text != "" && cbo_castrado.Text != "" && txt_data_nascimento.Text != "" && cbo_port.Text != "")
            {
                //Processo (codigos) necessarios para se salvar uma chave estrangeira (foreign key) em uma tabela
                string slct = "SELECT ID_DONO FROM TB_DONO WHERE RG='" + txt_rg.Text + "'";
                DataBase.obterConexao();
                SqlCommand cmd2 = new SqlCommand(slct, DataBase.obterConexao());
                SqlDataReader dr = cmd2.ExecuteReader();

                if (dr.Read())
                {
                    cod_dono = dr["ID_DONO"].ToString();
                }
                DataBase.fecharConexao();

                //Covertendo o Protocolo
                int protocolo = Convert.ToInt32(lbl_exp_protocolo.Text);

                //Inserindo dados na tabela animal inclusive a chave estrangeira (foreign key) e o Protocolo
                string add = "INSERT INTO TB_ANIMAL(COD_DONO, NOME_ANIMAL, PROTOCOLO_ANIMAL, ESPECIE, RACA, VACINADO, CASTRADO, DATA_NASCIMENTO, PORTE) VALUES(" + "'" + cod_dono + "', '" + txt_animal.Text + "', '" + protocolo + "', '" + cbo_esp.Text + "', '" + cbo_raca.Text + "', '" + cbo_vacinado.Text + "', '" + cbo_castrado.Text + "', '" + txt_data_nascimento.Text + "', '" + cbo_port.Text + "')";
                SqlCommand cmd = new SqlCommand(add, DataBase.obterConexao());
                try
                {
                    DataBase.obterConexao();
                    int resultado;
                    resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        //Mensagem de confirmação para o usuário
                        MessageBox.Show("Registro do Novo Animal adicionado com SUCESSO", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpando o objeto utilizado para pesquisar o Dono
                        txt_rgDono.Text = "";

                        //Executando a void limpar()
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
            else
            {
                MessageBox.Show("Por favor, se quiser cadastrar um Novo Animal preencha todos os campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Limpando Dados do Animal
                txt_animal.Text = "";
                lbl_exp_protocolo.Text = "";
                lbl_exp_protocolo.Visible = false;
                cbo_esp.Text = "";
                cbo_raca.Text = "";
                txt_data_nascimento.Text = "";
                cbo_vacinado.Text = "";
                cbo_castrado.Text = "";
                cbo_port.Text = "";

                //Voltando o foco ao objeto de Nome do Animal (txt_animal)
                txt_animal.Focus();
            }
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            //CADASTRO DO DONO
            if (txt_nome_dono.Text != "" && txt_sobrenome.Text != "" && txt_bairro.Text != "" && txt_rua.Text != "" && txt_num.Text != "" && txt_rg.Text != "")
            {
                string add = "INSERT INTO TB_DONO(NOME, SOBRENOME, BAIRRO, RUA, NUMERO, COMPLEMENTO, RG, TELEFONE) VALUES(" + "'" + txt_nome_dono.Text + "', '" + txt_sobrenome.Text + "', '" + txt_bairro.Text + "', '" + txt_rua.Text + "', '" + txt_num.Text + "', '" + txt_complemento.Text + "', '" + txt_rg.Text + "', '" + txt_telefone.Text + "')";
                SqlCommand cmd = new SqlCommand(add, DataBase.obterConexao());
                try
                {
                    DataBase.obterConexao();
                    int resultado;
                    resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        //Mensagem de confirmação para o usuário
                        MessageBox.Show("Registro do Dono adicionado com SUCESSO", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, se quiser cadastrar um Dono preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Limpando os Dados do Dono
                txt_rgDono.Text = "";
                txt_nome_dono.Text = "";
                txt_sobrenome.Text = "";
                txt_bairro.Text = "";
                txt_rua.Text = "";
                txt_num.Text = "";
                txt_complemento.Text = "";
                txt_telefone.Text = "";
                txt_rg.Text = "";

                //Voltanco ao foco incial (Objeto txt_nome_dono)
                txt_nome_dono.Focus();
            }

            //PARA SE CADASTRAR UM ANIMAL PRECISA-SE PRIMEIRO CADASTRAR UM DONO
            if (txt_nome_dono.Text != "" && txt_sobrenome.Text != "" && txt_bairro.Text != "" && txt_rua.Text != "" && txt_num.Text != "" && txt_rg.Text != "")
            {
                //CADASTRO DO ANIMAL
                if (txt_animal.Text != "" && lbl_exp_protocolo.Visible == true && lbl_exp_protocolo.Text != "" && cbo_esp.Text != "" && cbo_raca.Text != "" && cbo_vacinado.Text != "" && cbo_castrado.Text != "" && cbo_port.Text != "")
                {
                    //Processo (codigos) necessarios para se salvar uma chave estrangeira (foreign key) em uma tabela
                    string slct = "SELECT ID_DONO FROM TB_DONO WHERE RG='" + txt_rg.Text + "'";
                    DataBase.obterConexao();
                    SqlCommand cmd2 = new SqlCommand(slct, DataBase.obterConexao());
                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        cod_dono = dr["ID_DONO"].ToString();
                    }
                    DataBase.fecharConexao();

                    //Covertendo o Protocolo do Animal
                    int protocolo_animal = Convert.ToInt32(lbl_exp_protocolo.Text);

                    //Inserindo dados na tabela animal inclusive a chave estrangeira (foreign key) e o Protocolo
                    string add = "INSERT INTO TB_ANIMAL(COD_DONO, NOME_ANIMAL, PROTOCOLO_ANIMAL, ESPECIE, RACA, VACINADO, CASTRADO, DATA_NASCIMENTO, PORTE) VALUES(" + "'" + cod_dono + "', '" + txt_animal.Text + "', '" + protocolo_animal + "', '" + cbo_esp.Text + "', '" + cbo_raca.Text + "', '" + cbo_vacinado.Text + "', '" + cbo_castrado.Text + "', '" + txt_data_nascimento.Text + "', '" + cbo_port.Text + "')";
                    SqlCommand cmd = new SqlCommand(add, DataBase.obterConexao());
                    try
                    {
                        DataBase.obterConexao();
                        int resultado;
                        resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            //Mensagem de confirmação para o usuário
                            MessageBox.Show("Registro do Animal adicionado com SUCESSO", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Executando a void limpar()
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
                else
                {
                    MessageBox.Show("Por favor, se quiser cadastrar um Animal preencha todos os campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Limpando Dados do Animal
                    txt_animal.Text = "";
                    lbl_exp_protocolo.Text = "";
                    lbl_exp_protocolo.Visible = false;
                    cbo_esp.Text = "";
                    cbo_raca.Text = "";
                    txt_data_nascimento.Text = "";
                    cbo_vacinado.Text = "";
                    cbo_castrado.Text = "";
                    cbo_port.Text = "";

                    //Voltando o foco ao objeto de Nome do Animal (txt_animal)
                    txt_animal.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor, para se cadastrar um Animal precisa-se primeiro cadastrar o seu Dono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Limpando Dados do Animal
                txt_animal.Text = "";
                lbl_exp_protocolo.Text = "";
                lbl_exp_protocolo.Visible = false;
                cbo_esp.Text = "";
                cbo_raca.Text = "";
                txt_data_nascimento.Text = "";
                cbo_vacinado.Text = "";
                cbo_castrado.Text = "";
                cbo_port.Text = "";

                //Voltanco ao foco incial (Objeto txt_nome_dono)
                txt_nome_dono.Focus();
            }
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            //Excluindo um Animal
            if (txt_protocolo.Text != "")
            {
                string remove2 = "DELETE FROM TB_ANIMAL WHERE PROTOCOLO_ANIMAL= '" + txt_protocolo.Text + "'";
                SqlCommand cmd2 = new SqlCommand(remove2, DataBase.obterConexao());

                try
                {
                    DataBase.obterConexao();
                    int resultado;

                    if (MessageBox.Show("Tem certeza que deseja remover este registro ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        resultado = cmd2.ExecuteNonQuery();

                        if (resultado >= 1)
                        {
                            //Mensagem de confirmação para o usuário
                            MessageBox.Show("Dados do Animal Excluidos com Sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Limpando o objeto utilizado para pesquisar o Animal (txt_protocolo)
                            txt_protocolo.Text = "";

                            //Deixando o objeto lbl_protocolo visivel
                            lbl_protocolo.Visible = true;

                            //Limpando Dados do Animal
                            txt_animal.Text = "";
                            lbl_exp_protocolo.Text = "";
                            lbl_exp_protocolo.Visible = false;
                            cbo_esp.Text = "";
                            cbo_raca.Text = "";
                            txt_data_nascimento.Text = "";
                            cbo_vacinado.Text = "";
                            cbo_castrado.Text = "";
                            cbo_port.Text = "";

                            //Voltanco ao foco incial (Objeto txt_nome_dono)
                            txt_nome_dono.Focus();

                            //Botões novamente do jeito inicial
                            btn_cadastrar.Visible = true;
                            btn_alterar.Enabled = false;
                            btn_excluir.Enabled = false;
                        }
                        cmd2.Dispose();
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

            //Excluindo um Dono
            if (txt_rgDono.Text != "")
            {
                string remove = "DELETE FROM TB_DONO WHERE RG= '" + txt_rgDono.Text + "'";
                SqlCommand cmd = new SqlCommand(remove, DataBase.obterConexao());

                try
                {
                    DataBase.obterConexao();
                    int resultado;

                    if (MessageBox.Show("Tem certeza que deseja remover este registro ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        resultado = cmd.ExecuteNonQuery();

                        if (resultado >= 1)
                        {
                            //Mensagem de confirmação para o usuário
                            MessageBox.Show("Dados do Dono Excluidos com Sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Limpando o objeto utilizado para pesquisar o Dono (txt_rgDono)
                            txt_rgDono.Text = "";

                            //Limpando os Dados do Dono
                            txt_nome_dono.Text = "";
                            txt_sobrenome.Text = "";
                            txt_bairro.Text = "";
                            txt_rua.Text = "";
                            txt_num.Text = "";
                            txt_complemento.Text = "";
                            txt_telefone.Text = "";
                            txt_rg.Text = "";

                            //Voltanco ao foco incial (Objeto txt_nome_dono)
                            txt_nome_dono.Focus();

                            //Botões novamente do jeito inicial
                            btn_cadastrar.Visible = true;
                            btn_cna.Visible = false;
                            btn_alterar.Enabled = false;
                            btn_excluir.Enabled = false;
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
        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            //Alterando Dados do Dono
            if (txt_rgDono.Text != "" && txt_nome_dono.Text != "" && txt_sobrenome.Text != "" && txt_bairro.Text != "" && txt_rua.Text != "" && txt_num.Text != "" && txt_rg.Text != "")
            {
                string altera1 = "UPDATE TB_DONO SET NOME= '" + txt_nome_dono.Text + "', SOBRENOME= '" + txt_sobrenome.Text + "', BAIRRO= '" + txt_bairro.Text + "', RUA= '" + txt_rua.Text + "', NUMERO= '" + txt_num.Text + "', COMPLEMENTO= '" + txt_complemento.Text + "', TELEFONE= '" + txt_telefone.Text + "' WHERE RG= '" + txt_rgDono.Text + "'";
                SqlCommand cmd = new SqlCommand(altera1, DataBase.obterConexao());
                try
                {
                    DataBase.obterConexao();
                    int resultado;
                    resultado = cmd.ExecuteNonQuery();

                    if (resultado >= 1)
                    {
                        //Mensagem de confirmação para o usuário
                        MessageBox.Show("Dados do Dono Alterados com Sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpando o objeto utilizado para pesquisar o Dono (txt_rgDono)
                        txt_rgDono.Text = "";

                        //Limpando os Dados do Dono
                        txt_nome_dono.Text = "";
                        txt_sobrenome.Text = "";
                        txt_bairro.Text = "";
                        txt_rua.Text = "";
                        txt_num.Text = "";
                        txt_complemento.Text = "";
                        txt_telefone.Text = "";
                        txt_rg.Text = "";

                        //Voltanco ao foco incial (Objeto txt_nome_dono)
                        txt_nome_dono.Focus();

                        //Botões novamente do jeito inicial
                        btn_cadastrar.Visible = true;
                        btn_cna.Visible = false;
                        btn_alterar.Enabled = false;
                        btn_excluir.Enabled = false;
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

            //Alterando Dados do Animal
            if (txt_protocolo.Text != "" && txt_animal.Text != "" && cbo_esp.Text != "" && cbo_raca.Text != "" && txt_data_nascimento.Text != "" && cbo_vacinado.Text != "" && cbo_castrado.Text != "" && cbo_port.Text != "")
            {
                string altera2 = "UPDATE TB_ANIMAL SET NOME_ANIMAL= '" + txt_animal.Text + "', ESPECIE= '" + cbo_esp.Text + "', RACA= '" + cbo_raca.Text + "', VACINADO= '" + cbo_vacinado.Text + "', CASTRADO= '" + cbo_castrado.Text + "', DATA_NASCIMENTO= '" + txt_data_nascimento.Text + "', PORTE= '" + cbo_port.Text + "' WHERE PROTOCOLO_ANIMAL= '" + txt_protocolo.Text + "'";
                SqlCommand cmd2 = new SqlCommand(altera2, DataBase.obterConexao());
                try
                {
                    DataBase.obterConexao();
                    int resultado;
                    resultado = cmd2.ExecuteNonQuery();

                    if (resultado >= 1)
                    {
                        //Mensagem de confirmação para o usuário
                        MessageBox.Show("Dados do Animal Alterados com Sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpando o objeto utilizado para pesquisar o Animal (txt_protocolo)
                        txt_protocolo.Text = "";

                        //Deixando o objeto lbl_protocolo visivel
                        lbl_protocolo.Visible = true;

                        //Limpando Dados do Animal
                        txt_animal.Text = "";
                        lbl_exp_protocolo.Text = "";
                        lbl_exp_protocolo.Visible = false;
                        cbo_esp.Text = "";
                        cbo_raca.Text = "";
                        txt_data_nascimento.Text = "";
                        cbo_vacinado.Text = "";
                        cbo_castrado.Text = "";
                        cbo_port.Text = "";

                        //Voltanco ao foco incial (Objeto txt_nome_dono)
                        txt_nome_dono.Focus();

                        //Botões novamente do jeito inicial
                        btn_cadastrar.Visible = true;
                        btn_alterar.Enabled = false;
                        btn_excluir.Enabled = false;
                    }
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
        }

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_Menu_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}


