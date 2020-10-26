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
    public partial class MüsteriEkleme : Form
    {
        public MüsteriEkleme()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

        
    
            if (txtTelefon.Text.Length>6)
            {
                if (txtMusteriAd.Text=="" || txt.Text=="")
                {
                    MessageBox.Show("Lütfen adınızı ve soyadınızı giriniz."); 
                }
                else
                {
                    cMüsteriler c = new cMüsteriler();
                    bool sonuc = c.MusteriVarmi(txtTelefon.Text);
                    if (!sonuc)
                    {
                        c.MusteriAd = txtMusteriAd.Text;
                        c.MusteriSoyad = txtMusteriSoyad.Text;
                        c.Telefon = txtTelefon.Text;
                        c.Email = txtEmail.Text;
                        c.Adres = txtAdres.Text;
                        txtMusteriNo.Text = c.musteriEkle(c).ToString();
                        if (txtMusteriNo.Text!="")
                        {
                            MessageBox.Show("Müşteri eklendi.");
                            txtMusteriAd.Clear();
                            txtMusteriSoyad.Clear();
                            txtTelefon.Clear();
                            txtEmail.Clear();
                            txtAdres.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri eklenemedi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kayıt zaten vardır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();

            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == "" || txt.Text == "")
                {
                    MessageBox.Show("Lütfen adınızı ve soyadınızı giriniz.");
                }
                else
                {
                    cMüsteriler c = new cMüsteriler();
                    

                    c.MusteriAd = txtMusteriAd.Text;
                    c.MusteriSoyad = txtMusteriSoyad.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Email = txtEmail.Text;
                    c.Adres = txtAdres.Text;
                    c.MusteriId = Convert.ToInt32(txtMusteriNo.Text);
                    bool sonuc = c.musteriBilgileriGüncelle(c);

                    if (sonuc)
                    {
                       
                        if (txtMusteriNo.Text != "")
                        {
                            MessageBox.Show("Müşteri güncellendi.");
                            this.Close();
                            frm.Show();

                        }
                        else
                        {
                            MessageBox.Show("Müşteri güncellenemedi!!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen en az 7 haneli bir telefon numarası giriniz");
            } 
        }

        private void MüsteriEkleme_Load(object sender, EventArgs e)
        {
            btnEkle.Visible = true;
            btnGuncelle.Visible = true;
            if (cGenel.musteriId>0)
            {
                btnEkle.Visible = false;
                cMüsteriler c = new cMüsteriler();
                txtMusteriNo.Text = cGenel.musteriId.ToString();
                c.musterileriGetirId(Convert.ToInt32(txtMusteriNo.Text), txtMusteriAd, txtMusteriSoyad, txtTelefon, txtAdres, txtEmail);
            }

            if (txtMusteriAd.Text == "")
            {
                btnGuncelle.Visible = false;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMusteriAra musteri = new frmMusteriAra();
            musteri.Show();
        }
    }
}
