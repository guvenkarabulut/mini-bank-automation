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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != " " || txtMail.Text != " " || txtSoyadi.Text != " " || txtTc.Text != " ")
            {
                long tcNo = long.Parse(txtTc.Text);
                string Adi = txtAdi.Text.ToUpper();
                string Soyadi = txtSoyadi.Text.ToUpper();
                int dogumYili = int.Parse(txtDogumYili.Text);
                tcKimlikDogrulaWS.KPSPublicSoapClient servis = new tcKimlikDogrulaWS.KPSPublicSoapClient();
                bool sonuctc = servis.TCKimlikNoDogrula(tcNo, Adi, Soyadi, dogumYili);
                if (sonuctc == true)
                {
                    musteri Musteri = new musteri();
                    Musteri.musteriAd = txtAdi.Text;
                    Musteri.musteriAktifMi = true;
                    if (cbErkek.Checked==true)
                    {
                        Musteri.musteriCinsiyet = "Erkek";
                    }
                    if (cbKadin.Checked==true)
                    {
                        Musteri.musteriCinsiyet = "Kadın";
                    }
                    Musteri.musteriDogum = txtDogumYili.Text;
                    Musteri.musteriMail = txtMail.Text;
                    Musteri.musteriSoyad = txtSoyadi.Text;
                    Musteri.musteriTc = txtTc.Text;
                    db.musteri.Add(Musteri);
                    int sonuc = db.SaveChanges();
                    if (sonuc>0)
                    {
                        MessageBox.Show("Kayıt İşleminiz Başarılı bir Şekilde Gerçekşmiştir.");
                        txtAdi.Text = "";
                        txtDogumYili.Text = "";
                        txtMail.Text = "";
                        txtSoyadi.Text = "";
                        txtTc.Text = "";
                        cbKadin.Checked = false;
                        cbErkek.Checked = false;

                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşleminde bir Sorun Oluştu.");

                    }
                }
                else if (sonuctc == false)
                {
                    MessageBox.Show("Girilen Tc Yanlış Lütfen Geçerli Bir Tc Giriniz");
                }

            }
        }

        private void cbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKadin.Checked == true)
            {
                cbKadin.Checked = false;
            }
        }

        private void cbKadin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbErkek.Checked == true)
            {
                cbErkek.Checked = false;
            }
        }
    }
}
