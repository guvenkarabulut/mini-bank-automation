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
    public partial class frmHesapOlustur : Form
    {
        public frmHesapOlustur()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmHesapOlustur_Load(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToShortDateString();
            dataGridView1.DataSource = db.musteri.ToList();
            dataGridView2.DataSource = db.hesap.Where(p=>p.hesapOlusturmaTarihi.Contains(tarih)).ToList();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteri.Where(p => p.musteriTc.Contains(txtTc.Text)).ToList();
        }
        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tc = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyad =dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string mail = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            textBox1.Text = tc.ToString();
            textBox2.Text = ad;
            textBox3.Text = soyad;
            textBox4.Text = mail;



        }
        string hesapno = "";
        string iban = "TR";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgutc = textBox1.Text;
            
            if (string.IsNullOrEmpty(sorgutc) )
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz.");

            }
            else
            {
                Random rnd = new Random();
            A:
                hesapno = "";
                for (int i = 0; i <= 10; i++)
                {
                    hesapno += rnd.Next(0, 10);
                }
                var hesapnolar = db.hesap.FirstOrDefault(p => p.hesapNo == hesapno);
                if (hesapnolar != null)
                {
                    goto A;
                }
            B:
                iban = "TR";
                for (int i = 0; i <= 23; i++)
                {
                    iban += rnd.Next(0, 10);
                }
                var ibannolar = db.hesap.FirstOrDefault(p => p.ibanNo == iban);
                if (ibannolar != null)
                {
                    goto B;
                }

                hesap Hesap = new hesap();
                Hesap.hesapNo = hesapno;
                Hesap.ibanNo = iban;
                Hesap.musteriNo = textBox1.Text;
                Hesap.hesapPara = 0;
                Hesap.hesapOlusturmaTarihi = DateTime.Now.ToShortDateString();
                db.hesap.Add(Hesap);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı bir Şekilde Oluşturuldu.");
                    string tarih = DateTime.Now.ToShortDateString();
                    dataGridView2.DataSource = db.hesap.Where(p => p.hesapOlusturmaTarihi.Contains(tarih)).ToList();
                }
                else
                {
                    MessageBox.Show("Kayıt Yapılırken bir Sorun Oluştu.");

                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
