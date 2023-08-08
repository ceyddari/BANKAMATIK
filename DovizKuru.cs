using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BANKAMATIK
{
    public partial class DovizKuru : Form
    {
        public DovizKuru()
        {
            InitializeComponent();
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));


                lblDolar.Text = "DOLAR:  " + dolar.ToString();
                lblEuro.Text = "EURO:  " + euro.ToString();
                lblSterlin.Text = "STERLIN:  " + sterlin.ToString();

            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }
        }
 




        private void lblTarih_Click(object sender, EventArgs e)
        {

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();

        }

        private void DovizKuru_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblDolar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
} 
