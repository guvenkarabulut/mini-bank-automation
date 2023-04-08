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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteri.ToList();
        }

        private void txtHesap_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.musteri.Where(p => p.musteriTc.Contains(txtHesap.Text)).ToList();

        }
    }
}
