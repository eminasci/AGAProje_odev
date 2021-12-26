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
using System.Data.SqlClient;
using System.IO;

namespace AGAProje
{
    public partial class FormAdminGiris : MaterialForm
    {
        public FormAdminGiris()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange100, TextShade.WHITE);
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9U648KD;Initial Catalog=SATIS_OTOMASYONU;Integrated Security=True");

        private void matbtnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtbAdAd.Text == "" || txtbAdSifre.Text == "")
            {
                MessageBox.Show("Kullanici Adi veya Sifre bos gecilemez!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlCommand cmmd = new SqlCommand("SELECT * FROM AGA_TBL_ADMIN WHERE AdmAd = '" + txtbAdAd.Text + "' and AdmSifre = '" + txtbAdSifre.Text + "'", con);
                SqlDataReader dr = cmmd.ExecuteReader();
                if (dr.Read())
                {
                    Urun adana = new Urun();
                    FormMusGiris.ActiveForm.Visible = false;
                    formGiris.ActiveForm.Visible = false;
                    adana.Show();
                }
                else
                {
                    MessageBox.Show("Kullanici Adi veya Sifrenizi kontrol ediniz!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }
    }
}
