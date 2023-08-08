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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server= ceyda\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler", con);
            SqlDataAdapter da = new SqlDataAdapter(komut );
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where adSoyad like'"+ textBox1.Text + "%' ", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
