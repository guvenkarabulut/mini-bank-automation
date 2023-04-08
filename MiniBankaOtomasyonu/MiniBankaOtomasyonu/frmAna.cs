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
    public partial class frmAna : Form
    {
        public string tccc;
        public frmAna(kullanici girisYapankullanici)
        {
            InitializeComponent();
            menuAdmin.Visible = false;
            menuGise.Visible = false;
            menuMusteri.Visible = false;
            if (girisYapankullanici.kullaniciRol==1)
            {
                menuAdmin.Visible = true;
            }
            if (girisYapankullanici.kullaniciRol == 2)
            {
                menuGise.Visible = true;
            }
            if (girisYapankullanici.kullaniciRol == 3)
            {
                menuMusteri.Visible = true;

                tccc = girisYapankullanici.kullaniciTc;

            }
        }

        private void frmAna_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle kullanicEklee = new frmKullaniciEkle();
            kullanicEklee.MdiParent = this;
            kullanicEklee.Show();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkullaniciListele kullanicilistele = new frmkullaniciListele();
            kullanicilistele.MdiParent = this;
            kullanicilistele.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle musteriEklee = new frmMusteriEkle();
            musteriEklee.MdiParent = this;
            musteriEklee.Show();
        }

        private void krediKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmKrediHarcama frmkredih = new frmKrediHarcama();
            frmkredih.sorgulanactc = tccc;
            frmkredih.MdiParent = this;

            frmkredih.Show();

        }

        private void hesapParaÇEkmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void krediKartıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKrediKartiOlustur krediKarti = new frmKrediKartiOlustur();
            krediKarti.MdiParent = this;
            krediKarti.Show();
        }

        private void hesapParaCekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapPara hesappara = new frmHesapPara();
            hesappara.MdiParent = this;
            hesappara.Show();
        }

        private void hesapOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapOlustur hesapolustur = new frmHesapOlustur();
            hesapolustur.MdiParent = this;
            hesapolustur.Show();
        }

        private void hesapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapListele hesaplistele = new frmHesapListele();
            hesaplistele.MdiParent = this;
            hesaplistele.Show();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriListele musterilistele = new frmMusteriListele();
            musterilistele.MdiParent = this;
            musterilistele.Show();
        }

        private void hesapDefteriÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapDefteri hesapDefteri = new frmHesapDefteri();
            hesapDefteri.MdiParent = this;
            hesapDefteri.Show();
        }
    }
}
