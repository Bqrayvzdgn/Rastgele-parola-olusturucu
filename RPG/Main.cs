using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            lblDeger.Text = trackBar.Value.ToString();
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            txtSifre.Text = string.Empty;
            Random rndm = new Random();

            if (chkBuyukHarf.Checked == false && chkKucukHarf.Checked == false && chkSayi.Checked == false && chkOzelKarakterler.Checked == false)
            {
                MessageBox.Show("Bütün kutucuklar boş olamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {  }

            if (chkBuyukHarf.Checked == true && chkKucukHarf.Checked == true && chkSayi.Checked == true && chkOzelKarakterler.Checked == true && lblDeger.Text == "0")
            {
                MessageBox.Show("Sayı barı boş değer alamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {  }

            string buyukharfler = "ABCDEFGHIJKLMNOPRSTUVYZ";
            string kucukharfler = "abcdefghijklmnoprstuvyz";
            string rakamlar = "0123456789";
            string ozelkarakterler = ".*!_";
            string sifre = "";

            txtSifre.Text = "";
            txtSifre1.Text = "";
            txtSifre2.Text = "";
            txtSifre3.Text = "";
            txtSifre4.Text = "";
            txtSifre5.Text = "";

            if (chkBuyukHarf.Checked) { sifre += buyukharfler; }
            if (chkKucukHarf.Checked) { sifre += kucukharfler; }
            if (chkSayi.Checked) { sifre += rakamlar; }
            if (chkOzelKarakterler.Checked) { sifre += ozelkarakterler; }

            for (int i = 0; i < trackBar.Value; i++)
            {
                try
                {
                    txtSifre.Text += sifre[rndm.Next(sifre.Length)];
                    txtSifre1.Text += sifre[rndm.Next(sifre.Length)];
                    txtSifre2.Text += sifre[rndm.Next(sifre.Length)];
                    txtSifre3.Text += sifre[rndm.Next(sifre.Length)];
                    txtSifre4.Text += sifre[rndm.Next(sifre.Length)];
                    txtSifre5.Text += sifre[rndm.Next(sifre.Length)];
                    lblUyari.Text = "Şifreler Oluşturuldu!";
                }
                catch (Exception)
                {
                    lblUyari.Text = "Kutucukları doldurunuz!";
                }
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa main = new Anasayfa();
            main.Show();
            this.Hide();
        }
    }
}
