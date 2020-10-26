using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Resteurant_Oto
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = " Çıkmak istediğinizden emin misiniz?";
            string tittle = "Oturumu kapat.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, tittle, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rollback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPEersonelGorev cpg = new cPEersonelGorev();
            string gorev = cpg.PersonelGorevTanim(cGenel._gorevId);
            if (gorev == "Patron")
            {
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriniGetir(lvPersoneller);
                btnEkle.Visible = false;
                btnSil.Visible = false;
                btnYeni.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                txtSifre.ReadOnly = true;
                txtSifreTekrar.ReadOnly = true;
                lbBilgi.Text = "Mevki: " +gorev+ " / Yetki sınırsız / " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }

            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                lbBilgi.Text = "Mevki: " + gorev + " / Yetki sınırlı  / " + cp.personelBilgiGetirIsim(cGenel._personelId);
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Visible = false;
            btnEkle.Visible = true;
            btnSil.Visible = true;
            txtSifre.ReadOnly = false;
            txtSifreTekrar.ReadOnly = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                cPersoneller c = new cPersoneller();
                bool sonuc = c.personelSil(Convert.ToInt32(lvPersoneller.SelectedItems[0].Text));
                if (sonuc)
                {
                    MessageBox.Show("KAYIT BAŞARIYLA SİLİNDİ");
                    c.personelBilgileriniGetir(lvPersoneller);
                }

                else
                {
                    MessageBox.Show("KAYIT SİLİNİRKEN BİR HATA OLUŞTU");
                }
            }
            else
            {
                MessageBox.Show("KAYIT SEÇİNİZ");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim()!="" & txtSoyad.Text.Trim()!="" & txtSifre.Text.Trim()!="" & txtSifreTekrar.Text!="" & txtGorevId2.Text.Trim()!="")
            {
                if (txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim())
                {
                    cPersoneller c = new cPersoneller();
                    c.PersonelAd = txtAd.Text.Trim();
                    c.PersonelSoyad = txtSoyad.Text.Trim();
                    c.PersonelParola = txtSifreTekrar.Text;
                    c.PersonelGorevId = Convert.ToInt32(txtGorevId2.Text);

                    bool sonuc = c.personelEkle(c);

                    if (sonuc)
                    {
                        MessageBox.Show("KAYIT BAŞARIYLA EKLENMİŞTİR");
                        c.personelBilgileriniGetir(lvPersoneller);
                    }

                    else
                    {
                        MessageBox.Show("KAYIT EKLENİKEN HATA OLUŞTU");
                    }

                }

                else
                {
                    MessageBox.Show("ŞİFRELER AYNI DEĞİL");
                }
            }

            else
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYINIZ");
            }
        }

        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPEersonelGorev c = (cPEersonelGorev)cbGorevi.SelectedItem;
            txtGorevId2.Text = Convert.ToString(c.PersonelGorevId);
        }

        private void lbBilgi_Click(object sender, EventArgs e)
        {

        }
    }
}
