using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGAProje
{
    public partial class formGiris : MaterialForm
    {
        public formGiris()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange100, TextShade.WHITE);
        }

        private void matbtnMusYon_Click(object sender, EventArgs e)
        {
            FormMusGiris MG = new FormMusGiris();
            MG.Show();
        }

        private void matbtnAdYon_Click(object sender, EventArgs e)
        {
            FormAdminGiris AG = new FormAdminGiris();
            AG.Show();
        }
    }
}
