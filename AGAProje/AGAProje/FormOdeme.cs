using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace AGAProje
{
    public partial  class FormOdeme : MaterialForm
    {
        public FormOdeme()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange100, TextShade.WHITE);
        }        
    }

    public class Kredi : Odeme
    {
        private void btnOdOnayKK_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Odemenizi Onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                FormOdeme.ActiveForm.Visible = false;
                
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }
    }

    public class Nakit : Odeme
    {
        private void btnOdOnayN_Click(object sender, EventArgs e)
        {
            FormOdeme.ActiveForm.Visible = false;
        }
    }

    public class Cek : Odeme
    {
        private void btnOdOnayC_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Odemenizi Onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                FormOdeme.ActiveForm.Visible = false;
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }
    }
}
