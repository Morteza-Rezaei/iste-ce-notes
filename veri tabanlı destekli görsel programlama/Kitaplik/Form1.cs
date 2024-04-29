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


namespace Kitaplik
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            Yenile();

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // kitap eklemek için SQL INSERT sorgusu
                string query = "INSERT INTO Kitaplar (KitapAdi, Yazar, YayinYili) VALUES (@ad, @yazar, @yil)";

                // using ile connection nesnesi açılır ve işlem bittiğinde kapatılır
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreler, SQL enjeksiyonunu önlemek için kullanılır
                    command.Parameters.AddWithValue("@ad", textBox1.Text);
                    command.Parameters.AddWithValue("@yazar", textBox2.Text);
                    command.Parameters.AddWithValue("@yil", dateTimePicker1.Value);


                    connection.Open(); // veritabanı bağlantısı açılır
                    command.ExecuteNonQuery(); // Sorguyu çalıştırır ve etkilenen satır sayısını döndürür
                    connection.Close(); // veritabanı bağlantısı kapatılır

                    MessageBox.Show("Kitap eklendi");
                    Yenile();
                }

            }
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        // Kitap listesini veritabanından çeker ve DataGridView1'e yükleyen fonksiyon
        private void Yenile()
        {
            // using ile connection nesnesi açılır ve işlem bittiğinde kapatılır
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // using ifadesi,SqlDataAdapter nesnesi işi bittiğinde otomatik olarak temizlenir
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Kitaplar", connection))
                {
                    DataTable table = new DataTable(); // verileri tutmak için bir tablo oluştur
                    adapter.Fill(table); // veritabanından verileri çek ve tabloya ekle
                    dataGridView1.DataSource = table; // DataGridView1'e tabloyu yükle
                }

            }
        }
    }
}
