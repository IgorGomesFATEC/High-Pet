namespace software_Pet
{
    partial class frm_ConsultaPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultaPets));
            this.dgv_ConsultaPets = new System.Windows.Forms.DataGridView();
            this.grb_pesquisa = new System.Windows.Forms.GroupBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.btn_atualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_menu = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaPets)).BeginInit();
            this.grb_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ConsultaPets
            // 
            this.dgv_ConsultaPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ConsultaPets.Location = new System.Drawing.Point(41, 150);
            this.dgv_ConsultaPets.Name = "dgv_ConsultaPets";
            this.dgv_ConsultaPets.Size = new System.Drawing.Size(464, 178);
            this.dgv_ConsultaPets.TabIndex = 2;
            // 
            // grb_pesquisa
            // 
            this.grb_pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.grb_pesquisa.Controls.Add(this.txt_pesquisa);
            this.grb_pesquisa.Controls.Add(this.btn_filtrar);
            this.grb_pesquisa.Controls.Add(this.lbl_pesquisa);
            this.grb_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_pesquisa.ForeColor = System.Drawing.Color.DarkViolet;
            this.grb_pesquisa.Location = new System.Drawing.Point(41, 74);
            this.grb_pesquisa.Name = "grb_pesquisa";
            this.grb_pesquisa.Size = new System.Drawing.Size(464, 70);
            this.grb_pesquisa.TabIndex = 4;
            this.grb_pesquisa.TabStop = false;
            this.grb_pesquisa.Text = "Filtrar Pets:";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.ForeColor = System.Drawing.Color.Black;
            this.txt_pesquisa.Location = new System.Drawing.Point(167, 31);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(183, 22);
            this.txt_pesquisa.TabIndex = 1;
            this.txt_pesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisa_KeyPress);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Depth = 0;
            this.btn_filtrar.Location = new System.Drawing.Point(356, 26);
            this.btn_filtrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Primary = true;
            this.btn_filtrar.Size = new System.Drawing.Size(102, 33);
            this.btn_filtrar.TabIndex = 5;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisa.ForeColor = System.Drawing.Color.Black;
            this.lbl_pesquisa.Location = new System.Drawing.Point(6, 34);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(155, 16);
            this.lbl_pesquisa.TabIndex = 0;
            this.lbl_pesquisa.Text = "Digite o RG do Dono:";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Depth = 0;
            this.btn_atualizar.Location = new System.Drawing.Point(50, 338);
            this.btn_atualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Primary = true;
            this.btn_atualizar.Size = new System.Drawing.Size(92, 29);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click_1);
            // 
            // btn_menu
            // 
            this.btn_menu.Depth = 0;
            this.btn_menu.Location = new System.Drawing.Point(424, 336);
            this.btn_menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Primary = true;
            this.btn_menu.Size = new System.Drawing.Size(75, 31);
            this.btn_menu.TabIndex = 7;
            this.btn_menu.Text = "menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click_1);
            // 
            // frm_ConsultaPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(552, 377);
            this.ControlBox = false;
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.grb_pesquisa);
            this.Controls.Add(this.dgv_ConsultaPets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ConsultaPets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                            Pets";
            this.Load += new System.EventHandler(this.frm_consultaPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ConsultaPets)).EndInit();
            this.grb_pesquisa.ResumeLayout(false);
            this.grb_pesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ConsultaPets;
        private System.Windows.Forms.GroupBox grb_pesquisa;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label lbl_pesquisa;
        private MaterialSkin.Controls.MaterialRaisedButton btn_filtrar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_atualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_menu;
    }
}