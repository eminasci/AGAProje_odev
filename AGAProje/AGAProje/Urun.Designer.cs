
namespace AGAProje
{
    partial class Urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urun));
            this.tabcAdminAna = new System.Windows.Forms.TabControl();
            this.tabASiparisler = new System.Windows.Forms.TabPage();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gcAdmSip = new DevExpress.XtraGrid.GridControl();
            this.gcAdmSip1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSipMusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunAgirlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipMusAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipMusSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipMusAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabAUrunler = new System.Windows.Forms.TabPage();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnResimKaydet = new System.Windows.Forms.Button();
            this.txtbUriID = new System.Windows.Forms.TextBox();
            this.gcUrEkle = new DevExpress.XtraGrid.GridControl();
            this.gcUrEkle1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunVergiTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunAgirlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUrSil = new System.Windows.Forms.Button();
            this.btnUrGunc = new System.Windows.Forms.Button();
            this.btnUrYeni = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picbUrunResim = new System.Windows.Forms.PictureBox();
            this.txtbUrAciklama = new System.Windows.Forms.TextBox();
            this.txtbUrStok = new System.Windows.Forms.TextBox();
            this.txtbUrAgirlik = new System.Windows.Forms.TextBox();
            this.txtbUrVergi = new System.Windows.Forms.TextBox();
            this.txtbUrFiyat = new System.Windows.Forms.TextBox();
            this.txtbUrAd = new System.Windows.Forms.TextBox();
            this.lblUrunAciklama = new System.Windows.Forms.Label();
            this.lblUrunStok = new System.Windows.Forms.Label();
            this.lblUrAgirlik = new System.Windows.Forms.Label();
            this.lblUrVergiTip = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUrBilgi = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.tabcAdminAna.SuspendLayout();
            this.tabASiparisler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmSip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmSip1)).BeginInit();
            this.tabAUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrEkle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcAdminAna
            // 
            this.tabcAdminAna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcAdminAna.Controls.Add(this.tabASiparisler);
            this.tabcAdminAna.Controls.Add(this.tabAUrunler);
            this.tabcAdminAna.Location = new System.Drawing.Point(3, 66);
            this.tabcAdminAna.Name = "tabcAdminAna";
            this.tabcAdminAna.SelectedIndex = 0;
            this.tabcAdminAna.Size = new System.Drawing.Size(945, 430);
            this.tabcAdminAna.TabIndex = 0;
            // 
            // tabASiparisler
            // 
            this.tabASiparisler.Controls.Add(this.btnKayitSil);
            this.tabASiparisler.Controls.Add(this.panel6);
            this.tabASiparisler.Controls.Add(this.gcAdmSip);
            this.tabASiparisler.Location = new System.Drawing.Point(4, 22);
            this.tabASiparisler.Name = "tabASiparisler";
            this.tabASiparisler.Padding = new System.Windows.Forms.Padding(3);
            this.tabASiparisler.Size = new System.Drawing.Size(937, 404);
            this.tabASiparisler.TabIndex = 0;
            this.tabASiparisler.Text = "Siparisler";
            this.tabASiparisler.UseVisualStyleBackColor = true;
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKayitSil.Location = new System.Drawing.Point(422, 325);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(102, 26);
            this.btnKayitSil.TabIndex = 4;
            this.btnKayitSil.Text = "Kaydı Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.OrangeRed;
            this.panel6.Location = new System.Drawing.Point(8, 318);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(920, 1);
            this.panel6.TabIndex = 3;
            // 
            // gcAdmSip
            // 
            this.gcAdmSip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAdmSip.Location = new System.Drawing.Point(3, 3);
            this.gcAdmSip.MainView = this.gcAdmSip1;
            this.gcAdmSip.Name = "gcAdmSip";
            this.gcAdmSip.Size = new System.Drawing.Size(931, 308);
            this.gcAdmSip.TabIndex = 0;
            this.gcAdmSip.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcAdmSip1});
            // 
            // gcAdmSip1
            // 
            this.gcAdmSip1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSipMusID,
            this.gridColumnSipUrunID,
            this.gridColumnSipUrunAd,
            this.gridColumnSipUrunMiktar,
            this.gridColumnSipUrunFiyat,
            this.gridColumnSipUrunAgirlik,
            this.gridColumnSipMusAd,
            this.gridColumnSipMusSoyad,
            this.gridColumnSipMusAdres});
            this.gcAdmSip1.GridControl = this.gcAdmSip;
            this.gcAdmSip1.Name = "gcAdmSip1";
            // 
            // gridColumnSipMusID
            // 
            this.gridColumnSipMusID.Caption = "Musteri ID";
            this.gridColumnSipMusID.FieldName = "MusID";
            this.gridColumnSipMusID.Name = "gridColumnSipMusID";
            this.gridColumnSipMusID.Visible = true;
            this.gridColumnSipMusID.VisibleIndex = 0;
            // 
            // gridColumnSipUrunID
            // 
            this.gridColumnSipUrunID.Caption = "Urun ID";
            this.gridColumnSipUrunID.FieldName = "UrunID";
            this.gridColumnSipUrunID.Name = "gridColumnSipUrunID";
            this.gridColumnSipUrunID.Visible = true;
            this.gridColumnSipUrunID.VisibleIndex = 1;
            // 
            // gridColumnSipUrunAd
            // 
            this.gridColumnSipUrunAd.Caption = "Urun Ad";
            this.gridColumnSipUrunAd.FieldName = "UrunAd";
            this.gridColumnSipUrunAd.Name = "gridColumnSipUrunAd";
            this.gridColumnSipUrunAd.Visible = true;
            this.gridColumnSipUrunAd.VisibleIndex = 2;
            // 
            // gridColumnSipUrunMiktar
            // 
            this.gridColumnSipUrunMiktar.Caption = "Urun Miktar";
            this.gridColumnSipUrunMiktar.FieldName = "UrunMiktar";
            this.gridColumnSipUrunMiktar.Name = "gridColumnSipUrunMiktar";
            this.gridColumnSipUrunMiktar.Visible = true;
            this.gridColumnSipUrunMiktar.VisibleIndex = 3;
            // 
            // gridColumnSipUrunFiyat
            // 
            this.gridColumnSipUrunFiyat.Caption = "Urun Fiyat";
            this.gridColumnSipUrunFiyat.FieldName = "UrunFiyat";
            this.gridColumnSipUrunFiyat.Name = "gridColumnSipUrunFiyat";
            this.gridColumnSipUrunFiyat.Visible = true;
            this.gridColumnSipUrunFiyat.VisibleIndex = 4;
            // 
            // gridColumnSipUrunAgirlik
            // 
            this.gridColumnSipUrunAgirlik.Caption = "Urun Agirlik";
            this.gridColumnSipUrunAgirlik.FieldName = "UrunAgirlik";
            this.gridColumnSipUrunAgirlik.Name = "gridColumnSipUrunAgirlik";
            this.gridColumnSipUrunAgirlik.Visible = true;
            this.gridColumnSipUrunAgirlik.VisibleIndex = 5;
            // 
            // gridColumnSipMusAd
            // 
            this.gridColumnSipMusAd.Caption = "Musteri Ad";
            this.gridColumnSipMusAd.FieldName = "MusAd";
            this.gridColumnSipMusAd.Name = "gridColumnSipMusAd";
            this.gridColumnSipMusAd.Visible = true;
            this.gridColumnSipMusAd.VisibleIndex = 6;
            // 
            // gridColumnSipMusSoyad
            // 
            this.gridColumnSipMusSoyad.Caption = "Musteri Soyad";
            this.gridColumnSipMusSoyad.FieldName = "MusSoyad";
            this.gridColumnSipMusSoyad.Name = "gridColumnSipMusSoyad";
            this.gridColumnSipMusSoyad.Visible = true;
            this.gridColumnSipMusSoyad.VisibleIndex = 7;
            // 
            // gridColumnSipMusAdres
            // 
            this.gridColumnSipMusAdres.Caption = "Musteri Adres";
            this.gridColumnSipMusAdres.FieldName = "MusAdres";
            this.gridColumnSipMusAdres.Name = "gridColumnSipMusAdres";
            this.gridColumnSipMusAdres.Visible = true;
            this.gridColumnSipMusAdres.VisibleIndex = 8;
            // 
            // tabAUrunler
            // 
            this.tabAUrunler.Controls.Add(this.btnResimEkle);
            this.tabAUrunler.Controls.Add(this.btnResimKaydet);
            this.tabAUrunler.Controls.Add(this.txtbUriID);
            this.tabAUrunler.Controls.Add(this.gcUrEkle);
            this.tabAUrunler.Controls.Add(this.btnUrSil);
            this.tabAUrunler.Controls.Add(this.btnUrGunc);
            this.tabAUrunler.Controls.Add(this.btnUrYeni);
            this.tabAUrunler.Controls.Add(this.panel4);
            this.tabAUrunler.Controls.Add(this.panel3);
            this.tabAUrunler.Controls.Add(this.panel2);
            this.tabAUrunler.Controls.Add(this.picbUrunResim);
            this.tabAUrunler.Controls.Add(this.txtbUrAciklama);
            this.tabAUrunler.Controls.Add(this.txtbUrStok);
            this.tabAUrunler.Controls.Add(this.txtbUrAgirlik);
            this.tabAUrunler.Controls.Add(this.txtbUrVergi);
            this.tabAUrunler.Controls.Add(this.txtbUrFiyat);
            this.tabAUrunler.Controls.Add(this.txtbUrAd);
            this.tabAUrunler.Controls.Add(this.lblUrunAciklama);
            this.tabAUrunler.Controls.Add(this.lblUrunStok);
            this.tabAUrunler.Controls.Add(this.lblUrAgirlik);
            this.tabAUrunler.Controls.Add(this.lblUrVergiTip);
            this.tabAUrunler.Controls.Add(this.lblUrunFiyat);
            this.tabAUrunler.Controls.Add(this.panel1);
            this.tabAUrunler.Controls.Add(this.lblUrBilgi);
            this.tabAUrunler.Controls.Add(this.lblUrunAd);
            this.tabAUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabAUrunler.Name = "tabAUrunler";
            this.tabAUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabAUrunler.Size = new System.Drawing.Size(937, 404);
            this.tabAUrunler.TabIndex = 1;
            this.tabAUrunler.Text = "Urunler";
            this.tabAUrunler.UseVisualStyleBackColor = true;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.Location = new System.Drawing.Point(674, 60);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(60, 48);
            this.btnResimEkle.TabIndex = 26;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnResimKaydet
            // 
            this.btnResimKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnResimKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimKaydet.Location = new System.Drawing.Point(674, 114);
            this.btnResimKaydet.Name = "btnResimKaydet";
            this.btnResimKaydet.Size = new System.Drawing.Size(60, 48);
            this.btnResimKaydet.TabIndex = 19;
            this.btnResimKaydet.Text = "Resim Degistir";
            this.btnResimKaydet.UseVisualStyleBackColor = false;
            this.btnResimKaydet.Click += new System.EventHandler(this.btnResimKaydet_Click);
            // 
            // txtbUriID
            // 
            this.txtbUriID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUriID.Location = new System.Drawing.Point(903, 93);
            this.txtbUriID.Name = "txtbUriID";
            this.txtbUriID.PasswordChar = ' ';
            this.txtbUriID.ReadOnly = true;
            this.txtbUriID.Size = new System.Drawing.Size(10, 13);
            this.txtbUriID.TabIndex = 25;
            this.txtbUriID.Visible = false;
            // 
            // gcUrEkle
            // 
            this.gcUrEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUrEkle.Location = new System.Drawing.Point(7, 197);
            this.gcUrEkle.MainView = this.gcUrEkle1;
            this.gcUrEkle.Name = "gcUrEkle";
            this.gcUrEkle.Size = new System.Drawing.Size(921, 204);
            this.gcUrEkle.TabIndex = 24;
            this.gcUrEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcUrEkle1});
            this.gcUrEkle.DoubleClick += new System.EventHandler(this.gcUrEkle_DoubleClick);
            // 
            // gcUrEkle1
            // 
            this.gcUrEkle1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUrunID,
            this.gridColumnUrunAd,
            this.gridColumnUrunFiyat,
            this.gridColumnUrunVergiTip,
            this.gridColumnUrunAgirlik,
            this.gridColumnUrunStok,
            this.gridColumnUrunAciklama});
            this.gcUrEkle1.GridControl = this.gcUrEkle;
            this.gcUrEkle1.Name = "gcUrEkle1";
            // 
            // gridColumnUrunID
            // 
            this.gridColumnUrunID.Caption = "Urun ID";
            this.gridColumnUrunID.FieldName = "UrunID";
            this.gridColumnUrunID.Name = "gridColumnUrunID";
            this.gridColumnUrunID.Visible = true;
            this.gridColumnUrunID.VisibleIndex = 0;
            // 
            // gridColumnUrunAd
            // 
            this.gridColumnUrunAd.Caption = "Urun Ad";
            this.gridColumnUrunAd.FieldName = "UrunAd";
            this.gridColumnUrunAd.Name = "gridColumnUrunAd";
            this.gridColumnUrunAd.Visible = true;
            this.gridColumnUrunAd.VisibleIndex = 1;
            // 
            // gridColumnUrunFiyat
            // 
            this.gridColumnUrunFiyat.Caption = "Urun Fiyat";
            this.gridColumnUrunFiyat.FieldName = "UrunFiyat";
            this.gridColumnUrunFiyat.Name = "gridColumnUrunFiyat";
            this.gridColumnUrunFiyat.Visible = true;
            this.gridColumnUrunFiyat.VisibleIndex = 2;
            // 
            // gridColumnUrunVergiTip
            // 
            this.gridColumnUrunVergiTip.Caption = "Urun Vergi Tip";
            this.gridColumnUrunVergiTip.FieldName = "UrunVergiTip";
            this.gridColumnUrunVergiTip.Name = "gridColumnUrunVergiTip";
            this.gridColumnUrunVergiTip.Visible = true;
            this.gridColumnUrunVergiTip.VisibleIndex = 3;
            // 
            // gridColumnUrunAgirlik
            // 
            this.gridColumnUrunAgirlik.Caption = "Urun Agirlik";
            this.gridColumnUrunAgirlik.FieldName = "UrunAgirlik";
            this.gridColumnUrunAgirlik.Name = "gridColumnUrunAgirlik";
            this.gridColumnUrunAgirlik.Visible = true;
            this.gridColumnUrunAgirlik.VisibleIndex = 4;
            // 
            // gridColumnUrunStok
            // 
            this.gridColumnUrunStok.Caption = "Urun Stok";
            this.gridColumnUrunStok.FieldName = "UrunStok";
            this.gridColumnUrunStok.Name = "gridColumnUrunStok";
            this.gridColumnUrunStok.Visible = true;
            this.gridColumnUrunStok.VisibleIndex = 5;
            // 
            // gridColumnUrunAciklama
            // 
            this.gridColumnUrunAciklama.Caption = "Urun Aciklama";
            this.gridColumnUrunAciklama.FieldName = "UrunAciklama";
            this.gridColumnUrunAciklama.Name = "gridColumnUrunAciklama";
            this.gridColumnUrunAciklama.Visible = true;
            this.gridColumnUrunAciklama.VisibleIndex = 6;
            // 
            // btnUrSil
            // 
            this.btnUrSil.Location = new System.Drawing.Point(746, 133);
            this.btnUrSil.Name = "btnUrSil";
            this.btnUrSil.Size = new System.Drawing.Size(129, 34);
            this.btnUrSil.TabIndex = 23;
            this.btnUrSil.Text = "Sil";
            this.btnUrSil.UseVisualStyleBackColor = true;
            this.btnUrSil.Click += new System.EventHandler(this.btnUrSil_Click);
            // 
            // btnUrGunc
            // 
            this.btnUrGunc.Location = new System.Drawing.Point(746, 93);
            this.btnUrGunc.Name = "btnUrGunc";
            this.btnUrGunc.Size = new System.Drawing.Size(129, 34);
            this.btnUrGunc.TabIndex = 22;
            this.btnUrGunc.Text = "Guncelle";
            this.btnUrGunc.UseVisualStyleBackColor = true;
            this.btnUrGunc.Click += new System.EventHandler(this.btnUrGunc_Click);
            // 
            // btnUrYeni
            // 
            this.btnUrYeni.Location = new System.Drawing.Point(746, 53);
            this.btnUrYeni.Name = "btnUrYeni";
            this.btnUrYeni.Size = new System.Drawing.Size(129, 34);
            this.btnUrYeni.TabIndex = 21;
            this.btnUrYeni.Text = "Yeni Urun Ekle";
            this.btnUrYeni.UseVisualStyleBackColor = true;
            this.btnUrYeni.Click += new System.EventHandler(this.btnUrYeni_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(739, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 150);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(504, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 150);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(8, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 1);
            this.panel2.TabIndex = 16;
            // 
            // picbUrunResim
            // 
            this.picbUrunResim.Location = new System.Drawing.Point(522, 36);
            this.picbUrunResim.Name = "picbUrunResim";
            this.picbUrunResim.Size = new System.Drawing.Size(146, 148);
            this.picbUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbUrunResim.TabIndex = 15;
            this.picbUrunResim.TabStop = false;
            // 
            // txtbUrAciklama
            // 
            this.txtbUrAciklama.Location = new System.Drawing.Point(125, 164);
            this.txtbUrAciklama.Name = "txtbUrAciklama";
            this.txtbUrAciklama.Size = new System.Drawing.Size(373, 20);
            this.txtbUrAciklama.TabIndex = 13;
            // 
            // txtbUrStok
            // 
            this.txtbUrStok.Location = new System.Drawing.Point(125, 138);
            this.txtbUrStok.Name = "txtbUrStok";
            this.txtbUrStok.Size = new System.Drawing.Size(373, 20);
            this.txtbUrStok.TabIndex = 12;
            // 
            // txtbUrAgirlik
            // 
            this.txtbUrAgirlik.Location = new System.Drawing.Point(125, 112);
            this.txtbUrAgirlik.Name = "txtbUrAgirlik";
            this.txtbUrAgirlik.Size = new System.Drawing.Size(373, 20);
            this.txtbUrAgirlik.TabIndex = 11;
            // 
            // txtbUrVergi
            // 
            this.txtbUrVergi.Location = new System.Drawing.Point(125, 86);
            this.txtbUrVergi.Name = "txtbUrVergi";
            this.txtbUrVergi.Size = new System.Drawing.Size(373, 20);
            this.txtbUrVergi.TabIndex = 10;
            // 
            // txtbUrFiyat
            // 
            this.txtbUrFiyat.Location = new System.Drawing.Point(125, 60);
            this.txtbUrFiyat.Name = "txtbUrFiyat";
            this.txtbUrFiyat.Size = new System.Drawing.Size(373, 20);
            this.txtbUrFiyat.TabIndex = 9;
            // 
            // txtbUrAd
            // 
            this.txtbUrAd.Location = new System.Drawing.Point(125, 34);
            this.txtbUrAd.Name = "txtbUrAd";
            this.txtbUrAd.Size = new System.Drawing.Size(373, 20);
            this.txtbUrAd.TabIndex = 8;
            // 
            // lblUrunAciklama
            // 
            this.lblUrunAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunAciklama.AutoSize = true;
            this.lblUrunAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAciklama.Location = new System.Drawing.Point(4, 166);
            this.lblUrunAciklama.Name = "lblUrunAciklama";
            this.lblUrunAciklama.Size = new System.Drawing.Size(108, 15);
            this.lblUrunAciklama.TabIndex = 7;
            this.lblUrunAciklama.Text = "Urun Aciklama :";
            // 
            // lblUrunStok
            // 
            this.lblUrunStok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunStok.AutoSize = true;
            this.lblUrunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunStok.Location = new System.Drawing.Point(30, 140);
            this.lblUrunStok.Name = "lblUrunStok";
            this.lblUrunStok.Size = new System.Drawing.Size(82, 15);
            this.lblUrunStok.TabIndex = 6;
            this.lblUrunStok.Text = "Urun Stok  :";
            // 
            // lblUrAgirlik
            // 
            this.lblUrAgirlik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrAgirlik.AutoSize = true;
            this.lblUrAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrAgirlik.Location = new System.Drawing.Point(22, 114);
            this.lblUrAgirlik.Name = "lblUrAgirlik";
            this.lblUrAgirlik.Size = new System.Drawing.Size(90, 15);
            this.lblUrAgirlik.TabIndex = 5;
            this.lblUrAgirlik.Text = "Urun Agirlik :";
            // 
            // lblUrVergiTip
            // 
            this.lblUrVergiTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrVergiTip.AutoSize = true;
            this.lblUrVergiTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrVergiTip.Location = new System.Drawing.Point(5, 88);
            this.lblUrVergiTip.Name = "lblUrVergiTip";
            this.lblUrVergiTip.Size = new System.Drawing.Size(107, 15);
            this.lblUrVergiTip.TabIndex = 4;
            this.lblUrVergiTip.Text = "Urun Vergi Tip :";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyat.Location = new System.Drawing.Point(32, 62);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(80, 15);
            this.lblUrunFiyat.TabIndex = 3;
            this.lblUrunFiyat.Text = "Urun Fiyat :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(10, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 1);
            this.panel1.TabIndex = 2;
            // 
            // lblUrBilgi
            // 
            this.lblUrBilgi.AutoSize = true;
            this.lblUrBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrBilgi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUrBilgi.Location = new System.Drawing.Point(6, 3);
            this.lblUrBilgi.Name = "lblUrBilgi";
            this.lblUrBilgi.Size = new System.Drawing.Size(121, 20);
            this.lblUrBilgi.TabIndex = 1;
            this.lblUrBilgi.Text = "Urun Bilgileri :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(46, 36);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(66, 15);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "Urun Ad :";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 497);
            this.Controls.Add(this.tabcAdminAna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGA Express";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabcAdminAna.ResumeLayout(false);
            this.tabASiparisler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmSip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmSip1)).EndInit();
            this.tabAUrunler.ResumeLayout(false);
            this.tabAUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrEkle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbUrunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcAdminAna;
        private System.Windows.Forms.TabPage tabASiparisler;
        private System.Windows.Forms.TabPage tabAUrunler;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrBilgi;
        private System.Windows.Forms.Button btnResimKaydet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picbUrunResim;
        private System.Windows.Forms.TextBox txtbUrAciklama;
        private System.Windows.Forms.TextBox txtbUrStok;
        private System.Windows.Forms.TextBox txtbUrAgirlik;
        private System.Windows.Forms.TextBox txtbUrVergi;
        private System.Windows.Forms.TextBox txtbUrFiyat;
        private System.Windows.Forms.TextBox txtbUrAd;
        private System.Windows.Forms.Label lblUrunAciklama;
        private System.Windows.Forms.Label lblUrunStok;
        private System.Windows.Forms.Label lblUrAgirlik;
        private System.Windows.Forms.Label lblUrVergiTip;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUrSil;
        private System.Windows.Forms.Button btnUrGunc;
        private System.Windows.Forms.Button btnUrYeni;
        private DevExpress.XtraGrid.GridControl gcUrEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gcUrEkle1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunVergiTip;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunAgirlik;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunStok;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunAciklama;
        private DevExpress.XtraGrid.GridControl gcAdmSip;
        private DevExpress.XtraGrid.Views.Grid.GridView gcAdmSip1;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipMusID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunAgirlik;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipMusAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipMusSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipMusAdres;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.TextBox txtbUriID;
        private System.Windows.Forms.Button btnResimEkle;
    }
}