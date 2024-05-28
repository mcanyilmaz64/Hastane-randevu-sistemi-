namespace Proje_Hastane
{
    partial class Frm_DoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoktorBilgiDuzenle));
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(155, 59);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(155, 31);
            this.TxtSoyad.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(155, 22);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(155, 31);
            this.TxtAd.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ad :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(155, 179);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(155, 31);
            this.TxtSifre.TabIndex = 49;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(155, 139);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(155, 31);
            this.MskTC.TabIndex = 48;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Şifre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "TC Kimlik No : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Branş :";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(155, 102);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(155, 31);
            this.CmbBrans.TabIndex = 47;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnGuncelle.Location = new System.Drawing.Point(155, 216);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(153, 36);
            this.BtnGuncelle.TabIndex = 50;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Frm_DoktorBilgiDuzenle
            // 
            this.AcceptButton = this.BtnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(395, 293);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.CmbBrans);
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
            this.Name = "Frm_DoktorBilgiDuzenle";
            this.Text = "Frm_DoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.Frm_DoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}