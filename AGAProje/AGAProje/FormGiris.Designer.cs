
namespace AGAProje
{
    partial class formGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.matbtnMusYon = new MaterialSkin.Controls.MaterialFlatButton();
            this.matbtnAdYon = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbAGALogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAGALogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(299, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 110);
            this.panel1.TabIndex = 1;
            // 
            // matbtnMusYon
            // 
            this.matbtnMusYon.AutoSize = true;
            this.matbtnMusYon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnMusYon.BackColor = System.Drawing.SystemColors.Control;
            this.matbtnMusYon.Depth = 0;
            this.matbtnMusYon.Icon = null;
            this.matbtnMusYon.Location = new System.Drawing.Point(3, 0);
            this.matbtnMusYon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnMusYon.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnMusYon.Name = "matbtnMusYon";
            this.matbtnMusYon.Primary = false;
            this.matbtnMusYon.Size = new System.Drawing.Size(120, 36);
            this.matbtnMusYon.TabIndex = 2;
            this.matbtnMusYon.Text = "Musteri Girisi ";
            this.matbtnMusYon.UseVisualStyleBackColor = false;
            this.matbtnMusYon.Click += new System.EventHandler(this.matbtnMusYon_Click);
            // 
            // matbtnAdYon
            // 
            this.matbtnAdYon.AutoSize = true;
            this.matbtnAdYon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnAdYon.BackColor = System.Drawing.SystemColors.Control;
            this.matbtnAdYon.Depth = 0;
            this.matbtnAdYon.Icon = null;
            this.matbtnAdYon.Location = new System.Drawing.Point(0, 0);
            this.matbtnAdYon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matbtnAdYon.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnAdYon.Name = "matbtnAdYon";
            this.matbtnAdYon.Primary = false;
            this.matbtnAdYon.Size = new System.Drawing.Size(123, 36);
            this.matbtnAdYon.TabIndex = 3;
            this.matbtnAdYon.Text = "Yonetici Girisi";
            this.matbtnAdYon.UseVisualStyleBackColor = false;
            this.matbtnAdYon.Click += new System.EventHandler(this.matbtnAdYon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.matbtnAdYon);
            this.panel2.Location = new System.Drawing.Point(390, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 36);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.matbtnMusYon);
            this.panel3.Location = new System.Drawing.Point(90, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 36);
            this.panel3.TabIndex = 5;
            // 
            // picbAGALogo
            // 
            this.picbAGALogo.Image = global::AGAProje.Properties.Resources.AGAlogo1;
            this.picbAGALogo.Location = new System.Drawing.Point(210, 68);
            this.picbAGALogo.Name = "picbAGALogo";
            this.picbAGALogo.Size = new System.Drawing.Size(176, 127);
            this.picbAGALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbAGALogo.TabIndex = 0;
            this.picbAGALogo.TabStop = false;
            // 
            // formGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picbAGALogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGA Express";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAGALogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbAGALogo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton matbtnMusYon;
        private MaterialSkin.Controls.MaterialFlatButton matbtnAdYon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

