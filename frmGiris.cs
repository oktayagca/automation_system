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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        
        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetByInformation(cbKullanici);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(txtSifre.Text, cGenel._personelId);

            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giris Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);
                
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.Lütfen tekrar deneyiniz.");
            }
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
