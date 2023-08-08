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
    public partial class SifreUret : Form
    {
        public SifreUret()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
        private void label4_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "" || txtTel.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Eksiksiz Doldurunuz", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtSifre.Text.Length < 5)
            {
                MessageBox.Show("Yeni Şifre 5 Karakterden Fazla Olmalıdır", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where tcNo= @p2 and telefon = @p3 ", con);
                komut.Parameters.AddWithValue("@p1", txtSifre.Text);
                komut.Parameters.AddWithValue("@p2", txtTc.Text);
                komut.Parameters.AddWithValue("@p3", txtTel.Text);

                con.Open();

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Şifre Oluşturma İşlemi Gerçekleştirildi", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //HareketKaydet.kaydet(Form1.mID, "Şifre Oluşturuldu");

                }
                else
                {
                    MessageBox.Show("Şifre Oluşturma İşlemi Başarısız!", "Şifre Oluşturma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                con.Close();

            }
            txtSifre.Text = "";
            txtTel.Text = "";
            txtTc.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SifreUret_Load(object sender, EventArgs e)
        {

        }
    }
}
