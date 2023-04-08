using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBankaOtomasyonu
{
    public partial class frmHesapDefteri : Form
    {
        public frmHesapDefteri()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmHesapDefteri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.hesap.ToList();
        }

        private void txtHesap_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.hesap.Where(p => p.hesapNo.Contains(txtHesap.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hesap = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = hesap;
            int hesapp = Convert.ToInt32(hesap);
            dataGridView2.DataSource = db.hesapDefteri.Where(p => p.hesapId == hesapp).ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        PrintDialog PRD = new PrintDialog();
        public string adi,soyadi,tc;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int sorgu = Convert.ToInt32(textBox1.Text);
            var hesap = db.hesap.Where(p => p.hesapID == sorgu).FirstOrDefault();
            var musteriii = db.musteri.Where(p => p.musteriTc == hesap.musteriNo).FirstOrDefault();
            adi = musteriii.musteriAd;
            soyadi = musteriii.musteriSoyad;
            tc = musteriii.musteriTc;
            PrintDocument Kagit = new PrintDocument();
            DialogResult yazdirmaislemi;
            yazdirmaislemi = PRD.ShowDialog();
            Kagit.PrintPage += Kagit_PrintPage;


            if (yazdirmaislemi==DialogResult.OK)
            {
                Kagit.Print();
            }
        }
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font yazi = new Font("Arial", 12);
            SolidBrush Kalem = new SolidBrush(Color.Black);
            e.Graphics.DrawString("Ad:", yazi, Kalem,10,20);
            e.Graphics.DrawString(adi, yazi, Kalem, 50 ,20) ;
            e.Graphics.DrawString("Soyad:", yazi, Kalem, 10, 40);
            e.Graphics.DrawString(soyadi, yazi, Kalem, 70, 40);
            e.Graphics.DrawString("TC:", yazi, Kalem, 10, 60);
            e.Graphics.DrawString(tc, yazi, Kalem, 50, 60);
            //Bitmap objBmp = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            //dataGridView2.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            //e.Graphics.DrawImage(objBmp, 80, 80);
            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < dataGridView2.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= dataGridView2.Rows.Count)
                    {

                        height += dataGridView2.Rows[0].Height;
                        e.Graphics.DrawString(dataGridView2.Rows[l].Cells[0].FormattedValue.ToString(), dataGridView2.Font = new Font("Arial", 8), Brushes.Black, new RectangleF(80, height, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView2.Rows[l].Cells[1].FormattedValue.ToString(), dataGridView2.Font = new Font("Arial", 8), Brushes.Black, new RectangleF(250, height, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView2.Rows[l].Cells[2].FormattedValue.ToString(), dataGridView2.Font = new Font("Arial", 8), Brushes.Black, new RectangleF(320, height, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView2.Rows[l].Cells[3].FormattedValue.ToString(), dataGridView2.Font = new Font("Arial", 8), Brushes.Black, new RectangleF(400, height, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));

                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }
    }
}
