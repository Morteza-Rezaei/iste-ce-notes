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

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        // SQL Server bağlantı stringi
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            // DataGridView'e sütunlar eklenir
            dataGridView1.Columns.Add("BookId", "Kitap id");
            dataGridView1.Columns.Add("Title", "Kitap ismi");
            dataGridView1.Columns.Add("Author", "Kitap yazarı");
            dataGridView1.Columns.Add("ISBN", "ISBN");
            dataGridView1.Columns.Add("Available", "Mevcut");

            // DataGridView manuel olarak sütun genişlikleri ayarlanabilir
            //dataGridView1.Columns["BookId"].Width = 50;
            //dataGridView1.Columns["Title"].Width = 200;
            //dataGridView1.Columns["Author"].Width = 150;
            //dataGridView1.Columns["ISBN"].Width = 100;
            //dataGridView1.Columns["Available"].Width = 75;

            // DataGridView otomatik olarak sütun genişlikleri ayarlanabilir
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RefreshData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // aynı kitabın var olup olmadığını kontrol eden sorgu
                string checkQuery = "SELECT COUNT(*) FROM LibraryManagement WHERE Title = @Title AND Author = @Author AND ISBN = @ISBN AND Available = @Available";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Title", titleTb.Text);
                    checkCommand.Parameters.AddWithValue("@Author", authorTb.Text);
                    checkCommand.Parameters.AddWithValue("@ISBN", isbnTb.Text);
                    checkCommand.Parameters.AddWithValue("@Available", availableCb.Text);

                    connection.Open();

                    object result = checkCommand.ExecuteScalar();
                    int existingCount = (result != null) ? Convert.ToInt32(result) : 0;

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Bu kitap zaten kitaplıkta mevcut");
                        return;
                    }
                    connection.Close(); // veritabanı bağlantısı kapatılır
                }

                // kitap ekleme sorgusu
                string query = "INSERT INTO LibraryManagement (Title, Author, ISBN, Available) VALUES (@Title, @Author, @ISBN, @Available)";

                // using ile connection açılır ve kapatılır
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // parametrelerin değerleri atanır
                    command.Parameters.AddWithValue("@Title", titleTb.Text);
                    command.Parameters.AddWithValue("@Author", authorTb.Text);
                    command.Parameters.AddWithValue("@ISBN", isbnTb.Text);
                    command.Parameters.AddWithValue("@Available", availableCb.Text);

                    // connection açılır
                    connection.Open();

                    // sorgu çalıştırılır
                    int result = command.ExecuteNonQuery();

                    // sorgu başarılı ise
                    if (result > 0)
                    {
                        MessageBox.Show("Kitap başarıyla eklendi");
                    }
                    // sorgu başarısız ise
                    else
                    {
                        MessageBox.Show("Bir hata oluştu lütfen bilgileri kontrol edip tekrar deneyin");
                    }
                    connection.Close(); // veritabanı bağlantısı kapatılır

                    // datagridview yenilenir
                    //RefreshData();
                }
            }
        }

        // Kitap listesini veritabanından çeker ve datagridview'e yükler
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // kitap listesi sorgusu
                string query = "SELECT * FROM LibraryManagement";

                // using ile connection açılır ve kapatılır
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // connection açılır
                    connection.Open();

                    // sorgu sonucu okunur
                    SqlDataReader reader = command.ExecuteReader();

                    // datagridview temizlenir
                    dataGridView1.Rows.Clear();

                    // sorgu sonucu okunur
                    while (reader.Read())
                    {
                        // okunan veriler datagridview'e eklenir
                        dataGridView1.Rows.Add(reader["BookId"], reader["Title"], reader["Author"], reader["ISBN"], reader["Available"]);
                    }

                    connection.Close(); // veritabanı bağlantısı kapatılır
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // kitap silme sorgusu
                string query = "DELETE FROM LibraryManagement WHERE Title = @Title AND Author = @Author AND ISBN = @ISBN AND Available = @Available";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // parametrelerin değerleri atanır
                    command.Parameters.AddWithValue("@Title", titleTb.Text);
                    command.Parameters.AddWithValue("@Author", authorTb.Text);
                    command.Parameters.AddWithValue("@ISBN", isbnTb.Text);
                    command.Parameters.AddWithValue("@Available", availableCb.Text);

                    // connection açılır
                    connection.Open();

                    // sorgu çalıştırılır
                    int result = command.ExecuteNonQuery();

                    // sorgu başarılı ise
                    if (result > 0)
                    {
                        MessageBox.Show("Kitap başarıyla silindi");
                    }
                    // sorgu başarısız ise
                    else
                    {
                        MessageBox.Show("Bir hata oluştu lütfen bilgileri kontrol edip tekrar deneyin");
                    }

                    // datagridview yenilenir
                    //RefreshData();

                    connection.Close(); // veritabanı bağlantısı kapatılır
                }
            }
        }
    }
}
