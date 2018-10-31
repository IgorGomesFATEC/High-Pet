namespace software_Pet
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_cad = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_entrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_sair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nome_log = new System.Windows.Forms.Label();
            this.lbl_sbre = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(135, 155);
            this.txt_senha.MaxLength = 20;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(201, 26);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(135, 111);
            this.txt_login.MaxLength = 20;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(201, 26);
            this.txt_login.TabIndex = 0;
            this.txt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_cad
            // 
            this.lbl_cad.AutoSize = true;
            this.lbl_cad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cad.ForeColor = System.Drawing.Color.Blue;
            this.lbl_cad.Location = new System.Drawing.Point(142, 267);
            this.lbl_cad.Name = "lbl_cad";
            this.lbl_cad.Size = new System.Drawing.Size(178, 16);
            this.lbl_cad.TabIndex = 3;
            this.lbl_cad.Text = "Cadastro de Funcionário";
            this.lbl_cad.Click += new System.EventHandler(this.lbl_cad_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(75, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Login:  ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(75, 159);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Senha:";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Depth = 0;
            this.btn_entrar.Location = new System.Drawing.Point(182, 216);
            this.btn_entrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Primary = true;
            this.btn_entrar.Size = new System.Drawing.Size(99, 34);
            this.btn_entrar.TabIndex = 8;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click_1);
            // 
            // btn_sair
            // 
            this.btn_sair.Depth = 0;
            this.btn_sair.Location = new System.Drawing.Point(12, 364);
            this.btn_sair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Primary = true;
            this.btn_sair.Size = new System.Drawing.Size(99, 36);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_nome_log
            // 
            this.lbl_nome_log.BackColor = System.Drawing.Color.DarkViolet;
            this.lbl_nome_log.ForeColor = System.Drawing.Color.Coral;
            this.lbl_nome_log.Location = new System.Drawing.Point(30, 283);
            this.lbl_nome_log.Name = "lbl_nome_log";
            this.lbl_nome_log.Size = new System.Drawing.Size(250, 23);
            this.lbl_nome_log.TabIndex = 11;
            this.lbl_nome_log.Visible = false;
            // 
            // lbl_sbre
            // 
            this.lbl_sbre.BackColor = System.Drawing.Color.DarkViolet;
            this.lbl_sbre.ForeColor = System.Drawing.Color.Coral;
            this.lbl_sbre.Location = new System.Drawing.Point(30, 307);
            this.lbl_sbre.Name = "lbl_sbre";
            this.lbl_sbre.Size = new System.Drawing.Size(250, 23);
            this.lbl_sbre.TabIndex = 12;
            this.lbl_sbre.Visible = false;
            // 
            // lbl_rg
            // 
            this.lbl_rg.BackColor = System.Drawing.Color.DarkViolet;
            this.lbl_rg.ForeColor = System.Drawing.Color.Coral;
            this.lbl_rg.Location = new System.Drawing.Point(30, 332);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(250, 23);
            this.lbl_rg.TabIndex = 13;
            this.lbl_rg.Visible = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(437, 412);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.lbl_sbre);
            this.Controls.Add(this.lbl_nome_log);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lbl_cad);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                            Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_cad;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_entrar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nome_log;
        private System.Windows.Forms.Label lbl_sbre;
        private System.Windows.Forms.Label lbl_rg;
    }
}

