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
    public partial class frmHesapListele : Form
    {
        public frmHesapListele()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmHesapListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.hesap.ToList();

        }

        private void txtHesap_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.hesap.Where(p => p.hesapNo.Contains(txtHesap.Text)).ToList();

        }
    }
}
