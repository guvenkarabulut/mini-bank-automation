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
    public partial class frmKrediHarcama : Form
    {
        public string sorgulanactc;
        public frmKrediHarcama()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmKrediHarcama_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.krediKarti.Where(p => p.musteriNo.Contains(sorgulanactc)).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string kartID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string kartNo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Limit = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string kalanLimit = dataGridView1.CurrentRow.Cells[4].Value.ToString();


            textBox1.Text = kartID;
            textBox2.Text = kartNo;
            textBox3.Text = Limit;
            textBox4.Text = kalanLimit;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox4.Text)<Convert.ToInt32(textBox5.Text))
            {
                MessageBox.Show("Kullanmak istediğniniz tutar yok.");
            }
            else
            {

                int sorguno = Convert.ToInt32(textBox1.Text);
                string textl = textBox2.Text;
                if (string.IsNullOrEmpty(textl))
                {
                    MessageBox.Show("Lütfen Kart Seçiniz.");

                }
                else
                {
                    var kredikarti = db.krediKarti.Where(p => p.krediKartiID == sorguno).FirstOrDefault();
                    kredikarti.krediKartıHarcanananTutar = Convert.ToInt32(textBox5.Text) + kredikarti.krediKartıHarcanananTutar;
                    kredikarti.krediKartiKalanTutar = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox5.Text);
                    db.SaveChanges();
                    krediKartiHarcanan kredikartih = new krediKartiHarcanan();
                    kredikartih.Kategori = comboBox1.Text;
                    kredikartih.krediKartiHarccananTutar = textBox5.Text;
                    kredikartih.krediKartiNo = Convert.ToInt32(textBox1.Text);
                    db.krediKartiHarcanan.Add(kredikartih);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşleminiz Tamamlandı.");
                    }

                }

            }


        }
    }
}
