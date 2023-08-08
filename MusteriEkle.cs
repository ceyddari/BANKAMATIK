using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BANKAMATIK
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into musteriler (tcNo, adSoyad, adres, telefon, sifre, bakiye, durum) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7 ) ", con  );
            komut.Parameters.AddWithValue("@p1", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text); 
            komut.Parameters.AddWithValue("@p3", txtAdres.Text);
            komut.Parameters.AddWithValue("@p4", txtTel.Text); 
            komut.Parameters.AddWithValue("@p5", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p6", txtBakiye.Text);
            komut.Parameters.AddWithValue("@p7", 1);

            if (txtTcNo.Text=="" || txtAdSoyad.Text == "" || txtAdres.Text == "" || txtAdres.Text == "" || txtTel.Text == "" || txtBakiye.Text == "")
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Giriniz!", "Müşteri Kaydı Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1)
                    MessageBox.Show("Yeni Müşteri Kaydı Tamamlandı", "Müşteri Kaydı");
                else
                    MessageBox.Show("Yeni Kayıt Yapılamadı!", "Müşteri Kaydı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           

            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            txtBakiye.Text = "";

        }

        private void txtBakiye_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
