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
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
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
            frmMenu menü = new frmMenu();
            menü.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            MüsteriEkleme m = new MüsteriEkleme();
            cGenel._musteriEkleme = 1;
            this.Close();
            m.Show();
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            cMüsteriler c = new cMüsteriler();
            c.musterileriGetir(lvMusteriler);
        }

        private void btnMuşteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                MüsteriEkleme frm = new MüsteriEkleme();
                cGenel._musteriEkleme = 1;
                cGenel.musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);

                this.Close();
                frm.Show();

            }
        }


    }
}
