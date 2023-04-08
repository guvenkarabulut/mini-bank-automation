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
    public partial class frmHesapPara : Form
    {
        public frmHesapPara()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmHesapPara_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.hesap.ToList();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.hesap.Where(p=>p.hesapNo.Contains(txtHesap.Text)).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hesap = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string iban = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string tutar = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string hesapid = dataGridView1.CurrentRow.Cells[4].Value.ToString();


            textBox1.Text = hesap;
            textBox2.Text = iban;
            textBox3.Text = tutar;
            textBox4.Text = hesapid;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (rBYatirma.Checked==true)
            {
                var Hesap = db.hesap.Where(p => p.hesapNo == textBox1.Text).FirstOrDefault();

                int hesaptutar = Convert.ToInt32(textBox3.Text);
                int tutar = Convert.ToInt32(textBox5.Text);
                int sontutar = tutar + hesaptutar;
                Hesap.hesapPara = sontutar;
                int sonuc = db.SaveChanges();
                hesapDefteri hesapdefteri = new hesapDefteri();
                hesapdefteri.hesapDefteriTarih = DateTime.Now.ToShortDateString();
                hesapdefteri.hesapTutarGirisi = "+";
                hesapdefteri.hesapTutari = tutar;
                hesapdefteri.hesapId =Convert.ToInt32(textBox4.Text);
                db.hesapDefteri.Add(hesapdefteri);
                db.SaveChanges();
                if (sonuc>0)
                {
                    MessageBox.Show("Para Yatırma İşleminiz Gerçekleşti.");
                    dataGridView1.DataSource = db.hesap.ToList();

                }
                else
                {
                    MessageBox.Show("Para Yatırma İşlmeizide Bir Sorun Oluştu.");

                }
            }
            else if (rbCekme.Checked==true)
            {

                int hesaptutar = Convert.ToInt32(textBox3.Text);
                int tutar = Convert.ToInt32(textBox5.Text);
                if (hesaptutar<tutar)
                {
                    MessageBox.Show("Hesapta bu Kadar Para Yok Lütfen Kontrol Ediniz.");

                }
                else
                {
                    var Hesap = db.hesap.Where(p => p.hesapNo == textBox1.Text).FirstOrDefault();
                    int sontutar = hesaptutar-tutar;
                    Hesap.hesapPara = sontutar;
                    int sonuc = db.SaveChanges();
                    hesapDefteri hesapdefteri = new hesapDefteri();
                    hesapdefteri.hesapDefteriTarih = DateTime.Now.ToShortDateString();
                    hesapdefteri.hesapTutarGirisi = "-";
                    hesapdefteri.hesapTutari = tutar;
                    hesapdefteri.hesapId = Convert.ToInt32(textBox4.Text);
                    db.hesapDefteri.Add(hesapdefteri);
                    db.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Para Çekme İşleminiz Gerçekleşti.");
                        dataGridView1.DataSource = db.hesap.ToList();

                    }
                    else
                    {
                        MessageBox.Show("Para Çekme İşlmeizide Bir Sorun Oluştu.");

                    }
                }
            }
        }
    }
}
