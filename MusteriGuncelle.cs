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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID= @p1 or tcNo= @p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);

            con.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtID.Text = dr["ID"].ToString();
                txtTcNo.Text = dr["tcNo"].ToString();
                txtAdSoyad.Text = dr["adSoyad"].ToString();
                txtAdres.Text = dr["adres"].ToString();
                txtTel.Text = dr["telefon"].ToString();
                txtBakiye.Text = dr["bakiye"].ToString();
                txtDurum.Text = dr["durum"].ToString();

            }

            else
            {

                {
                    MessageBox.Show("Numaralı Kayıt Bulunamadı!", "Kayıt Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtTcNo.Text = "";
                    txtAdSoyad.Text = "";
                    txtAdres.Text = "";
                    txtTel.Text = "";
                    txtBakiye.Text = "";
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update musteriler set adSoyad=@p1, adres=@p2, telefon=@p3, durum = @p6 where ID= @p4 or tcNo= @p5 ", con);
            komut.Parameters.AddWithValue("@p4", txtAra.Text);
            komut.Parameters.AddWithValue("@p5", txtAra.Text);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtAdres.Text);
            komut.Parameters.AddWithValue("@p3", txtTel.Text);
            komut.Parameters.AddWithValue("@p6", Convert.ToByte(txtDurum.Text));

            con.Open();
            int sonuc=komut.ExecuteNonQuery();      

            if (sonuc==1)
            {
                MessageBox.Show("Güncelleme Yapıldı", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {

                {
                    MessageBox.Show("Güncelleme Yapılamadı!", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtTcNo.Text = "";
                    txtAdSoyad.Text = "";
                    txtAdres.Text = "";
                    txtTel.Text = "";
                    txtBakiye.Text = "";
                }
            }
            con.Close();
        }
    }
}
