using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // sql komutlarını kullanmamız için eklediğimiz kütüphanemiz 

namespace PersonelUygulaması
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        // SQL BAĞLANTIMIZI KURMUŞ OLDUK BU KOD İLE 
        SqlConnection baglanti = new SqlConnection("Data Source=POLAT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");   

        // temizle butonu için yazdığımız fonksiyonumuz
        void temizle()
        {
            TxtPerid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMeslek.Text = "";
            MaskedMaas.Text = "";
            ComboSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            TxtAd.Focus(); // Yukarıdaki işlemlerden sonra imleçin ad a gelmesi için 

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            // BU BAĞLANTI ADRESİ OTOMATİK GELDİ SQL BAĞLANTIMIZI BAĞLADIĞIMIZ İÇİN 
            // BU KODU BİZ LİSTELE BUTONUNU İÇİNE ATTIK Kİ LİSTELE BUTONUNA BASINCA LİSTEMİZİ GÖSTERMESİ İÇİN 
            this.personelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // sql bağlantımızı açtık 

            SqlCommand komut = new SqlCommand("insert into Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", ComboSehir.Text);
            komut.Parameters.AddWithValue("@p4", MaskedMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery(); // Sql komutlarının çalıştırılması için kullanılır

            baglanti.Close(); // sql bağlantımız kapattık 
            MessageBox.Show("Kaydınız Tamamlanmıştır");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                {
                label8.Text = "True";
                }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "false";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // seçilen satır numarasını  'secilen' adlı değişkene atatık
                                                                    
            // form ekranındaki alanların bilgilerini secilen satırındaki değerlere göre eşleşemsini yapıyoruz
            TxtPerid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); // id nin yazısı = datagridview den secilen satırından 0.hücresinin değerine atamış olduk 
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            ComboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();    
            MaskedMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); 
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();




        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }

            else if (label8.Text == "False") 
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("DELETE From Personel Where Perid=@k1",baglanti); // komutsil adında sql işlemi için değişken atadık ve bununla delete iişlemini yapmış olacağız 
            komutsil.Parameters.AddWithValue("@k1", TxtPerid.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelleme = new SqlCommand("Update Personel SET PerAd=@1,PerSoyad=@2,PerSehir=@3,PerMaas =@4,PerDurum=@5,PerMeslek=@6 where Perid = @7",baglanti);
            guncelleme.Parameters.AddWithValue("@1", TxtAd.Text);
            guncelleme.Parameters.AddWithValue("@2", TxtSoyad.Text);
            guncelleme.Parameters.AddWithValue("@3", ComboSehir.Text);
            guncelleme.Parameters.AddWithValue("@4", MaskedMaas.Text);
            guncelleme.Parameters.AddWithValue("@5", label8.Text);
            guncelleme.Parameters.AddWithValue("@6", TxtMeslek.Text);
            guncelleme.Parameters.AddWithValue("@7", TxtPerid.Text);

            guncelleme.ExecuteNonQuery();
            
            baglanti.Close();

            MessageBox.Show("Personel Bilgisi Güncellendi");
        }

        private void Btnİstatistlik_Click(object sender, EventArgs e)
        {
            İstatislikFormPersonel fi = new İstatislikFormPersonel(); // Burada oluşturduğumuz formdan nesne  oluşturup
            //  Show() foksiyoun ile de gösterilmesini sağladık
            fi.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            GrafiklerPersonel gp = new GrafiklerPersonel();  // Burada oluşturduğumuz formdan nesne  oluşturup
            //  Show() foksiyoun ile de gösterilmesini sağladık
            gp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelRapor pr = new PersonelRapor();
            pr.Show();
        }
    }
}
