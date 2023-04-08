using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBankaOtomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db =new miniBankaOtomasyonuDBEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kAdi = txtKullaniciAd.Text;
            string sifre = txtSifre.Text;
            if (string.IsNullOrEmpty(kAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Boş Ltfen Kontrol Ediniz");
            }
            else
            {
                kullanici Kullanici = db.kullanici.FirstOrDefault(p => p.kullaniciAdi == kAdi && p.kullaniciSifre == sifre);
                if (Kullanici != null)
                {
                    frmAna ekran = new frmAna(Kullanici);
                    ekran.Show();
                    this.Hide();
                    ekran.FormClosed += Ekran_FormClosed;
                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Yanlış Lütfen Kontrol Ediniz");
                }
            }
            
        }
        private void Ekran_FormClosed(object sender,FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
