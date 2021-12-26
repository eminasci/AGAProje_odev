
namespace AGAProje
{
    partial class FormMusGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusGiris));
            this.lblMusteriGiris = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matbtnGirisYap = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtbSifre = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.matlblSifre = new MaterialSkin.Controls.MaterialLabel();
            this.matlblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.matbtnUyeOl = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriGiris
            // 
            this.lblMusteriGiris.AutoSize = true;
            this.lblMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriGiris.Location = new System.Drawing.Point(161, 252);
            this.lblMusteriGiris.Name = "lblMusteriGiris";
            this.lblMusteriGiris.Size = new System.Drawing.Size(159, 20);
            this.lblMusteriGiris.TabIndex = 1;
            this.lblMusteriGiris.Text = "Lutfen Giris Yapınız...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.matbtnGirisYap);
            this.panel1.Controls.Add(this.txtbSifre);
            this.panel1.Controls.Add(this.txtbEmail);
            this.panel1.Controls.Add(this.matlblSifre);
            this.panel1.Controls.Add(this.matlblEmail);
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 115);
            this.panel1.TabIndex = 2;
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
            // txtbSifre
            // 
            this.txtbSifre.Location = new System.Drawing.Point(81, 59);
            this.txtbSifre.Name = "txtbSifre";
            this.txtbSifre.PasswordChar = '*';
            this.txtbSifre.Size = new System.Drawing.Size(239, 20);
            this.txtbSifre.TabIndex = 3;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(81, 26);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(239, 20);
            this.txtbEmail.TabIndex = 2;
            // 
            // matlblSifre
            // 
            this.matlblSifre.AutoSize = true;
            this.matlblSifre.Depth = 0;
            this.matlblSifre.Font = new System.Drawing.Font("Roboto", 11F);
            this.matlblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matlblSifre.Location = new System.Drawing.Point(12, 58);
            this.matlblSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.matlblSifre.Name = "matlblSifre";
            this.matlblSifre.Size = new System.Drawing.Size(52, 19);
            this.matlblSifre.TabIndex = 1;
            this.matlblSifre.Text = "Sifre : ";
            // 
            // matlblEmail
            // 
            this.matlblEmail.AutoSize = true;
            this.matlblEmail.Depth = 0;
            this.matlblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.matlblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matlblEmail.Location = new System.Drawing.Point(12, 25);
            this.matlblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.matlblEmail.Name = "matlblEmail";
            this.matlblEmail.Size = new System.Drawing.Size(63, 19);
            this.matlblEmail.TabIndex = 0;
            this.matlblEmail.Text = "E-mail : ";
            // 
            // matbtnUyeOl
            // 
            this.matbtnUyeOl.AutoSize = true;
            this.matbtnUyeOl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnUyeOl.Depth = 0;
            this.matbtnUyeOl.ForeColor = System.Drawing.Color.OrangeRed;
            this.matbtnUyeOl.Icon = null;
            this.matbtnUyeOl.Location = new System.Drawing.Point(0, 0);
            this.matbtnUyeOl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnUyeOl.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnUyeOl.Name = "matbtnUyeOl";
            this.matbtnUyeOl.Primary = false;
            this.matbtnUyeOl.Size = new System.Drawing.Size(66, 36);
            this.matbtnUyeOl.TabIndex = 3;
            this.matbtnUyeOl.Text = "Uye Ol";
            this.matbtnUyeOl.UseVisualStyleBackColor = true;
            this.matbtnUyeOl.Click += new System.EventHandler(this.matbtnUyeOl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.matbtnUyeOl);
            this.panel2.Location = new System.Drawing.Point(204, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 36);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AGAProje.Properties.Resources.CustomerLogo11;
            this.pictureBox1.Location = new System.Drawing.Point(167, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMusGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMusteriGiris);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMusGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGA Express";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMusteriGiris;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton matbtnGirisYap;
        private System.Windows.Forms.TextBox txtbSifre;
        private System.Windows.Forms.TextBox txtbEmail;
        private MaterialSkin.Controls.MaterialLabel matlblSifre;
        private MaterialSkin.Controls.MaterialLabel matlblEmail;
        private MaterialSkin.Controls.MaterialFlatButton matbtnUyeOl;
        private System.Windows.Forms.Panel panel2;
    }
}