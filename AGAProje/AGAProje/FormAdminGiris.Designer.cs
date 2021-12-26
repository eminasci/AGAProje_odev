
namespace AGAProje
{
    partial class FormAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.matbtnGirisYap = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtbAdSifre = new System.Windows.Forms.TextBox();
            this.txtbAdAd = new System.Windows.Forms.TextBox();
            this.matlblAdSifre = new MaterialSkin.Controls.MaterialLabel();
            this.matlblAd = new MaterialSkin.Controls.MaterialLabel();
            this.lblAAdminGiris = new System.Windows.Forms.Label();
            this.picbAdmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.matbtnGirisYap);
            this.panel1.Controls.Add(this.txtbAdSifre);
            this.panel1.Controls.Add(this.txtbAdAd);
            this.panel1.Controls.Add(this.matlblAdSifre);
            this.panel1.Controls.Add(this.matlblAd);
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 115);
            this.panel1.TabIndex = 6;
            // 
            // matbtnGirisYap
            // 
            this.matbtnGirisYap.AutoSize = true;
            this.matbtnGirisYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnGirisYap.Depth = 0;
            this.matbtnGirisYap.Icon = null;
            this.matbtnGirisYap.Location = new System.Drawing.Point(372, 36);
            this.matbtnGirisYap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnGirisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnGirisYap.Name = "matbtnGirisYap";
            this.matbtnGirisYap.Primary = false;
            this.matbtnGirisYap.Size = new System.Drawing.Size(85, 36);
            this.matbtnGirisYap.TabIndex = 4;
            this.matbtnGirisYap.Text = "Giris Yap";
            this.matbtnGirisYap.UseVisualStyleBackColor = true;
            this.matbtnGirisYap.Click += new System.EventHandler(this.matbtnGirisYap_Click);
            // 
            // txtbAdSifre
            // 
            this.txtbAdSifre.Location = new System.Drawing.Point(81, 59);
            this.txtbAdSifre.Name = "txtbAdSifre";
            this.txtbAdSifre.PasswordChar = '*';
            this.txtbAdSifre.Size = new System.Drawing.Size(239, 20);
            this.txtbAdSifre.TabIndex = 3;
            // 
            // txtbAdAd
            // 
            this.txtbAdAd.Location = new System.Drawing.Point(81, 26);
            this.txtbAdAd.Name = "txtbAdAd";
            this.txtbAdAd.Size = new System.Drawing.Size(239, 20);
            this.txtbAdAd.TabIndex = 2;
            // 
            // matlblAdSifre
            // 
            this.matlblAdSifre.AutoSize = true;
            this.matlblAdSifre.Depth = 0;
            this.matlblAdSifre.Font = new System.Drawing.Font("Roboto", 11F);
            this.matlblAdSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matlblAdSifre.Location = new System.Drawing.Point(12, 58);
            this.matlblAdSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.matlblAdSifre.Name = "matlblAdSifre";
            this.matlblAdSifre.Size = new System.Drawing.Size(52, 19);
            this.matlblAdSifre.TabIndex = 1;
            this.matlblAdSifre.Text = "Sifre : ";
            // 
            // matlblAd
            // 
            this.matlblAd.AutoSize = true;
            this.matlblAd.Depth = 0;
            this.matlblAd.Font = new System.Drawing.Font("Roboto", 11F);
            this.matlblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matlblAd.Location = new System.Drawing.Point(12, 25);
            this.matlblAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.matlblAd.Name = "matlblAd";
            this.matlblAd.Size = new System.Drawing.Size(39, 19);
            this.matlblAd.TabIndex = 0;
            this.matlblAd.Text = "Ad : ";
            // 
            // lblAAdminGiris
            // 
            this.lblAAdminGiris.AutoSize = true;
            this.lblAAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAAdminGiris.Location = new System.Drawing.Point(161, 252);
            this.lblAAdminGiris.Name = "lblAAdminGiris";
            this.lblAAdminGiris.Size = new System.Drawing.Size(159, 20);
            this.lblAAdminGiris.TabIndex = 5;
            this.lblAAdminGiris.Text = "Lutfen Giris Yapınız...";
            // 
            // picbAdmin
            // 
            this.picbAdmin.Image = global::AGAProje.Properties.Resources.AdminLogo11;
            this.picbAdmin.Location = new System.Drawing.Point(167, 67);
            this.picbAdmin.Name = "picbAdmin";
            this.picbAdmin.Size = new System.Drawing.Size(150, 169);
            this.picbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbAdmin.TabIndex = 4;
            this.picbAdmin.TabStop = false;
            // 
            // FormAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAAdminGiris);
            this.Controls.Add(this.picbAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGA Express";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton matbtnGirisYap;
        private System.Windows.Forms.TextBox txtbAdSifre;
        private System.Windows.Forms.TextBox txtbAdAd;
        private MaterialSkin.Controls.MaterialLabel matlblAdSifre;
        private MaterialSkin.Controls.MaterialLabel matlblAd;
        private System.Windows.Forms.Label lblAAdminGiris;
        private System.Windows.Forms.PictureBox picbAdmin;
    }
}