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
    public partial class frmMutfak : Form
    {
        public frmMutfak()
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

        private void frmMutfak_Load(object sender, EventArgs e)
        {
            cUrunCesitleri AnaKategori = new cUrunCesitleri();
            AnaKategori.urunCesitleriniGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "TÜM KATEGORİLER");
            cbKategoriler.SelectedIndex = 0;
            
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGidaListesi);
        }

        private void temizle()
        {
            txtGıdaAdı.Clear();
            txtGıdaFiyat.Clear();
            txtGıdaFiyat.Text = string.Format("{0:##0.00}", 0);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbAltkategori.Checked)
            {
                 
                if (txtGıdaAdı.Text.Trim()==""||txtGıdaFiyat.Text.Trim()==""||cbKategoriler.SelectedItem.ToString()=="TÜM KATAGORİLER")
                {
                    MessageBox.Show("GIDA ADI,FİYARI VE KATEGORİ SEÇİLMEMİŞTİR.");
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGıdaFiyat.Text);
                    c.UrunAd = txtGıdaAdı.Text;
                    c.Acıklama = "ÜRÜN EKLENDİ";
                    c.UrunTurNo = urunturNo;
                    int sonuc = c.urunEkle(c);
                    if (sonuc!=0)
                    {
                        MessageBox.Show("ÜRÜN EKLENMİŞTİR");
                        yenile();
                        temizle();
                    }
                }
            }
            else
            {
                panelUrun.Visible = false;
                if (txtKategoriAd.Text.Trim()=="")
                {
                    MessageBox.Show("LÜTFEN BİR KATEGORİ ADI GİRİNİZ");
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAd.Text;
                    gida.Aciklama = txtAcıklamaa.Text;
                    int sonuc=gida.urunCesitleriEkle(gida);
                    
                    if (sonuc!=0)
                    {
                        MessageBox.Show("KATEGORİ EKLENMİŞTİR.");
                        yenile();
                        temizle();
                        
                    }
                }

            }
        }
        int urunturNo = 0;
        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if(cbKategoriler.SelectedItem.ToString()=="TÜM KATEGORİLER")
            {
                u.urunleriListele(lvGidaListesi);
            }

            else
            {
                cUrunCesitleri cesit = (cUrunCesitleri)cbKategoriler.SelectedItem;
                urunturNo = cesit.UrunTurNo;
                u.urunleriListeleByurunID(lvGidaListesi,urunturNo);
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            
            if (rbAltkategori.Checked)
            {
                panelAnaKategori.Visible = false;
                if (txtGıdaAdı.Text.Trim() == "" || txtGıdaFiyat.Text.Trim() == "" || cbKategoriler.SelectedItem.ToString() == "TÜM KATAGORİLER")
                {
                    MessageBox.Show("GIDA ADI,FİYARI VE KATEGORİ SEÇİLMEMİŞTİR.");
                }
                else
                {
                    cUrunler c = new cUrunler();
                    c.Fiyat = Convert.ToDecimal(txtGıdaFiyat.Text);
                    c.UrunAd = txtGıdaAdı.Text;
                    c.UrunId = Convert.ToInt32(txtUrunId.Text);
                    c.UrunTurNo = urunturNo;
                    c.Acıklama = "ÜRÜN GÜNCELLENDİ";
                    int sonuc = c.urunBilgileriGüncelle(c);
                    if (sonuc != 0)
                    {
                        MessageBox.Show("ÜRÜN GÜNCELLENMİŞTİR.");
                        yenile();
                        temizle();
                    }
                }
            }
            else
            {
                panelUrun.Visible = false;
                if (txtKategoriId.Text.Trim() == "")
                {
                    MessageBox.Show("LÜTFEN BİR KATEGORİ SEÇİNİZ.");
                }
                else
                {
                    cUrunCesitleri gida = new cUrunCesitleri();
                    gida.KategoriAd = txtKategoriAd.Text;
                    gida.UrunTurNo = Convert.ToInt32(txtKategoriId.Text);
                    gida.Aciklama = txtAcıklamaa.Text;
                    int sonuc = gida.urunKategoriBilgileriGüncelle(gida);

                    if (sonuc != 0)
                    {
                        MessageBox.Show("KATEGORİ GÜNCELLENMİŞTİR.");
                        
                        gida.urunCesitleriniGetir(lvKategoriler);
                        temizle();

                    }
                }

            }
        }

        private void lvGıdaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count>0)
            {
                txtGıdaAdı.Text = lvGidaListesi.SelectedItems[0].SubItems[3].Text;
                txtGıdaFiyat.Text = lvGidaListesi.SelectedItems[0].SubItems[4].Text;
                txtUrunId.Text = lvGidaListesi.SelectedItems[0].SubItems[0].Text;

            }
        }

        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count>0)
            {
                txtKategoriAd.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtKategoriId.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
                txtAcıklamaa.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            if (rbAltkategori.Checked)
            {
                if (lvGidaListesi.SelectedItems.Count > 0)
                {



                    if (MessageBox.Show("Ürün silmekte emin misiniz?", "Dikkat bilgiler silinecek.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cUrunler c = new cUrunler();
                        c.UrunId = Convert.ToInt32(txtUrunId.Text);
                        int sonuc = c.urunSil(c);
                        if (sonuc != 0)
                        {
                            MessageBox.Show("Ürün silinmiştir.");
                            cbKategoriler_SelectedIndexChanged(sender, e);
                            yenile();
                            temizle();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürün silmek için bir ürün seçiniz.", "Dikkat ürün seçmediniz.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lvKategoriler.SelectedItems.Count>0)
                {



                    if (rbAnakategori.Checked)
                    {

                        if (MessageBox.Show("Ürün silmekte emin misiniz?", "Dikkat bilgiler silinecek.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            
                          
                            int sonuc = uc.urunKategoriSil(Convert.ToInt32(txtKategoriId.Text));
                            if (sonuc != 0)
                            {
                                MessageBox.Show("Ürün silinmiştir.");
                                cUrunler c = new cUrunler();
                                yenile();
                                temizle();
                            }
                        }
                    }

                }
            }
        }

        private void rbAltkategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = true;
            panelAnaKategori.Visible = false;
            lvKategoriler.Visible = false;
            lvGidaListesi.Visible = true;
            yenile();
        }

        private void rbAnakategori_CheckedChanged(object sender, EventArgs e)
        {
            panelUrun.Visible = false;
            panelAnaKategori.Visible = true;
            lvKategoriler.Visible = true;
            lvGidaListesi.Visible = false;
            yenile();
        }

        private void yenile()
        {
            cUrunCesitleri uc = new cUrunCesitleri();
            uc.urunCesitleriniGetir(cbKategoriler);
            cbKategoriler.Items.Insert(0, "TÜM KATEGORİLER");
            cbKategoriler.SelectedIndex = 0;
            uc.urunCesitleriniGetir(lvKategoriler);
            cUrunler c = new cUrunler();
            c.urunleriListele(lvGidaListesi);

        }
    }
}
