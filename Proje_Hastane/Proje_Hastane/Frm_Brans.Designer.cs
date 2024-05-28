namespace Proje_Hastane
{
    partial class Frm_Brans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Brans));
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtBrans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnGuncelle.Location = new System.Drawing.Point(96, 188);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(131, 32);
            this.BtnGuncelle.TabIndex = 37;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.IndianRed;
            this.BtnSil.Location = new System.Drawing.Point(96, 150);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(131, 32);
            this.BtnSil.TabIndex = 36;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnEkle.Location = new System.Drawing.Point(96, 112);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(131, 32);
            this.BtnEkle.TabIndex = 35;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 196);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(96, 21);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(131, 31);
            this.TxtId.TabIndex = 32;
            // 
            // TxtBrans
            // 
            this.TxtBrans.Location = new System.Drawing.Point(96, 61);
            this.TxtBrans.Name = "TxtBrans";
            this.TxtBrans.Size = new System.Drawing.Size(131, 31);
            this.TxtBrans.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Branş Ad:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(12, 24);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(82, 23);
            this.LblTC.TabIndex = 25;
            this.LblTC.Text = "Branş Id :";
            // 
            // Frm_Brans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(692, 243);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtBrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTC);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frm_Brans";
            this.Text = "Brans Paneli";
            this.Load += new System.EventHandler(this.Frm_Brans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtBrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTC;
    }
}