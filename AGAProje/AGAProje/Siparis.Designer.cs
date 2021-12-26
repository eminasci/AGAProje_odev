
namespace AGAProje
{
    partial class Siparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparis));
            this.tabpSiparislerim = new System.Windows.Forms.TabPage();
            this.gcMusSip = new DevExpress.XtraGrid.GridControl();
            this.gcMusSip1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSipUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipUrunFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSipMusAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSiparislerim = new System.Windows.Forms.Label();
            this.tabpUrunler = new System.Windows.Forms.TabPage();
            this.txtSptAgırlık = new System.Windows.Forms.TextBox();
            this.lblSepetAg = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnSipOnay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbToplamF = new System.Windows.Forms.TextBox();
            this.gcMusUrun = new DevExpress.XtraGrid.GridControl();
            this.gcMusUrun1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUrunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunAgirlik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFiyatToplam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSepet = new System.Windows.Forms.Label();
            this.tabconMusAna = new System.Windows.Forms.TabControl();
            this.tabpSiparislerim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusSip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusSip1)).BeginInit();
            this.tabpUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusUrun1)).BeginInit();
            this.tabconMusAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpSiparislerim
            // 
            this.tabpSiparislerim.Controls.Add(this.gcMusSip);
            this.tabpSiparislerim.Controls.Add(this.panel4);
            this.tabpSiparislerim.Controls.Add(this.panel3);
            this.tabpSiparislerim.Controls.Add(this.lblSiparislerim);
            this.tabpSiparislerim.ForeColor = System.Drawing.Color.OrangeRed;
            this.tabpSiparislerim.Location = new System.Drawing.Point(4, 22);
            this.tabpSiparislerim.Name = "tabpSiparislerim";
            this.tabpSiparislerim.Size = new System.Drawing.Size(913, 407);
            this.tabpSiparislerim.TabIndex = 1;
            this.tabpSiparislerim.Text = "Siparislerim";
            this.tabpSiparislerim.UseVisualStyleBackColor = true;
            // 
            // gcMusSip
            // 
            this.gcMusSip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMusSip.Location = new System.Drawing.Point(12, 30);
            this.gcMusSip.MainView = this.gcMusSip1;
            this.gcMusSip.Name = "gcMusSip";
            this.gcMusSip.Size = new System.Drawing.Size(889, 367);
            this.gcMusSip.TabIndex = 6;
            this.gcMusSip.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcMusSip1});
            // 
            // gcMusSip1
            // 
            this.gcMusSip1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSipUrunID,
            this.gridColumnSipUrunAd,
            this.gridColumnSipUrunMiktar,
            this.gridColumnSipUrunFiyat,
            this.gridColumnSipMusAdres});
            this.gcMusSip1.GridControl = this.gcMusSip;
            this.gcMusSip1.Name = "gcMusSip1";
            // 
            // gridColumnSipUrunID
            // 
            this.gridColumnSipUrunID.Caption = "Urun ID";
            this.gridColumnSipUrunID.FieldName = "UrunID";
            this.gridColumnSipUrunID.Name = "gridColumnSipUrunID";
            this.gridColumnSipUrunID.Visible = true;
            this.gridColumnSipUrunID.VisibleIndex = 0;
            // 
            // gridColumnSipUrunAd
            // 
            this.gridColumnSipUrunAd.Caption = "Urun Ad";
            this.gridColumnSipUrunAd.FieldName = "UrunAd";
            this.gridColumnSipUrunAd.Name = "gridColumnSipUrunAd";
            this.gridColumnSipUrunAd.Visible = true;
            this.gridColumnSipUrunAd.VisibleIndex = 1;
            // 
            // gridColumnSipUrunMiktar
            // 
            this.gridColumnSipUrunMiktar.Caption = "Urun Miktar";
            this.gridColumnSipUrunMiktar.FieldName = "UrunMiktar";
            this.gridColumnSipUrunMiktar.Name = "gridColumnSipUrunMiktar";
            this.gridColumnSipUrunMiktar.Visible = true;
            this.gridColumnSipUrunMiktar.VisibleIndex = 2;
            // 
            // gridColumnSipUrunFiyat
            // 
            this.gridColumnSipUrunFiyat.Caption = "Urun Fiyat";
            this.gridColumnSipUrunFiyat.FieldName = "UrunFiyat";
            this.gridColumnSipUrunFiyat.Name = "gridColumnSipUrunFiyat";
            this.gridColumnSipUrunFiyat.Visible = true;
            this.gridColumnSipUrunFiyat.VisibleIndex = 3;
            // 
            // gridColumnSipMusAdres
            // 
            this.gridColumnSipMusAdres.Caption = "Teslim Adres";
            this.gridColumnSipMusAdres.FieldName = "MusAdres";
            this.gridColumnSipMusAdres.Name = "gridColumnSipMusAdres";
            this.gridColumnSipMusAdres.Visible = true;
            this.gridColumnSipMusAdres.VisibleIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(16, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(890, 1);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(12, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 1);
            this.panel3.TabIndex = 4;
            // 
            // lblSiparislerim
            // 
            this.lblSiparislerim.AutoSize = true;
            this.lblSiparislerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparislerim.Location = new System.Drawing.Point(8, 0);
            this.lblSiparislerim.Name = "lblSiparislerim";
            this.lblSiparislerim.Size = new System.Drawing.Size(131, 24);
            this.lblSiparislerim.TabIndex = 3;
            this.lblSiparislerim.Text = "Siparislerim :";
            // 
            // tabpUrunler
            // 
            this.tabpUrunler.BackColor = System.Drawing.Color.Transparent;
            this.tabpUrunler.Controls.Add(this.txtSptAgırlık);
            this.tabpUrunler.Controls.Add(this.lblSepetAg);
            this.tabpUrunler.Controls.Add(this.dtpTarih);
            this.tabpUrunler.Controls.Add(this.btnSipOnay);
            this.tabpUrunler.Controls.Add(this.panel5);
            this.tabpUrunler.Controls.Add(this.panel1);
            this.tabpUrunler.Controls.Add(this.txtbToplamF);
            this.tabpUrunler.Controls.Add(this.gcMusUrun);
            this.tabpUrunler.Controls.Add(this.lblFiyatToplam);
            this.tabpUrunler.Controls.Add(this.panel2);
            this.tabpUrunler.Controls.Add(this.lblSepet);
            this.tabpUrunler.ForeColor = System.Drawing.Color.OrangeRed;
            this.tabpUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabpUrunler.Name = "tabpUrunler";
            this.tabpUrunler.Size = new System.Drawing.Size(913, 407);
            this.tabpUrunler.TabIndex = 0;
            this.tabpUrunler.Text = "Urunler";
            // 
            // txtSptAgırlık
            // 
            this.txtSptAgırlık.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSptAgırlık.Location = new System.Drawing.Point(805, 326);
            this.txtSptAgırlık.Name = "txtSptAgırlık";
            this.txtSptAgırlık.Size = new System.Drawing.Size(91, 20);
            this.txtSptAgırlık.TabIndex = 14;
            // 
            // lblSepetAg
            // 
            this.lblSepetAg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSepetAg.AutoSize = true;
            this.lblSepetAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSepetAg.Location = new System.Drawing.Point(703, 329);
            this.lblSepetAg.Name = "lblSepetAg";
            this.lblSepetAg.Size = new System.Drawing.Size(100, 15);
            this.lblSepetAg.TabIndex = 13;
            this.lblSepetAg.Text = "Sepet Agırlık : ";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(729, 72);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(106, 20);
            this.dtpTarih.TabIndex = 12;
            this.dtpTarih.Visible = false;
            // 
            // btnSipOnay
            // 
            this.btnSipOnay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSipOnay.Location = new System.Drawing.Point(744, 361);
            this.btnSipOnay.Name = "btnSipOnay";
            this.btnSipOnay.Size = new System.Drawing.Size(115, 29);
            this.btnSipOnay.TabIndex = 11;
            this.btnSipOnay.Text = "Sepeti Onayla";
            this.btnSipOnay.UseVisualStyleBackColor = true;
            this.btnSipOnay.Click += new System.EventHandler(this.btnSipOnay_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Location = new System.Drawing.Point(706, 354);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 1);
            this.panel5.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(706, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 1);
            this.panel1.TabIndex = 9;
            // 
            // txtbToplamF
            // 
            this.txtbToplamF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbToplamF.Location = new System.Drawing.Point(805, 300);
            this.txtbToplamF.Name = "txtbToplamF";
            this.txtbToplamF.Size = new System.Drawing.Size(91, 20);
            this.txtbToplamF.TabIndex = 8;
            // 
            // gcMusUrun
            // 
            this.gcMusUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcMusUrun.Location = new System.Drawing.Point(3, 3);
            this.gcMusUrun.MainView = this.gcMusUrun1;
            this.gcMusUrun.Name = "gcMusUrun";
            this.gcMusUrun.Size = new System.Drawing.Size(694, 401);
            this.gcMusUrun.TabIndex = 6;
            this.gcMusUrun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcMusUrun1});
            this.gcMusUrun.DoubleClick += new System.EventHandler(this.gcMusUrun_DoubleClick);
            // 
            // gcMusUrun1
            // 
            this.gcMusUrun1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUrunAd,
            this.gridColumnUrunFiyat,
            this.gridColumnUrunAgirlik,
            this.gridColumnUrunAciklama});
            this.gcMusUrun1.GridControl = this.gcMusUrun;
            this.gcMusUrun1.Name = "gcMusUrun1";
            // 
            // gridColumnUrunAd
            // 
            this.gridColumnUrunAd.Caption = "Urun Ad";
            this.gridColumnUrunAd.FieldName = "UrunAd";
            this.gridColumnUrunAd.Name = "gridColumnUrunAd";
            this.gridColumnUrunAd.Visible = true;
            this.gridColumnUrunAd.VisibleIndex = 0;
            // 
            // gridColumnUrunFiyat
            // 
            this.gridColumnUrunFiyat.Caption = "Urun Fiyat";
            this.gridColumnUrunFiyat.FieldName = "UrunFiyat";
            this.gridColumnUrunFiyat.Name = "gridColumnUrunFiyat";
            this.gridColumnUrunFiyat.Visible = true;
            this.gridColumnUrunFiyat.VisibleIndex = 1;
            // 
            // gridColumnUrunAgirlik
            // 
            this.gridColumnUrunAgirlik.Caption = "Urun Birim Agirlik";
            this.gridColumnUrunAgirlik.FieldName = "UrunAgirlik";
            this.gridColumnUrunAgirlik.Name = "gridColumnUrunAgirlik";
            this.gridColumnUrunAgirlik.Visible = true;
            this.gridColumnUrunAgirlik.VisibleIndex = 2;
            // 
            // gridColumnUrunAciklama
            // 
            this.gridColumnUrunAciklama.Caption = "Urun Aciklama";
            this.gridColumnUrunAciklama.FieldName = "UrunAciklama";
            this.gridColumnUrunAciklama.Name = "gridColumnUrunAciklama";
            this.gridColumnUrunAciklama.Visible = true;
            this.gridColumnUrunAciklama.VisibleIndex = 3;
            // 
            // lblFiyatToplam
            // 
            this.lblFiyatToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiyatToplam.AutoSize = true;
            this.lblFiyatToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatToplam.Location = new System.Drawing.Point(703, 301);
            this.lblFiyatToplam.Name = "lblFiyatToplam";
            this.lblFiyatToplam.Size = new System.Drawing.Size(101, 15);
            this.lblFiyatToplam.TabIndex = 5;
            this.lblFiyatToplam.Text = "Toplam Fiyat : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(706, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 1);
            this.panel2.TabIndex = 3;
            // 
            // lblSepet
            // 
            this.lblSepet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSepet.AutoSize = true;
            this.lblSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSepet.Location = new System.Drawing.Point(702, 3);
            this.lblSepet.Name = "lblSepet";
            this.lblSepet.Size = new System.Drawing.Size(98, 24);
            this.lblSepet.TabIndex = 1;
            this.lblSepet.Text = "Sepetim :";
            // 
            // tabconMusAna
            // 
            this.tabconMusAna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabconMusAna.Controls.Add(this.tabpUrunler);
            this.tabconMusAna.Controls.Add(this.tabpSiparislerim);
            this.tabconMusAna.Location = new System.Drawing.Point(0, 64);
            this.tabconMusAna.Name = "tabconMusAna";
            this.tabconMusAna.SelectedIndex = 0;
            this.tabconMusAna.Size = new System.Drawing.Size(921, 433);
            this.tabconMusAna.TabIndex = 0;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 498);
            this.Controls.Add(this.tabconMusAna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Siparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGA Express";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabpSiparislerim.ResumeLayout(false);
            this.tabpSiparislerim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusSip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusSip1)).EndInit();
            this.tabpUrunler.ResumeLayout(false);
            this.tabpUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMusUrun1)).EndInit();
            this.tabconMusAna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpSiparislerim;
        private System.Windows.Forms.TabPage tabpUrunler;
        private System.Windows.Forms.Label lblFiyatToplam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSepet;
        private System.Windows.Forms.TabControl tabconMusAna;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSiparislerim;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gcMusSip;
        private DevExpress.XtraGrid.Views.Grid.GridView gcMusSip1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipUrunFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSipMusAdres;
        private DevExpress.XtraGrid.GridControl gcMusUrun;
        private DevExpress.XtraGrid.Views.Grid.GridView gcMusUrun1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunAd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunAciklama;
        private System.Windows.Forms.TextBox txtbToplamF;
        private System.Windows.Forms.Button btnSipOnay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtSptAgırlık;
        private System.Windows.Forms.Label lblSepetAg;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunAgirlik;
    }
}