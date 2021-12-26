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

namespace AGAProje
{
    public partial class Siparis : MaterialForm
    {
        SqlConnection con = new SqlConnection("server=.; Initial Catalog=SATIS_OTOMASYONU;Integrated Security=SSPI");

        public Siparis()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange100, TextShade.WHITE);
            GriddoldurURUN();
            GriddoldurSIP();
        }

        private void GriddoldurURUN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT UrunAd, UrunFiyat, UrunAgirlik, UrunAciklama, UrunStok FROM AGA_TBL_URUNBILGI", con);
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds, "AGA_TBL_URUNBILGI");
            gcMusUrun.DataSource = ds.Tables["AGA_TBL_URUNBILGI"];
            con.Close();

        }

        private void GriddoldurSIP()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MU.MusID, MU.MusAd, MU.MusSoyad, MU.MusAdres, UB.UrunID, UB.UrunAd, UB.UrunStok, UB.UrunFiyat, UB.UrunAgirlik FROM AGA_TBL_MUS MU INNER JOIN AGA_TBL_URUNBILGI UB ON MU.ID=UB.ID ", con);
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds, "AGA_TBL_URUNBILGI");
            gcMusSip.DataSource = ds.Tables["AGA_TBL_URUNBILGI"];
            con.Close();
        }

        float Fiyat = 0;
        float TFiyat = 0;
        float Agirlik = 0;
        float TAgirlik = 0;

        private void gcMusUrun_DoubleClick(object sender, EventArgs e)
        { 
            Fiyat = float.Parse(gcMusUrun1.GetFocusedRowCellValue("UrunFiyat").ToString());
            TFiyat += Fiyat;
            string toString = TFiyat.ToString();
            txtbToplamF.Text = toString;

            Agirlik = float.Parse(gcMusUrun1.GetFocusedRowCellValue("UrunAgirlik").ToString());
            TAgirlik += Agirlik;
            string toString1 = TAgirlik.ToString();
            txtSptAgırlık.Text = toString1;
        }


        private void btnSipOnay_Click(object sender, EventArgs e)
        {
            FormOdeme OD = new FormOdeme();
            OD.Show();
        }

        
    }
}
