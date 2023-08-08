using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKAMATIK
{
    public partial class MusteriIslem : Form
    {
        public MusteriIslem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapHareket hh = new HesapHareket();
            hh.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();

        }

        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = Form1.adSoyad;
            lblHesapNo.Text = Form1.mID.ToString();

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            ParaCek pc = new ParaCek();
            pc.Show();
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            ParaYatir py = new ParaYatir();
            py.Show();
        }

        private void btnBakiyeGoruntule_Click(object sender, EventArgs e)
        {
            BakiyeGoruntule b = new BakiyeGoruntule();
            b.Show();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            HavaleEft he = new HavaleEft();
            he.Show();

        }

        private void btnSifreDegistir_Click_1(object sender, EventArgs e)
        {
            SifreDegistirme sd = new SifreDegistirme();
            sd.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DovizKuru dk = new DovizKuru(); 
            dk.Show();
        }
    }
}
