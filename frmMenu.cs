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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmHesap frm = new frmHesap();
            this.Close();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMasa frm = new frmMasa();
            this.Close();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            this.Close();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Close();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            this.Close();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra();
            this.Close();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string message = " Çıkmak istediğinizden emin misiniz?";
            string tittle = "Oturumu kapat.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, tittle, buttons);
            if(result == DialogResult.Yes)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Çıkış Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
                this.Close();
            }

        }
    }
}
