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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
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
            SqlCommand komut = new SqlCommand("update musteriler set durum= @p1 where ID= @p2 or  tcNo= @p2 ", con);
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);
            komut.Parameters.AddWithValue("@p3", txtAra.Text);


            DialogResult dr = MessageBox.Show("Müşteri Kaydını Silmek İstediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dr==DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi!", "Silme İşlemi İptali", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                if(sonuc==1)
                {
                    MessageBox.Show("Silme İşlemi Gerçekleştirildi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Gerçekleştirilemedi!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            con.Close();
            txtID.Text = "";
            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            txtBakiye.Text = "";
            
        }
    }
}
