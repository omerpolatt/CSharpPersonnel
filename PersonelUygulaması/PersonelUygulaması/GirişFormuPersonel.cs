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
    public partial class GirişFormuPersonel : Form
    {
        public GirişFormuPersonel()
        {
            InitializeComponent();
        }


        // SQL BAĞLANTIMIZI KURMUŞ OLDUK BU KOD İLE 
        SqlConnection baglanti = new SqlConnection("Data Source=POLAT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Yönetici where KullaniciAdi = @p1 and Sifre = @p2", baglanti);
            
            komut.Parameters.AddWithValue("@p1",txtkullanıcıadı.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
               PersonelForm form = new PersonelForm();  // ana formumuzdan nesen üretip girişin doğruluğuna göre yeni penceremizi açamk için
                form.Show();
                this.Hide(); // admin giriş sayfasını kapatacak ytani gizleyecektir 
            }
            else
            {
                MessageBox.Show("!! HATALI KULLANICI ADI VEYA ŞİFRE GİRİŞİ !! ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            baglanti.Close();

            

        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtşifre.UseSystemPasswordChar =false;
            }
            else
            {
                txtşifre.UseSystemPasswordChar = true;
            }
        }
    }
}
