namespace software_Pet
{
    partial class frm_ConsultaServ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultaServ));
            this.dgv_serv = new System.Windows.Forms.DataGridView();
            this.grb_pesquisa = new System.Windows.Forms.GroupBox();
            this.txt_pesquisa_rg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_pesquisa_prot = new System.Windows.Forms.TextBox();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_atualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serv)).BeginInit();
            this.grb_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_serv
            // 
            this.dgv_serv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_serv.Location = new System.Drawing.Point(12, 178);
            this.dgv_serv.Name = "dgv_serv";
            this.dgv_serv.Size = new System.Drawing.Size(532, 203);
            this.dgv_serv.TabIndex = 3;
            this.dgv_serv.VirtualMode = true;
            // 
            // grb_pesquisa
            // 
            this.grb_pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.grb_pesquisa.Controls.Add(this.txt_pesquisa_rg);
            this.grb_pesquisa.Controls.Add(this.label1);
            this.grb_pesquisa.Controls.Add(this.btn_filtrar);
            this.grb_pesquisa.Controls.Add(this.txt_pesquisa_prot);
            this.grb_pesquisa.Controls.Add(this.lbl_pesquisa);
            this.grb_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_pesquisa.ForeColor = System.Drawing.Color.DarkViolet;
            this.grb_pesquisa.Location = new System.Drawing.Point(12, 83);
            this.grb_pesquisa.Name = "grb_pesquisa";
            this.grb_pesquisa.Size = new System.Drawing.Size(532, 89);
            this.grb_pesquisa.TabIndex = 5;
            this.grb_pesquisa.TabStop = false;
            this.grb_pesquisa.Text = "Filtrar Serviços:";
            // 
            // txt_pesquisa_rg
            // 
            this.txt_pesquisa_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa_rg.Location = new System.Drawing.Point(157, 56);
            this.txt_pesquisa_rg.Name = "txt_pesquisa_rg";
            this.txt_pesquisa_rg.Size = new System.Drawing.Size(261, 22);
            this.txt_pesquisa_rg.TabIndex = 4;
            this.txt_pesquisa_rg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pesquisa_rg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisa_rg_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = " RG do Funcionário:";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Depth = 0;
            this.btn_filtrar.Location = new System.Drawing.Point(424, 22);
            this.btn_filtrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Primary = true;
            this.btn_filtrar.Size = new System.Drawing.Size(102, 58);
            this.btn_filtrar.TabIndex = 6;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // txt_pesquisa_prot
            // 
            this.txt_pesquisa_prot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa_prot.ForeColor = System.Drawing.Color.Black;
            this.txt_pesquisa_prot.Location = new System.Drawing.Point(222, 26);
            this.txt_pesquisa_prot.Name = "txt_pesquisa_prot";
            this.txt_pesquisa_prot.Size = new System.Drawing.Size(196, 22);
            this.txt_pesquisa_prot.TabIndex = 1;
            this.txt_pesquisa_prot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pesquisa_prot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisa_prot_KeyPress);
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa.ForeColor = System.Drawing.Color.Black;
            this.lbl_pesquisa.Location = new System.Drawing.Point(6, 29);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(216, 16);
            this.lbl_pesquisa.TabIndex = 0;
            this.lbl_pesquisa.Text = "Digite o Protocolo do Serviço:";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Depth = 0;
            this.btn_atualizar.Location = new System.Drawing.Point(24, 391);
            this.btn_atualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Primary = true;
            this.btn_atualizar.Size = new System.Drawing.Size(83, 32);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click_1);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Depth = 0;
            this.btn_Menu.Location = new System.Drawing.Point(422, 391);
            this.btn_Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Primary = true;
            this.btn_Menu.Size = new System.Drawing.Size(105, 31);
            this.btn_Menu.TabIndex = 8;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click_1);
            // 
            // frm_ConsultaServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(556, 433);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.grb_pesquisa);
            this.Controls.Add(this.dgv_serv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ConsultaServ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                       Serviços";
            this.Load += new System.EventHandler(this.frm_ConsultaServ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serv)).EndInit();
            this.grb_pesquisa.ResumeLayout(false);
            this.grb_pesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_serv;
        private System.Windows.Forms.GroupBox grb_pesquisa;
        private System.Windows.Forms.TextBox txt_pesquisa_prot;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pesquisa_rg;
        private MaterialSkin.Controls.MaterialRaisedButton btn_filtrar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_atualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Menu;
    }
}