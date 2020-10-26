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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            frmMasa masa = new frmMasa();
            masa.Show();
        }

        cSiparis cs = new cSiparis();
        private void frmBill_Load(object sender, EventArgs e)
        {
            lbAdisyonId.Text = cGenel._AdisyonId;
            txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
            cs.getByOrder(lvUrunler, Convert.ToInt32(lbAdisyonId.Text));

            if (lvUrunler.Items.Count > 0)
            {
                decimal toplam = 0;
                for (int i = 0; i < lvUrunler.Items.Count; i++)
                {
                    toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                }
                lbToplamTutar.Text = string.Format("{0:0.000}", toplam);
                lbOdenecek.Text = string.Format("{0:0.000}", toplam);
                lbKdv.Text = string.Format("{0:0.000}", toplam * 18 / 100);
            }
            //gbIndirim.Visible = true;
            txtIndirimTutari.Clear();

        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lbToplamTutar.Text))
                {
                    try
                    {
                        lbIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutari.Text));
                    }
                    catch (Exception)
                    {
                        lbIndirim.Text = string.Format("{0:0.000}", 0);
                        
                    }
                }
            
                else{
                    MessageBox.Show("İndirim tutarı toplam tutardan fazla olamaz");
                }
            }
            catch (Exception)
            {

                lbIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
            }
            else
            {
                gbIndirim.Visible = false;
            }
        }

        private void lbIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lbIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lbOdenecek.Text = lbToplamTutar.Text;
                odenecek = Convert.ToDecimal(lbOdenecek.Text) - Convert.ToDecimal(lbIndirim.Text);
                lbOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }

            decimal kdv = Convert.ToDecimal(lbOdenecek.Text) * 18 / 100;
            lbKdv.Text = string.Format("{0:0.000}",kdv);
        }
        cMasa masa = new cMasa();
        private void button2_Click(object sender, EventArgs e)
        {
            int masaid = masa.TableGetByNumber(cGenel._ButtonName);
            int musteriId = 1;

            int odemeTurId = 0;
            if(rbNakit.Checked)
            {
                odemeTurId = 1;
            }

            if(rbKrediKarti.Checked)
            {
                odemeTurId = 2;
            }
            
            if(rbTicket.Checked)
            {
                odemeTurId = 3;
            }

            cOdeme odeme = new cOdeme();

            //ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLTAMTUTAR,INDIRIM

            odeme.AdisyonId = Convert.ToInt32(lbAdisyonId.Text);
            odeme.OdemeTurId = odemeTurId;
            odeme.MusteriId = musteriId;
            odeme.AraToplam = Convert.ToDecimal(lbOdenecek.Text);
            odeme.Kdvtutari = Convert.ToDecimal(lbKdv.Text);
            odeme.GenelToplam = Convert.ToDecimal(lbToplamTutar.Text);
            odeme.Indirim = Convert.ToDecimal(lbIndirim.Text);

            bool result = odeme.billClose(odeme);

            if (result)
            {
                MessageBox.Show("Hesap Kapatılmıştır.");
                masa.setChangeTableState(Convert.ToString(masaid), 1);

                cAdisyon a = new cAdisyon();
                a.adisyonKapat(Convert.ToInt32(lbAdisyonId.Text),0);


                this.Close();
                frmMasa frm = new frmMasa();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Hesap kapatılırken bir hata oluştu.");
            }
        }
    }
}
