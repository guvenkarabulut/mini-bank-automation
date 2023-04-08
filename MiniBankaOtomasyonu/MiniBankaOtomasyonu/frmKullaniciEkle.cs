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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int Rol=0;
            if (txtAdi.Text != " " || txtKullaniciAd.Text != " " || txtMail.Text != " " || txtSifre.Text != " " || txtSoyadi.Text != " " || txtTc.Text != " ")
            {
                long tcNo = long.Parse(txtTc.Text);
                string Adi = txtAdi.Text.ToUpper();
                string Soyadi = txtSoyadi.Text.ToUpper();
                int dogumYili = int.Parse(txtDogumYili.Text);
                tcKimlikDogrulaWS.KPSPublicSoapClient servis = new tcKimlikDogrulaWS.KPSPublicSoapClient();
                bool sonuctc = servis.TCKimlikNoDogrula(tcNo, Adi, Soyadi, dogumYili);
                if (sonuctc == true)
                {
                    kullanici Kullanici = new kullanici();
                    Kullanici.kullaniciAd = txtAdi.Text;
                    Kullanici.kullaniciAdi = txtKullaniciAd.Text;
                    Kullanici.kullaniciAktifMi = true;
                    Kullanici.kullaniciMail = txtMail.Text;
                    if (cbRol.Text == "Yönetici")
                        Rol = 1;
                    else if (cbRol.Text == "Gişe")
                        Rol = 2;
                    Kullanici.kullaniciRol = Rol;
                    Kullanici.kullaniciSifre = txtSifre.Text;
                    Kullanici.dogumyili = txtDogumYili.Text;
                    Kullanici.kullaniciSoyad = txtSoyadi.Text;
                    Kullanici.kullaniciTc = txtTc.Text;

                    db.kullanici.Add(Kullanici);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt İşleminiz Başarılı bir Şekilde Gerçekşmiştir.");
                        txtAdi.Text = "";
                        txtKullaniciAd.Text = "";
                        txtDogumYili.Text = "";
                        txtMail.Text = "";
                        txtSifre.Text = "";
                        txtSoyadi.Text = "";
                        txtTc.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşleminde bir Sorun Oluştu.");

                    }
                }
                else if (sonuctc ==false)
                {
                    MessageBox.Show("Girilen Tc Yanlış Lütfen Geçerli Bir Tc Giriniz");
                }
            }
        }
    }
}
