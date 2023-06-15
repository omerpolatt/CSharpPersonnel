using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PersonelUygulaması
{
    public partial class İstatislikFormPersonel : Form
    {
        public İstatislikFormPersonel()
        {
            InitializeComponent();
        }

        // SQL BAĞLANTIMIZI KURMUŞ OLDUK BU KOD İLE 
        SqlConnection baglanti = new SqlConnection("Data Source=POLAT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void İstatislikFormPersonel_Load(object sender, EventArgs e)
        {
            // Toplam  Personel Sayısını Bulduğumuz sorgumuz
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Personel ", baglanti); // burada sql de kullancağiımız sorgumuzu yazarız 

            SqlDataReader dr1 = komut1.ExecuteReader();   // DataReader sql sorgularını okuyan bileşendir komut1 ile de çalıştırmiş olduk
            while(dr1.Read())
            {
                labelPersonelSyayısı.Text = dr1[0].ToString(); // sorgu sonucu tabloda çıkan ilk indeks değerinde istedğimiz sonuç olduğu için 0. index mantığını kullandık 
            }

            baglanti.Close();


            // Evli Personel Sayısıı 

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) from Personel where (PerDurum = 1)", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblEvliSayı.Text = dr2[0].ToString();
            }

            baglanti.Close();


            // Bekar Personel Sayısıı 

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) from Personel where (PerDurum = 0)", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblBekarsayi.Text = dr3[0].ToString();
            }

            baglanti.Close();

            // şehir sayısı

            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select Count(Distinct(PerSehir)) from Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblŞehirsayi.Text = dr4[0].ToString();
            }

            baglanti.Close();

            // Toplam maaş 

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select SUM(PerMaas) from Personel", baglanti);

            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString(); 

            }

            baglanti.Close();


            // ortalama maaş 


            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select AVG(PerMaas) from Personel", baglanti);

            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                lblOrtMaas.Text = dr6[0].ToString();

            }

            baglanti.Close();




        }

     
    }
}
