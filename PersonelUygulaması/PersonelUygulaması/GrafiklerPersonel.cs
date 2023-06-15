using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelUygulaması
{
    public partial class GrafiklerPersonel : Form
    {
        public GrafiklerPersonel()
        {
            InitializeComponent();
        }

        // SQL BAĞLANTIMIZI KURMUŞ OLDUK BU KOD İLE 
        SqlConnection baglanti = new SqlConnection("Data Source=POLAT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {
            // 1. grafik için 
            baglanti.Open();

            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From Personel Group By PerSehir ", baglanti);

            SqlDataReader dr1= komutg1.ExecuteReader();
            while (dr1.Read()) 
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]); // dr[0] sql sorgusunun ilk değeri olan şehir adları için 
                                                                        // dr[1] sql sorgusunun 2. değeri yani count dan gelen sayılar için  değer tutmakta
            }

            baglanti.Close();



            // 2. grafik için 


            baglanti.Open();

            SqlCommand komutg2 = new SqlCommand("Select PerMeslek , Avg(PerMaas) from Personel group by PerMeslek ", baglanti);

            SqlDataReader dr2 = komutg2.ExecuteReader();

            while (dr2.Read())
            {
                chart2.Series["Meslek-Maaş"].Points.AddXY(dr2[0], dr2[1]);
            }



            baglanti.Close();







        }
    }
}
