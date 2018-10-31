using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace software_Pet
{
    public partial class frm_Pgb : MaterialForm
    {
        public frm_Pgb()
        {
            InitializeComponent();
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Purple600, Primary.Grey50, Primary.Red200, Accent.Amber700, TextShade.WHITE);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pgb.Value<100)
            {
                pgb.Value = pgb.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                frm_Login login = new frm_Login();
                login.Show();
                this.Visible = false;
                this.Enabled = false;
            }
        }
    }
}
