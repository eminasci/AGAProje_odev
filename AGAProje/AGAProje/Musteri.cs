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
using MaterialSkin.Controls;
using MaterialSkin;

namespace AGAProje
{
    public partial class Musteri : MaterialForm
    {
       
        public Musteri()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange100, TextShade.WHITE);
            
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9U648KD;Initial Catalog=SATIS_OTOMASYONU;Integrated Security=True");

        private void matbtnUYEOL_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();            
            con.Open();
            cmd.Connection = con;

            DialogResult secenek = MessageBox.Show("Uyelik bilgilerinizi onaylıyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
               SqlCommand cmmd = new SqlCommand("insert into AGA_TBL_MUS(MusAd, MusSoyad, MusEmail, MusAdres, MusSifre) values (@UyeAd, @UyeSoyad, @UyeEmail, @UyeAdres, @UyeSifre)",con);
                cmmd.Parameters.AddWithValue("@UyeAd", txtbUyeAd.Text);
                cmmd.Parameters.AddWithValue("@UyeSoyad", txtbUyeSoyad.Text);
                cmmd.Parameters.AddWithValue("@UyeEmail", txtbUyeEmail.Text);
                cmmd.Parameters.AddWithValue("@UyeAdres", rtxtbUyeAdres.Text);
                cmmd.Parameters.AddWithValue("@UyeSifre", txtbUyeSifre.Text);
                cmmd.ExecuteNonQuery();
                con.Close();

                Musteri.ActiveForm.Visible = false;
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
            con.Close();

                      
        }
        
    }
}
