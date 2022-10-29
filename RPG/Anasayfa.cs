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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
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
            else { lblUyari.Text = ""; }

            if (chkBuyukHarf.Checked == true && chkKucukHarf.Checked == true && chkSayi.Checked == true && chkOzelKarakterler.Checked == true && lblDeger.Text == "0")
            {
                MessageBox.Show("Sayı barı boş değer alamaz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { lblUyari.Text = ""; }

            string buyukharfler = "ABCDEFGHIJKLMNOPRSTUVYZ";
            string kucukharfler = "abcdefghijklmnoprstuvyz";
            string rakamlar = "0123456789";
            string ozelkarakterler = ".*!_";
            string sifre = "";

            txtSifre.Text = "";

            if (chkBuyukHarf.Checked) { sifre += buyukharfler; } else { }
            if (chkKucukHarf.Checked) { sifre += kucukharfler; } else { }
            if (chkSayi.Checked) { sifre += rakamlar; } else { }
            if (chkOzelKarakterler.Checked) { sifre += ozelkarakterler; } else { }

            for (int i = 0; i < trackBar.Value; i++)
            {
                try
                {
                    txtSifre.Text += sifre[rndm.Next(sifre.Length)];
                    lblUyari.Text = "Şifre Oluşturuldu!";
                }
                catch (Exception)
                {
                    lblUyari.Text = "Kutucukları doldurunuz!";
                }
            }
        }

        private void btnDahaFazlaSifre_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
