namespace Proje_Hastane
{
    partial class Frm_BilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BilgiDuzenle));
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnKayitYap.Location = new System.Drawing.Point(166, 255);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(153, 36);
            this.BtnKayitYap.TabIndex = 7;
            this.BtnKayitYap.Text = "Guncelle";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(166, 217);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(153, 31);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cinsiyet:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(164, 106);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(155, 31);
            this.MskTelefon.TabIndex = 3;
            this.MskTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTelefon_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefon No:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(164, 69);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(155, 31);
            this.TxtSoyad.TabIndex = 2;
            this.TxtSoyad.TextChanged += new System.EventHandler(this.TxtSoyad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Soyad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(164, 32);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(155, 31);
            this.TxtAd.TabIndex = 1;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ad :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(164, 178);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(155, 31);
            this.TxtSifre.TabIndex = 5;
            this.TxtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(164, 141);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(155, 31);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            this.MskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTC_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Şifre: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "TC Kimlik No : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frm_BilgiDuzenle
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(397, 333);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frm_BilgiDuzenle";
            this.Text = "Bilgi Duzenle";
            this.Load += new System.EventHandler(this.Frm_BilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayitYap;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}