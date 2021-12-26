
namespace AGAProje
{
    partial class FormOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdeme));
            this.tcOdeme = new System.Windows.Forms.TabControl();
            this.tpKredi = new System.Windows.Forms.TabPage();
            this.btnOdOnayKK = new System.Windows.Forms.Button();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.txtbKartNo = new System.Windows.Forms.TextBox();
            this.lblKartTipi = new System.Windows.Forms.Label();
            this.lblKartSonK = new System.Windows.Forms.Label();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.tpNakit = new System.Windows.Forms.TabPage();
            this.btnOdOnayN = new System.Windows.Forms.Button();
            this.lblKO = new System.Windows.Forms.Label();
            this.tpCek = new System.Windows.Forms.TabPage();
            this.btnOdOnayC = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCekIsim = new System.Windows.Forms.Label();
            this.lblCekID = new System.Windows.Forms.Label();
            this.tcOdeme.SuspendLayout();
            this.tpKredi.SuspendLayout();
            this.tpNakit.SuspendLayout();
            this.tpCek.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcOdeme
            // 
            this.tcOdeme.Controls.Add(this.tpKredi);
            this.tcOdeme.Controls.Add(this.tpNakit);
            this.tcOdeme.Controls.Add(this.tpCek);
            this.tcOdeme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcOdeme.Location = new System.Drawing.Point(0, 69);
            this.tcOdeme.Name = "tcOdeme";
            this.tcOdeme.SelectedIndex = 0;
            this.tcOdeme.Size = new System.Drawing.Size(488, 125);
            this.tcOdeme.TabIndex = 0;
            // 
            // tpKredi
            // 
            this.tpKredi.Controls.Add(this.btnOdOnayKK);
            this.tpKredi.Controls.Add(this.cbTip);
            this.tpKredi.Controls.Add(this.cbYil);
            this.tpKredi.Controls.Add(this.cbAy);
            this.tpKredi.Controls.Add(this.txtbKartNo);
            this.tpKredi.Controls.Add(this.lblKartTipi);
            this.tpKredi.Controls.Add(this.lblKartSonK);
            this.tpKredi.Controls.Add(this.lblKartNo);
            this.tpKredi.Location = new System.Drawing.Point(4, 22);
            this.tpKredi.Name = "tpKredi";
            this.tpKredi.Padding = new System.Windows.Forms.Padding(3);
            this.tpKredi.Size = new System.Drawing.Size(480, 99);
            this.tpKredi.TabIndex = 0;
            this.tpKredi.Text = "Kredi Kartı";
            this.tpKredi.UseVisualStyleBackColor = true;
            // 
            // btnOdOnayKK
            // 
            this.btnOdOnayKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdOnayKK.Location = new System.Drawing.Point(398, 24);
            this.btnOdOnayKK.Name = "btnOdOnayKK";
            this.btnOdOnayKK.Size = new System.Drawing.Size(74, 47);
            this.btnOdOnayKK.TabIndex = 7;
            this.btnOdOnayKK.Text = "Odemeyi Onayla";
            this.btnOdOnayKK.UseVisualStyleBackColor = true;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "VISA ",
            "MASTERCARD",
            "AMERICAN EX",
            "CIFTLIKBANK"});
            this.cbTip.Location = new System.Drawing.Point(171, 67);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(66, 21);
            this.cbTip.TabIndex = 6;
            this.cbTip.Text = "Kart Tip";
            // 
            // cbYil
            // 
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbYil.Location = new System.Drawing.Point(232, 38);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(55, 21);
            this.cbYil.TabIndex = 5;
            this.cbYil.Text = "YIL";
            // 
            // cbAy
            // 
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbAy.Location = new System.Drawing.Point(171, 38);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(55, 21);
            this.cbAy.TabIndex = 4;
            this.cbAy.Text = "AY";
            // 
            // txtbKartNo
            // 
            this.txtbKartNo.Location = new System.Drawing.Point(171, 11);
            this.txtbKartNo.Name = "txtbKartNo";
            this.txtbKartNo.Size = new System.Drawing.Size(192, 20);
            this.txtbKartNo.TabIndex = 3;
            // 
            // lblKartTipi
            // 
            this.lblKartTipi.AutoSize = true;
            this.lblKartTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartTipi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKartTipi.Location = new System.Drawing.Point(44, 68);
            this.lblKartTipi.Name = "lblKartTipi";
            this.lblKartTipi.Size = new System.Drawing.Size(118, 16);
            this.lblKartTipi.TabIndex = 2;
            this.lblKartTipi.Text = "Kredi Kartı Tipi :";
            // 
            // lblKartSonK
            // 
            this.lblKartSonK.AutoSize = true;
            this.lblKartSonK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartSonK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKartSonK.Location = new System.Drawing.Point(8, 41);
            this.lblKartSonK.Name = "lblKartSonK";
            this.lblKartSonK.Size = new System.Drawing.Size(154, 16);
            this.lblKartSonK.TabIndex = 1;
            this.lblKartSonK.Text = "Kredi Kartı SK.Tarihi :";
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKartNo.Location = new System.Drawing.Point(8, 13);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(157, 16);
            this.lblKartNo.TabIndex = 0;
            this.lblKartNo.Text = "Kredi Kartı Numarası :";
            // 
            // tpNakit
            // 
            this.tpNakit.Controls.Add(this.btnOdOnayN);
            this.tpNakit.Controls.Add(this.lblKO);
            this.tpNakit.Location = new System.Drawing.Point(4, 22);
            this.tpNakit.Name = "tpNakit";
            this.tpNakit.Padding = new System.Windows.Forms.Padding(3);
            this.tpNakit.Size = new System.Drawing.Size(480, 99);
            this.tpNakit.TabIndex = 1;
            this.tpNakit.Text = "Nakit";
            this.tpNakit.UseVisualStyleBackColor = true;
            // 
            // btnOdOnayN
            // 
            this.btnOdOnayN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdOnayN.Location = new System.Drawing.Point(147, 56);
            this.btnOdOnayN.Name = "btnOdOnayN";
            this.btnOdOnayN.Size = new System.Drawing.Size(176, 24);
            this.btnOdOnayN.TabIndex = 8;
            this.btnOdOnayN.Text = "Odemeyi Onayla";
            this.btnOdOnayN.UseVisualStyleBackColor = true;
            // 
            // lblKO
            // 
            this.lblKO.AutoSize = true;
            this.lblKO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKO.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblKO.Location = new System.Drawing.Point(115, 28);
            this.lblKO.Name = "lblKO";
            this.lblKO.Size = new System.Drawing.Size(256, 16);
            this.lblKO.TabIndex = 1;
            this.lblKO.Text = "Siparisinizi Kapıda Odeyebilirsiniz...";
            // 
            // tpCek
            // 
            this.tpCek.Controls.Add(this.btnOdOnayC);
            this.tpCek.Controls.Add(this.textBox2);
            this.tpCek.Controls.Add(this.textBox1);
            this.tpCek.Controls.Add(this.lblCekIsim);
            this.tpCek.Controls.Add(this.lblCekID);
            this.tpCek.Location = new System.Drawing.Point(4, 22);
            this.tpCek.Name = "tpCek";
            this.tpCek.Size = new System.Drawing.Size(480, 99);
            this.tpCek.TabIndex = 2;
            this.tpCek.Text = "Cek";
            this.tpCek.UseVisualStyleBackColor = true;
            // 
            // btnOdOnayC
            // 
            this.btnOdOnayC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdOnayC.Location = new System.Drawing.Point(383, 30);
            this.btnOdOnayC.Name = "btnOdOnayC";
            this.btnOdOnayC.Size = new System.Drawing.Size(74, 47);
            this.btnOdOnayC.TabIndex = 8;
            this.btnOdOnayC.Text = "Odemeyi Onayla";
            this.btnOdOnayC.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblCekIsim
            // 
            this.lblCekIsim.AutoSize = true;
            this.lblCekIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekIsim.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCekIsim.Location = new System.Drawing.Point(38, 28);
            this.lblCekIsim.Name = "lblCekIsim";
            this.lblCekIsim.Size = new System.Drawing.Size(44, 16);
            this.lblCekIsim.TabIndex = 2;
            this.lblCekIsim.Text = "Isim :";
            // 
            // lblCekID
            // 
            this.lblCekID.AutoSize = true;
            this.lblCekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCekID.Location = new System.Drawing.Point(3, 61);
            this.lblCekID.Name = "lblCekID";
            this.lblCekID.Size = new System.Drawing.Size(79, 16);
            this.lblCekID.TabIndex = 1;
            this.lblCekID.Text = "Banka ID :";
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 194);
            this.Controls.Add(this.tcOdeme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGA Express";
            this.tcOdeme.ResumeLayout(false);
            this.tpKredi.ResumeLayout(false);
            this.tpKredi.PerformLayout();
            this.tpNakit.ResumeLayout(false);
            this.tpNakit.PerformLayout();
            this.tpCek.ResumeLayout(false);
            this.tpCek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcOdeme;
        private System.Windows.Forms.TabPage tpKredi;
        private System.Windows.Forms.Button btnOdOnayKK;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ComboBox cbYil;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.TextBox txtbKartNo;
        private System.Windows.Forms.Label lblKartTipi;
        private System.Windows.Forms.Label lblKartSonK;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.TabPage tpNakit;
        private System.Windows.Forms.Label lblKO;
        private System.Windows.Forms.TabPage tpCek;
        private System.Windows.Forms.Button btnOdOnayC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCekIsim;
        private System.Windows.Forms.Label lblCekID;
        private System.Windows.Forms.Button btnOdOnayN;
    }
}