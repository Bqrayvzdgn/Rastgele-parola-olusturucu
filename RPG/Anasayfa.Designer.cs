namespace RPG
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.lblKarakterSayisi = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkSayi = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakterler = new System.Windows.Forms.CheckBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.lblUyari = new System.Windows.Forms.Label();
            this.btnDahaFazlaSifre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKarakterSayisi
            // 
            this.lblKarakterSayisi.AutoSize = true;
            this.lblKarakterSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarakterSayisi.Location = new System.Drawing.Point(87, 38);
            this.lblKarakterSayisi.Name = "lblKarakterSayisi";
            this.lblKarakterSayisi.Size = new System.Drawing.Size(119, 20);
            this.lblKarakterSayisi.TabIndex = 0;
            this.lblKarakterSayisi.Text = "Karakter sayısı :";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger.Location = new System.Drawing.Point(225, 39);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(18, 20);
            this.lblDeger.TabIndex = 1;
            this.lblDeger.Text = "0";
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(70, 81);
            this.trackBar.Maximum = 14;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(188, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBuyukHarf.Location = new System.Drawing.Point(67, 171);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(91, 20);
            this.chkBuyukHarf.TabIndex = 3;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkSayi
            // 
            this.chkSayi.AutoSize = true;
            this.chkSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSayi.Location = new System.Drawing.Point(177, 171);
            this.chkSayi.Name = "chkSayi";
            this.chkSayi.Size = new System.Drawing.Size(53, 20);
            this.chkSayi.TabIndex = 4;
            this.chkSayi.Text = "Sayı";
            this.chkSayi.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKucukHarf.Location = new System.Drawing.Point(67, 209);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(90, 20);
            this.chkKucukHarf.TabIndex = 5;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakterler
            // 
            this.chkOzelKarakterler.AutoSize = true;
            this.chkOzelKarakterler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOzelKarakterler.Location = new System.Drawing.Point(177, 209);
            this.chkOzelKarakterler.Name = "chkOzelKarakterler";
            this.chkOzelKarakterler.Size = new System.Drawing.Size(121, 20);
            this.chkOzelKarakterler.TabIndex = 6;
            this.chkOzelKarakterler.Text = "Özel Karakterler";
            this.chkOzelKarakterler.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(43, 252);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(274, 24);
            this.txtSifre.TabIndex = 7;
            // 
            // btnOluştur
            // 
            this.btnOluştur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOluştur.Location = new System.Drawing.Point(107, 300);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(130, 40);
            this.btnOluştur.TabIndex = 8;
            this.btnOluştur.Text = "Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = true;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(107, 138);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 9;
            // 
            // btnDahaFazlaSifre
            // 
            this.btnDahaFazlaSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDahaFazlaSifre.Location = new System.Drawing.Point(107, 350);
            this.btnDahaFazlaSifre.Name = "btnDahaFazlaSifre";
            this.btnDahaFazlaSifre.Size = new System.Drawing.Size(130, 40);
            this.btnDahaFazlaSifre.TabIndex = 10;
            this.btnDahaFazlaSifre.Text = "Daha fazla şifre";
            this.btnDahaFazlaSifre.UseVisualStyleBackColor = true;
            this.btnDahaFazlaSifre.Click += new System.EventHandler(this.btnDahaFazlaSifre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 431);
            this.Controls.Add(this.btnDahaFazlaSifre);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.btnOluştur);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.chkOzelKarakterler);
            this.Controls.Add(this.chkKucukHarf);
            this.Controls.Add(this.chkSayi);
            this.Controls.Add(this.chkBuyukHarf);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblKarakterSayisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastgele Parola Oluşturucu";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKarakterSayisi;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkSayi;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkOzelKarakterler;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Button btnDahaFazlaSifre;
    }
}

