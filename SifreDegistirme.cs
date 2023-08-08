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
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEski.Text == "" || txtYeni.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Eksiksiz Doldurunuz", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(txtYeni.Text.Length<5)
            {
                MessageBox.Show("Yeni Şifre 5 Karakterden Fazla Olmalıdır", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(txtEski.Text==txtYeni.Text)
            {
                MessageBox.Show("Yeni Şifre Eski Şifre ile Aynı Olmamalıdır.", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where sifre = @p2 ", con);
                komut.Parameters.AddWithValue("@p1", txtYeni.Text);
                komut.Parameters.AddWithValue("@p2", txtEski.Text);

                con.Open();

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi Gerçekleştirildi", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HareketKaydet.kaydet(Form1.mID, "Şifre Değiştirildi");

                }
                else
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarısız!", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                con.Close();
                
            }
            txtYeni.Text = "";
            txtEski.Text = "";

        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {

        }
    }
    
}
