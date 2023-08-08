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
    public partial class HavaleEft : Form
    {
        public HavaleEft()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
        private void HavaleEft_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(txtMiktar.Text);

            if (sayi>Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz Bakiye!", "Havale/EFT İşlemi");

            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye - @p1 where ID= @p2 ", con);
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.mID);

                SqlCommand komut2 = new SqlCommand("update musteriler set bakiye= bakiye + @p3 where ID= @p4 ", con);
                komut2.Parameters.AddWithValue("@p3", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p4", txtNo.Text);

                if (sayi<10)
                {
                    MessageBox.Show("Lütfen 10TL ve üzeri bir miktar giriniz!", "Eksik Kyaıt Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    con.Open();

                    int sonuc1 = komut2.ExecuteNonQuery();  
                    con.Close();

                    if(sonuc1==1)
                    {
                        con.Open();

                        komut.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Havale/EFT işlemi gerçekleştirildi.", "Havale/EFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1.mBakiye -= sayi;
                        HareketKaydet.kaydet(Form1.mID, (sayi + "TL Havale edildi."));
                        HareketKaydet.kaydet(int.Parse(txtNo.Text), (sayi + "TL Havale alındı."));

                    }
                    else
                    {
                        MessageBox.Show("Alıcı Hesap No Hatalı!", "Havale/EFT Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                txtMiktar.Text = "";
                txtNo.Text = "";

            }
        }
    }
}
