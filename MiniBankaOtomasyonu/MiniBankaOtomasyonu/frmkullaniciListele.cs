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
    public partial class frmkullaniciListele : Form
    {
        public frmkullaniciListele()
        {
            InitializeComponent();
        }
        miniBankaOtomasyonuDBEntities db = new miniBankaOtomasyonuDBEntities();
        private void frmkullaniciListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kullanici.ToList();
        }

        private void txtHesap_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kullanici.Where(p => p.kullaniciTc.Contains(txtHesap.Text)).ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
