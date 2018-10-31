namespace software_Pet
{
    partial class frm_bonfide
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_rmvpnts = new System.Windows.Forms.Button();
            this.dgv_pontos = new System.Windows.Forms.DataGridView();
            this.btn_procura = new System.Windows.Forms.Button();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pontos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_pontos);
            this.groupBox1.Location = new System.Drawing.Point(3, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(590, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do bonus ";
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(32, 356);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 41);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_rmvpnts
            // 
            this.btn_rmvpnts.Location = new System.Drawing.Point(490, 359);
            this.btn_rmvpnts.Name = "btn_rmvpnts";
            this.btn_rmvpnts.Size = new System.Drawing.Size(75, 38);
            this.btn_rmvpnts.TabIndex = 5;
            this.btn_rmvpnts.Text = "Remover Pontos ";
            this.btn_rmvpnts.UseVisualStyleBackColor = true;
            // 
            // dgv_pontos
            // 
            this.dgv_pontos.AllowUserToOrderColumns = true;
            this.dgv_pontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pontos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pontos.Location = new System.Drawing.Point(4, 17);
            this.dgv_pontos.Name = "dgv_pontos";
            this.dgv_pontos.Size = new System.Drawing.Size(582, 256);
            this.dgv_pontos.TabIndex = 0;
            // 
            // btn_procura
            // 
            this.btn_procura.Location = new System.Drawing.Point(469, 28);
            this.btn_procura.Name = "btn_procura";
            this.btn_procura.Size = new System.Drawing.Size(75, 23);
            this.btn_procura.TabIndex = 6;
            this.btn_procura.Text = "Procurar";
            this.btn_procura.UseVisualStyleBackColor = true;
            // 
            // txt_procurar
            // 
            this.txt_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procurar.Location = new System.Drawing.Point(219, 29);
            this.txt_procurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(243, 21);
            this.txt_procurar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o RG do Cliente:";
            // 
            // frm_bonfide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_procurar);
            this.Controls.Add(this.btn_rmvpnts);
            this.Controls.Add(this.btn_procura);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_bonfide";
            this.Text = "                                                                           Bonus " +
    "Fidelidade";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_rmvpnts;
        private System.Windows.Forms.DataGridView dgv_pontos;
        private System.Windows.Forms.Button btn_procura;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.Label label1;
    }
}