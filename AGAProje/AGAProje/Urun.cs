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
using System.Data.Sql;
using System.IO;

namespace AGAProje
{
    public partial class Urun : MaterialForm
    {
        SqlConnection con = new SqlConnection("server=.; Initial Catalog=SATIS_OTOMASYONU;Integrated Security=SSPI");
        public string pathCV { get; set; }
        public Urun()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.DeepOrange100, TextShade.WHITE);
            GriddoldurADSIP();
            GriddoldurADURUN();
        }

        private void GriddoldurADSIP()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MU.MusID, MU.MusAd, MU.MusSoyad, MU.MusAdres, UB.UrunID, UB.UrunAd, UB.UrunStok, UB.UrunFiyat, UB.UrunAgirlik FROM AGA_TBL_MUS MU INNER JOIN AGA_TBL_URUNBILGI UB ON MU.ID=UB.ID", con);
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds, "AGA_TBL_URUNBILGI");
            gcAdmSip.DataSource = ds.Tables["AGA_TBL_URUNBILGI"];
            con.Close();
        }

        private void GriddoldurADURUN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT UrunID, UrunAd, UrunFiyat, UrunVergiTip, UrunAgirlik, UrunStok, UrunAciklama,RESIM FROM AGA_TBL_URUNBILGI", con);
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds, "AGA_TBL_URUNBILGI");
            gcUrEkle.DataSource = ds.Tables["AGA_TBL_URUNBILGI"];
            con.Close();
        }

        //Gridcontrol to textbox
        private void gcUrEkle_DoubleClick(object sender, EventArgs e)
        {
            txtbUriID.Text = gcUrEkle1.GetFocusedRowCellValue("UrunID").ToString();

            txtbUrAd.Text = gcUrEkle1.GetFocusedRowCellValue("UrunAd").ToString();
            txtbUrFiyat.Text = gcUrEkle1.GetFocusedRowCellValue("UrunFiyat").ToString();
            txtbUrVergi.Text = gcUrEkle1.GetFocusedRowCellValue("UrunVergiTip").ToString();
            txtbUrAgirlik.Text = gcUrEkle1.GetFocusedRowCellValue("UrunAgirlik").ToString();
            txtbUrStok.Text = gcUrEkle1.GetFocusedRowCellValue("UrunStok").ToString();
            txtbUrAciklama.Text = gcUrEkle1.GetFocusedRowCellValue("UrunAciklama").ToString();

            //string Picture = gcUrEkle1.GetFocusedRowCellValue("RESIM").ToString();
            //if (!String.IsNullOrEmpty(Picture))
            //{
            //    byte[] bytes = Convert.FromBase64String(Picture);
            //    var image = new MemoryStream(bytes);
            //    Image img = Image.FromStream(image);
            //    picbUrunResim.Image = img;
            //}
            //else
            //{
            //    picbUrunResim.Image = null;
            //}
        }

        private void hesapVergi()
        {

        }

        //SQL islemleri
        private void btnUrYeni_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Urun_id", txtbUriID.Text));

            cmd.CommandText = "insert into AGA_TBL_URUNBILGI(UrunAd, UrunFiyat, UrunVergiTip, UrunAgirlik, UrunStok, UrunAciklama) values ('" + txtbUrAd.Text + "','" + txtbUrFiyat.Text + "','" + txtbUrVergi.Text + "','" + txtbUrAgirlik.Text + "','" + txtbUrStok.Text + "','" + txtbUrAciklama.Text + "')";

            cmd.ExecuteNonQuery();
            con.Close();
            GriddoldurADURUN();
        }


        private void btnUrGunc_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Urun_id", txtbUriID.Text));

            DialogResult secenek = MessageBox.Show("Secili urune ait bilgiler guncellenecektir bu isleme devam etmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                cmd.CommandText = "update AGA_TBL_URUNBILGI set UrunAd='" + txtbUrAd.Text + "',UrunFiyat='" + txtbUrFiyat.Text + "', UrunVergiTip='" + txtbUrVergi.Text + "', UrunAgirlik='" + txtbUrAgirlik.Text + "', UrunStok='" + txtbUrStok.Text + "',  UrunAciklama='" + txtbUrAciklama.Text + "' where UrunID=@Urun_id ";
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
            cmd.ExecuteNonQuery();
            con.Close();
            GriddoldurADURUN();
        }
        private void btnUrSil_Click(object sender, EventArgs e)
        {
                

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Urun_id", txtbUriID.Text));

            DialogResult secenek = MessageBox.Show("Secili urune ait bilgiler silinecektir bu isleme devam etmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
              cmd.CommandText = "delete from AGA_TBL_URUNBILGI where UrunID=@Urun_id ";
            }
            else if (secenek == DialogResult.No)
            {
              return;
            }

            cmd.ExecuteNonQuery();
            con.Close();
            GriddoldurADURUN();
        }


        string imagepath;

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Resim Seç";
            file.Filter = "Jpeg Dosyaları(*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpg| Png Dosyaları(*.png)|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picbUrunResim.Image = Image.FromFile(file.FileName);
                imagepath = file.FileName;
            }
        }

        private void btnResimKaydet_Click(object sender, EventArgs e)
        {
            string KayitliMi = "0";
            SqlCommand cmd = new SqlCommand();
            SqlCommand kom = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog1.FileName.Length > 0)
                {
                    pathCV = openFileDialog1.FileName;

                    string dosya = openFileDialog1.Title.ToString();
                    string filePath = openFileDialog1.FileName;
                    byte[] bytes = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    string UrunID = txtbUriID.Text;
                    string Dosya_adi = openFileDialog1.SafeFileName;
                    string Uzanti = openFileDialog1.SafeFileName.Split('.')[1];
                    string dosyaa = "convert(varbinary(max),'" + base64String + "')";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("'" + UrunID + "',");
                    sb.AppendLine("'" + Dosya_adi + "',");
                    sb.AppendLine("'" + Uzanti + "',");
                    sb.AppendLine(dosyaa);

                    kom = new SqlCommand("select count(*) A from AGA_TBL_URUNBILGI where UrunID='" + UrunID + "'", con);
                    SqlDataReader dr = kom.ExecuteReader();
                    while (dr.Read())
                    {
                        KayitliMi = dr[0].ToString();

                    }
                    dr.Close();

                    if (KayitliMi != "0")
                    {
                        cmd.CommandText = "update [SATIS_OTOMASYONU].[dbo].[AGA_TBL_URUNBILGI] set RESIM =" + dosyaa + ",RESIM_ADI='" + Dosya_adi + "',UZANTI='" + Uzanti + "' where UrunID='" + UrunID + "'";
                        con.Close();
                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("İlgili Urun kayıtlı degildir. Lutfen oncelikle Urun bilgilerini giriniz, veya Urun seciniz.", "Bilgilendirme Penceresi");
                    }

                    con.Close();
                    //
                    GriddoldurADURUN();
                }
            }
        }

        
    }
}
