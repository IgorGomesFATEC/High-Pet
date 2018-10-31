namespace software_Pet
{
    partial class frm_Serviços
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Serviços));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nome_func = new System.Windows.Forms.Label();
            this.lbl_nome_animal = new System.Windows.Forms.Label();
            this.lbl_data_serv = new System.Windows.Forms.Label();
            this.lbl_descri_serv = new System.Windows.Forms.Label();
            this.lbl_preco_serv = new System.Windows.Forms.Label();
            this.txt_preco_serv = new System.Windows.Forms.TextBox();
            this.cbo_descri_serv = new System.Windows.Forms.ComboBox();
            this.lbl_rg_dono = new System.Windows.Forms.Label();
            this.txt_protocolo_animal = new System.Windows.Forms.TextBox();
            this.txt_data_serv = new System.Windows.Forms.TextBox();
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.lbl_exp_pontos = new System.Windows.Forms.Label();
            this.lbl_rg_func = new System.Windows.Forms.Label();
            this.txt_rg_func = new System.Windows.Forms.TextBox();
            this.lbl_exp_nome_func = new System.Windows.Forms.Label();
            this.lbl_protocolo = new System.Windows.Forms.Label();
            this.lbl_exp_protocolo = new System.Windows.Forms.Label();
            this.lbl_exp_sbrnome_func = new System.Windows.Forms.Label();
            this.lbl_sbrnome_func = new System.Windows.Forms.Label();
            this.lbl_exp_nome_animal = new System.Windows.Forms.Label();
            this.lbl_prot_ocult = new System.Windows.Forms.Label();
            this.btn_gerar_pontos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_cadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(189, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Serviços: ";
            // 
            // lbl_nome_func
            // 
            this.lbl_nome_func.AutoSize = true;
            this.lbl_nome_func.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_func.Location = new System.Drawing.Point(10, 165);
            this.lbl_nome_func.Name = "lbl_nome_func";
            this.lbl_nome_func.Size = new System.Drawing.Size(149, 15);
            this.lbl_nome_func.TabIndex = 0;
            this.lbl_nome_func.Text = "Nome do Funcionario:";
            // 
            // lbl_nome_animal
            // 
            this.lbl_nome_animal.AutoSize = true;
            this.lbl_nome_animal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_animal.Location = new System.Drawing.Point(10, 244);
            this.lbl_nome_animal.Name = "lbl_nome_animal";
            this.lbl_nome_animal.Size = new System.Drawing.Size(121, 15);
            this.lbl_nome_animal.TabIndex = 0;
            this.lbl_nome_animal.Text = "Nome do Animal :";
            // 
            // lbl_data_serv
            // 
            this.lbl_data_serv.AutoSize = true;
            this.lbl_data_serv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_serv.Location = new System.Drawing.Point(8, 280);
            this.lbl_data_serv.Name = "lbl_data_serv";
            this.lbl_data_serv.Size = new System.Drawing.Size(112, 15);
            this.lbl_data_serv.TabIndex = 0;
            this.lbl_data_serv.Text = "Data do Serviço:";
            // 
            // lbl_descri_serv
            // 
            this.lbl_descri_serv.AutoSize = true;
            this.lbl_descri_serv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descri_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descri_serv.Location = new System.Drawing.Point(7, 316);
            this.lbl_descri_serv.Name = "lbl_descri_serv";
            this.lbl_descri_serv.Size = new System.Drawing.Size(146, 15);
            this.lbl_descri_serv.TabIndex = 0;
            this.lbl_descri_serv.Text = "Descrição do Serviço:";
            // 
            // lbl_preco_serv
            // 
            this.lbl_preco_serv.AutoSize = true;
            this.lbl_preco_serv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_preco_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco_serv.Location = new System.Drawing.Point(8, 356);
            this.lbl_preco_serv.Name = "lbl_preco_serv";
            this.lbl_preco_serv.Size = new System.Drawing.Size(119, 15);
            this.lbl_preco_serv.TabIndex = 0;
            this.lbl_preco_serv.Text = "Preço do Serviço:";
            // 
            // txt_preco_serv
            // 
            this.txt_preco_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco_serv.Location = new System.Drawing.Point(133, 353);
            this.txt_preco_serv.Name = "txt_preco_serv";
            this.txt_preco_serv.Size = new System.Drawing.Size(126, 21);
            this.txt_preco_serv.TabIndex = 6;
            this.txt_preco_serv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_descri_serv
            // 
            this.cbo_descri_serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_descri_serv.FormattingEnabled = true;
            this.cbo_descri_serv.Items.AddRange(new object[] {
            "Banho",
            "Hidratacao",
            "Tosa"});
            this.cbo_descri_serv.Location = new System.Drawing.Point(159, 313);
            this.cbo_descri_serv.MaxLength = 30;
            this.cbo_descri_serv.Name = "cbo_descri_serv";
            this.cbo_descri_serv.Size = new System.Drawing.Size(137, 23);
            this.cbo_descri_serv.TabIndex = 5;
            // 
            // lbl_rg_dono
            // 
            this.lbl_rg_dono.AutoSize = true;
            this.lbl_rg_dono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rg_dono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rg_dono.Location = new System.Drawing.Point(10, 205);
            this.lbl_rg_dono.Name = "lbl_rg_dono";
            this.lbl_rg_dono.Size = new System.Drawing.Size(140, 15);
            this.lbl_rg_dono.TabIndex = 0;
            this.lbl_rg_dono.Text = "Protocolo do Animal:";
            // 
            // txt_protocolo_animal
            // 
            this.txt_protocolo_animal.Location = new System.Drawing.Point(156, 204);
            this.txt_protocolo_animal.Name = "txt_protocolo_animal";
            this.txt_protocolo_animal.Size = new System.Drawing.Size(153, 20);
            this.txt_protocolo_animal.TabIndex = 2;
            this.txt_protocolo_animal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_protocolo_animal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_protocolo_animal_KeyPress);
            this.txt_protocolo_animal.Leave += new System.EventHandler(this.txt_protocolo_animal_Leave);
            // 
            // txt_data_serv
            // 
            this.txt_data_serv.Location = new System.Drawing.Point(126, 279);
            this.txt_data_serv.MaxLength = 30;
            this.txt_data_serv.Name = "txt_data_serv";
            this.txt_data_serv.Size = new System.Drawing.Size(132, 20);
            this.txt_data_serv.TabIndex = 4;
            this.txt_data_serv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_data_serv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_data_serv_KeyPress);
            this.txt_data_serv.Leave += new System.EventHandler(this.txt_data_serv_Leave);
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontos.Location = new System.Drawing.Point(265, 356);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(108, 15);
            this.lbl_pontos.TabIndex = 0;
            this.lbl_pontos.Text = "Pontos Ganhos:";
            // 
            // lbl_exp_pontos
            // 
            this.lbl_exp_pontos.BackColor = System.Drawing.Color.White;
            this.lbl_exp_pontos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp_pontos.Location = new System.Drawing.Point(377, 354);
            this.lbl_exp_pontos.Name = "lbl_exp_pontos";
            this.lbl_exp_pontos.Size = new System.Drawing.Size(131, 21);
            this.lbl_exp_pontos.TabIndex = 0;
            this.lbl_exp_pontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_exp_pontos.Visible = false;
            // 
            // lbl_rg_func
            // 
            this.lbl_rg_func.AutoSize = true;
            this.lbl_rg_func.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rg_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rg_func.Location = new System.Drawing.Point(10, 128);
            this.lbl_rg_func.Name = "lbl_rg_func";
            this.lbl_rg_func.Size = new System.Drawing.Size(131, 15);
            this.lbl_rg_func.TabIndex = 11;
            this.lbl_rg_func.Text = "RG do Funcionario:";
            // 
            // txt_rg_func
            // 
            this.txt_rg_func.Enabled = false;
            this.txt_rg_func.Location = new System.Drawing.Point(147, 127);
            this.txt_rg_func.Name = "txt_rg_func";
            this.txt_rg_func.Size = new System.Drawing.Size(139, 20);
            this.txt_rg_func.TabIndex = 1;
            this.txt_rg_func.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_rg_func.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rg_func_KeyPress);
            this.txt_rg_func.Leave += new System.EventHandler(this.txt_rg_func_Leave);
            // 
            // lbl_exp_nome_func
            // 
            this.lbl_exp_nome_func.BackColor = System.Drawing.Color.White;
            this.lbl_exp_nome_func.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_nome_func.Location = new System.Drawing.Point(165, 163);
            this.lbl_exp_nome_func.Name = "lbl_exp_nome_func";
            this.lbl_exp_nome_func.Size = new System.Drawing.Size(121, 21);
            this.lbl_exp_nome_func.TabIndex = 0;
            this.lbl_exp_nome_func.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_protocolo
            // 
            this.lbl_protocolo.AutoSize = true;
            this.lbl_protocolo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_protocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_protocolo.Location = new System.Drawing.Point(302, 316);
            this.lbl_protocolo.Name = "lbl_protocolo";
            this.lbl_protocolo.Size = new System.Drawing.Size(72, 15);
            this.lbl_protocolo.TabIndex = 0;
            this.lbl_protocolo.Text = "Protocolo:";
            // 
            // lbl_exp_protocolo
            // 
            this.lbl_exp_protocolo.BackColor = System.Drawing.Color.White;
            this.lbl_exp_protocolo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_protocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp_protocolo.Location = new System.Drawing.Point(380, 314);
            this.lbl_exp_protocolo.Name = "lbl_exp_protocolo";
            this.lbl_exp_protocolo.Size = new System.Drawing.Size(128, 21);
            this.lbl_exp_protocolo.TabIndex = 0;
            this.lbl_exp_protocolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_exp_protocolo.Visible = false;
            // 
            // lbl_exp_sbrnome_func
            // 
            this.lbl_exp_sbrnome_func.BackColor = System.Drawing.Color.White;
            this.lbl_exp_sbrnome_func.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_sbrnome_func.Location = new System.Drawing.Point(385, 163);
            this.lbl_exp_sbrnome_func.Name = "lbl_exp_sbrnome_func";
            this.lbl_exp_sbrnome_func.Size = new System.Drawing.Size(123, 21);
            this.lbl_exp_sbrnome_func.TabIndex = 0;
            this.lbl_exp_sbrnome_func.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sbrnome_func
            // 
            this.lbl_sbrnome_func.AutoSize = true;
            this.lbl_sbrnome_func.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sbrnome_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sbrnome_func.Location = new System.Drawing.Point(294, 165);
            this.lbl_sbrnome_func.Name = "lbl_sbrnome_func";
            this.lbl_sbrnome_func.Size = new System.Drawing.Size(85, 15);
            this.lbl_sbrnome_func.TabIndex = 0;
            this.lbl_sbrnome_func.Text = "Sobrenome:";
            // 
            // lbl_exp_nome_animal
            // 
            this.lbl_exp_nome_animal.BackColor = System.Drawing.Color.White;
            this.lbl_exp_nome_animal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_nome_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp_nome_animal.Location = new System.Drawing.Point(137, 243);
            this.lbl_exp_nome_animal.Name = "lbl_exp_nome_animal";
            this.lbl_exp_nome_animal.Size = new System.Drawing.Size(149, 20);
            this.lbl_exp_nome_animal.TabIndex = 12;
            this.lbl_exp_nome_animal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_prot_ocult
            // 
            this.lbl_prot_ocult.BackColor = System.Drawing.Color.DarkViolet;
            this.lbl_prot_ocult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_prot_ocult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prot_ocult.Location = new System.Drawing.Point(353, 278);
            this.lbl_prot_ocult.Name = "lbl_prot_ocult";
            this.lbl_prot_ocult.Size = new System.Drawing.Size(155, 20);
            this.lbl_prot_ocult.TabIndex = 0;
            this.lbl_prot_ocult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_prot_ocult.Visible = false;
            // 
            // btn_gerar_pontos
            // 
            this.btn_gerar_pontos.Depth = 0;
            this.btn_gerar_pontos.Location = new System.Drawing.Point(114, 390);
            this.btn_gerar_pontos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_gerar_pontos.Name = "btn_gerar_pontos";
            this.btn_gerar_pontos.Primary = true;
            this.btn_gerar_pontos.Size = new System.Drawing.Size(128, 41);
            this.btn_gerar_pontos.TabIndex = 13;
            this.btn_gerar_pontos.Text = "Gerar Pontos";
            this.btn_gerar_pontos.UseVisualStyleBackColor = true;
            this.btn_gerar_pontos.Click += new System.EventHandler(this.btn_gerar_pontos_Click_1);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Depth = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Location = new System.Drawing.Point(280, 390);
            this.btn_cadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Primary = true;
            this.btn_cadastrar.Size = new System.Drawing.Size(119, 41);
            this.btn_cadastrar.TabIndex = 14;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click_1);
            // 
            // frm_Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 444);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_gerar_pontos);
            this.Controls.Add(this.lbl_prot_ocult);
            this.Controls.Add(this.lbl_exp_nome_animal);
            this.Controls.Add(this.lbl_exp_sbrnome_func);
            this.Controls.Add(this.lbl_sbrnome_func);
            this.Controls.Add(this.lbl_exp_protocolo);
            this.Controls.Add(this.lbl_protocolo);
            this.Controls.Add(this.lbl_exp_nome_func);
            this.Controls.Add(this.txt_rg_func);
            this.Controls.Add(this.lbl_rg_func);
            this.Controls.Add(this.lbl_exp_pontos);
            this.Controls.Add(this.lbl_pontos);
            this.Controls.Add(this.txt_data_serv);
            this.Controls.Add(this.txt_protocolo_animal);
            this.Controls.Add(this.lbl_rg_dono);
            this.Controls.Add(this.cbo_descri_serv);
            this.Controls.Add(this.txt_preco_serv);
            this.Controls.Add(this.lbl_preco_serv);
            this.Controls.Add(this.lbl_descri_serv);
            this.Controls.Add(this.lbl_data_serv);
            this.Controls.Add(this.lbl_nome_animal);
            this.Controls.Add(this.lbl_nome_func);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Serviços";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                      Serviços";
            this.Load += new System.EventHandler(this.frm_Serviços_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nome_func;
        private System.Windows.Forms.Label lbl_nome_animal;
        private System.Windows.Forms.Label lbl_data_serv;
        private System.Windows.Forms.Label lbl_descri_serv;
        private System.Windows.Forms.Label lbl_preco_serv;
        private System.Windows.Forms.TextBox txt_preco_serv;
        private System.Windows.Forms.ComboBox cbo_descri_serv;
        private System.Windows.Forms.Label lbl_rg_dono;
        private System.Windows.Forms.TextBox txt_protocolo_animal;
        private System.Windows.Forms.TextBox txt_data_serv;
        private System.Windows.Forms.Label lbl_pontos;
        private System.Windows.Forms.Label lbl_exp_pontos;
        private System.Windows.Forms.Label lbl_rg_func;
        private System.Windows.Forms.TextBox txt_rg_func;
        private System.Windows.Forms.Label lbl_exp_nome_func;
        private System.Windows.Forms.Label lbl_protocolo;
        private System.Windows.Forms.Label lbl_exp_protocolo;
        private System.Windows.Forms.Label lbl_exp_sbrnome_func;
        private System.Windows.Forms.Label lbl_sbrnome_func;
        private System.Windows.Forms.Label lbl_exp_nome_animal;
        private System.Windows.Forms.Label lbl_prot_ocult;
        private MaterialSkin.Controls.MaterialRaisedButton btn_gerar_pontos;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cadastrar;
    }
}