namespace software_Pet
{
    partial class frm_BonusFidelidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BonusFidelidade));
            this.txt_protocolo_animal = new System.Windows.Forms.TextBox();
            this.lbl_nome_animal = new System.Windows.Forms.Label();
            this.lbl_protocolo_animal = new System.Windows.Forms.Label();
            this.lbl_exp_nome_animal = new System.Windows.Forms.Label();
            this.lbl_pontos_acumulados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_exp_pontos_acumulados = new System.Windows.Forms.Label();
            this.lbl_pontos_rmv = new System.Windows.Forms.Label();
            this.txt_pontos_rmv = new System.Windows.Forms.TextBox();
            this.btn_RmvPnts = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_pontos_antes_remov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_protocolo_animal
            // 
            this.txt_protocolo_animal.Location = new System.Drawing.Point(194, 112);
            this.txt_protocolo_animal.Name = "txt_protocolo_animal";
            this.txt_protocolo_animal.Size = new System.Drawing.Size(153, 21);
            this.txt_protocolo_animal.TabIndex = 1;
            this.txt_protocolo_animal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_protocolo_animal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_protocolo_animal_KeyPress);
            this.txt_protocolo_animal.Leave += new System.EventHandler(this.txt_protocolo_animal_Leave);
            // 
            // lbl_nome_animal
            // 
            this.lbl_nome_animal.AutoSize = true;
            this.lbl_nome_animal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_animal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nome_animal.Location = new System.Drawing.Point(48, 142);
            this.lbl_nome_animal.Name = "lbl_nome_animal";
            this.lbl_nome_animal.Size = new System.Drawing.Size(121, 15);
            this.lbl_nome_animal.TabIndex = 0;
            this.lbl_nome_animal.Text = "Nome do Animal :";
            // 
            // lbl_protocolo_animal
            // 
            this.lbl_protocolo_animal.AutoSize = true;
            this.lbl_protocolo_animal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_protocolo_animal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_protocolo_animal.Location = new System.Drawing.Point(48, 113);
            this.lbl_protocolo_animal.Name = "lbl_protocolo_animal";
            this.lbl_protocolo_animal.Size = new System.Drawing.Size(140, 15);
            this.lbl_protocolo_animal.TabIndex = 0;
            this.lbl_protocolo_animal.Text = "Protocolo do Animal:";
            // 
            // lbl_exp_nome_animal
            // 
            this.lbl_exp_nome_animal.BackColor = System.Drawing.Color.White;
            this.lbl_exp_nome_animal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_nome_animal.Location = new System.Drawing.Point(175, 142);
            this.lbl_exp_nome_animal.Name = "lbl_exp_nome_animal";
            this.lbl_exp_nome_animal.Size = new System.Drawing.Size(172, 21);
            this.lbl_exp_nome_animal.TabIndex = 0;
            this.lbl_exp_nome_animal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pontos_acumulados
            // 
            this.lbl_pontos_acumulados.AutoSize = true;
            this.lbl_pontos_acumulados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontos_acumulados.Location = new System.Drawing.Point(48, 174);
            this.lbl_pontos_acumulados.Name = "lbl_pontos_acumulados";
            this.lbl_pontos_acumulados.Size = new System.Drawing.Size(137, 15);
            this.lbl_pontos_acumulados.TabIndex = 0;
            this.lbl_pontos_acumulados.Text = "Pontos Acumulados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(197, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Bônus Fidelidade: ";
            // 
            // lbl_exp_pontos_acumulados
            // 
            this.lbl_exp_pontos_acumulados.BackColor = System.Drawing.Color.White;
            this.lbl_exp_pontos_acumulados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_exp_pontos_acumulados.Location = new System.Drawing.Point(191, 174);
            this.lbl_exp_pontos_acumulados.Name = "lbl_exp_pontos_acumulados";
            this.lbl_exp_pontos_acumulados.Size = new System.Drawing.Size(156, 21);
            this.lbl_exp_pontos_acumulados.TabIndex = 0;
            this.lbl_exp_pontos_acumulados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pontos_rmv
            // 
            this.lbl_pontos_rmv.AutoSize = true;
            this.lbl_pontos_rmv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontos_rmv.Location = new System.Drawing.Point(48, 205);
            this.lbl_pontos_rmv.Name = "lbl_pontos_rmv";
            this.lbl_pontos_rmv.Size = new System.Drawing.Size(128, 15);
            this.lbl_pontos_rmv.TabIndex = 0;
            this.lbl_pontos_rmv.Text = "Pontos a Remover:";
            // 
            // txt_pontos_rmv
            // 
            this.txt_pontos_rmv.Location = new System.Drawing.Point(184, 204);
            this.txt_pontos_rmv.MaxLength = 7;
            this.txt_pontos_rmv.Name = "txt_pontos_rmv";
            this.txt_pontos_rmv.Size = new System.Drawing.Size(163, 21);
            this.txt_pontos_rmv.TabIndex = 2;
            this.txt_pontos_rmv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pontos_rmv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pontos_rmv_KeyPress);
            // 
            // btn_RmvPnts
            // 
            this.btn_RmvPnts.Depth = 0;
            this.btn_RmvPnts.Enabled = false;
            this.btn_RmvPnts.Location = new System.Drawing.Point(403, 120);
            this.btn_RmvPnts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_RmvPnts.Name = "btn_RmvPnts";
            this.btn_RmvPnts.Primary = true;
            this.btn_RmvPnts.Size = new System.Drawing.Size(150, 38);
            this.btn_RmvPnts.TabIndex = 3;
            this.btn_RmvPnts.Text = "Remover Pontos";
            this.btn_RmvPnts.UseVisualStyleBackColor = true;
            this.btn_RmvPnts.Click += new System.EventHandler(this.btn_RmvPnts_Click_1);
            // 
            // lbl_pontos_antes_remov
            // 
            this.lbl_pontos_antes_remov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pontos_antes_remov.Location = new System.Drawing.Point(403, 174);
            this.lbl_pontos_antes_remov.Name = "lbl_pontos_antes_remov";
            this.lbl_pontos_antes_remov.Size = new System.Drawing.Size(150, 21);
            this.lbl_pontos_antes_remov.TabIndex = 5;
            this.lbl_pontos_antes_remov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pontos_antes_remov.Visible = false;
            // 
            // frm_BonusFidelidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(642, 249);
            this.Controls.Add(this.lbl_pontos_antes_remov);
            this.Controls.Add(this.btn_RmvPnts);
            this.Controls.Add(this.txt_pontos_rmv);
            this.Controls.Add(this.lbl_pontos_rmv);
            this.Controls.Add(this.lbl_exp_pontos_acumulados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pontos_acumulados);
            this.Controls.Add(this.lbl_exp_nome_animal);
            this.Controls.Add(this.lbl_protocolo_animal);
            this.Controls.Add(this.txt_protocolo_animal);
            this.Controls.Add(this.lbl_nome_animal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frm_BonusFidelidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                          Bônus Fidelidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_protocolo_animal;
        private System.Windows.Forms.Label lbl_nome_animal;
        private System.Windows.Forms.Label lbl_protocolo_animal;
        private System.Windows.Forms.Label lbl_exp_nome_animal;
        private System.Windows.Forms.Label lbl_pontos_acumulados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_exp_pontos_acumulados;
        private System.Windows.Forms.Label lbl_pontos_rmv;
        private System.Windows.Forms.TextBox txt_pontos_rmv;
        private MaterialSkin.Controls.MaterialRaisedButton btn_RmvPnts;
        private System.Windows.Forms.Label lbl_pontos_antes_remov;
    }
}