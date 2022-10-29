namespace RPG
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblUyari = new System.Windows.Forms.Label();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.chkOzelKarakterler = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkSayi = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblDeger = new System.Windows.Forms.Label();
            this.lblKarakterSayisi = new System.Windows.Forms.Label();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.txtSifre3 = new System.Windows.Forms.TextBox();
            this.txtSifre4 = new System.Windows.Forms.TextBox();
            this.txtSifre5 = new System.Windows.Forms.TextBox();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(107, 136);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 13);
            this.lblUyari.TabIndex = 20;
            // 
            // btnOluştur
            // 
            this.btnOluştur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOluştur.Location = new System.Drawing.Point(44, 267);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(130, 40);
            this.btnOluştur.TabIndex = 19;
            this.btnOluştur.Text = "Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = true;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(389, 56);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(274, 24);
            this.txtSifre.TabIndex = 18;
            // 
            // chkOzelKarakterler
            // 
            this.chkOzelKarakterler.AutoSize = true;
            this.chkOzelKarakterler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOzelKarakterler.Location = new System.Drawing.Point(180, 211);
            this.chkOzelKarakterler.Name = "chkOzelKarakterler";
            this.chkOzelKarakterler.Size = new System.Drawing.Size(121, 20);
            this.chkOzelKarakterler.TabIndex = 17;
            this.chkOzelKarakterler.Text = "Özel Karakterler";
            this.chkOzelKarakterler.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKucukHarf.Location = new System.Drawing.Point(70, 211);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(90, 20);
            this.chkKucukHarf.TabIndex = 16;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkSayi
            // 
            this.chkSayi.AutoSize = true;
            this.chkSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSayi.Location = new System.Drawing.Point(180, 173);
            this.chkSayi.Name = "chkSayi";
            this.chkSayi.Size = new System.Drawing.Size(53, 20);
            this.chkSayi.TabIndex = 15;
            this.chkSayi.Text = "Sayı";
            this.chkSayi.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBuyukHarf.Location = new System.Drawing.Point(70, 173);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(91, 20);
            this.chkBuyukHarf.TabIndex = 14;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(70, 81);
            this.trackBar.Maximum = 14;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(188, 45);
            this.trackBar.TabIndex = 13;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger.Location = new System.Drawing.Point(225, 39);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(18, 20);
            this.lblDeger.TabIndex = 12;
            this.lblDeger.Text = "0";
            // 
            // lblKarakterSayisi
            // 
            this.lblKarakterSayisi.AutoSize = true;
            this.lblKarakterSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarakterSayisi.Location = new System.Drawing.Point(87, 38);
            this.lblKarakterSayisi.Name = "lblKarakterSayisi";
            this.lblKarakterSayisi.Size = new System.Drawing.Size(119, 20);
            this.lblKarakterSayisi.TabIndex = 11;
            this.lblKarakterSayisi.Text = "Karakter sayısı :";
            // 
            // txtSifre1
            // 
            this.txtSifre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre1.Location = new System.Drawing.Point(389, 99);
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.Size = new System.Drawing.Size(274, 24);
            this.txtSifre1.TabIndex = 22;
            // 
            // txtSifre2
            // 
            this.txtSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre2.Location = new System.Drawing.Point(389, 144);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(274, 24);
            this.txtSifre2.TabIndex = 23;
            // 
            // txtSifre3
            // 
            this.txtSifre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre3.Location = new System.Drawing.Point(389, 187);
            this.txtSifre3.Name = "txtSifre3";
            this.txtSifre3.Size = new System.Drawing.Size(274, 24);
            this.txtSifre3.TabIndex = 24;
            // 
            // txtSifre4
            // 
            this.txtSifre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre4.Location = new System.Drawing.Point(389, 229);
            this.txtSifre4.Name = "txtSifre4";
            this.txtSifre4.Size = new System.Drawing.Size(274, 24);
            this.txtSifre4.TabIndex = 25;
            // 
            // txtSifre5
            // 
            this.txtSifre5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre5.Location = new System.Drawing.Point(389, 273);
            this.txtSifre5.Name = "txtSifre5";
            this.txtSifre5.Size = new System.Drawing.Size(274, 24);
            this.txtSifre5.TabIndex = 27;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.Location = new System.Drawing.Point(184, 267);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(130, 40);
            this.btnAnasayfa.TabIndex = 28;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 355);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.txtSifre5);
            this.Controls.Add(this.txtSifre4);
            this.Controls.Add(this.txtSifre3);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.txtSifre1);
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
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastgele Parola Oluşturucu / Daha fazla şifre";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox chkOzelKarakterler;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkSayi;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Label lblKarakterSayisi;
        private System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.TextBox txtSifre3;
        private System.Windows.Forms.TextBox txtSifre4;
        private System.Windows.Forms.TextBox txtSifre5;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}