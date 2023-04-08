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
    public partial class frmKrediKartiOlustur : Form
    {
        public frmKrediKartiOlustur()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteri.Where(p => p.musteriTc.Contains(txtTc.Text)).ToList();

        }

        private void frmKrediKartiOlustur_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteri.ToList();

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string mail = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            textBox1.Text = tc;
            textBox2.Text = ad;
            textBox3.Text = soyad;
            textBox4.Text = mail;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kredikartino="";
            string sorgutc = textBox1.Text;

            if (string.IsNullOrEmpty(sorgutc))
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz.");

            }
            else
            {
                Random rnd = new Random();
            A:
                kredikartino = "";
                for (int i = 0; i <= 10; i++)
                {
                    kredikartino += rnd.Next(0, 10);
                }
                var hesapnolar = db.krediKarti.FirstOrDefault(p => p.krediKartiNo == kredikartino);
                if (hesapnolar != null)
                {
                    goto A;
                }
            }
            krediKarti kredi = new krediKarti();
            kredi.krediKartıHarcanananTutar = 0;
            kredi.krediKartiNo = kredikartino;
            kredi.krediKartiLimit = Convert.ToInt32(textBox5.Text);
            kredi.krediKartiKalanTutar = Convert.ToInt32(textBox5.Text);
            kredi.musteriNo = textBox1.Text;
            db.krediKarti.Add(kredi);
            kullanici Kullanici = new kullanici();
            Kullanici.dogumyili = textBox4.Text;
            Kullanici.kullaniciAd = textBox2.Text;
            Kullanici.kullaniciAdi = kredikartino;
            Kullanici.kullaniciAktifMi = true;
            Kullanici.kullaniciMail = kredikartino += "@banka.com";
            Kullanici.kullaniciRol = 3;
            Kullanici.kullaniciSoyad = textBox2.Text;
            Kullanici.kullaniciSifre = textBox1.Text;
            Kullanici.kullaniciTc = textBox1.Text;
            db.kullanici.Add(Kullanici);
            int sonuc = db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Kredi Kartı Başarılı bir Şekilde Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Kredi Kartı Oluşturlurken bir Sorun Yaşandı Lütfen Tekrar Deneyiniz.");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
