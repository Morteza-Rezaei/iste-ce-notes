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

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        // SQL Server bağlantı stringi
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            // DataGridView'e sütunlar eklenir
            dataGridView1.Columns.Add("StudentId", "Öğrenci No");
            dataGridView1.Columns.Add("FirstName", "Ad");
            dataGridView1.Columns.Add("LastName", "Soyad");
            dataGridView1.Columns.Add("Email", "E-Posta");
            dataGridView1.Columns.Add("DateOfBirth", "Doğum Tarihi");
            dataGridView1.Columns.Add("EnrolledDate", "Kayıt Tarihi");

            // DataGridView manuel olarak sütun genişlikleri ayarlanabilir
            //dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[1].Width = 150;
            //dataGridView1.Columns[2].Width = 150;
            //dataGridView1.Columns[3].Width = 200;
            //dataGridView1.Columns[4].Width = 100;
            //dataGridView1.Columns[5].Width = 100;

            // DataGridView otomatik olarak sütun genişlikleri ayarlanabilir
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RefreshData();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // aynı bilgilerle öğrenci eklenmemesi için kontrol
                string checkQuery = "SELECT COUNT(*) FROM StudentRegistration WHERE FirstName = @FirstName AND LastName = @LastName AND Email = @Email";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@FirstName", firstNameTb.Text);
                    checkCommand.Parameters.AddWithValue("@LastName", lastNameTb.Text);
                    checkCommand.Parameters.AddWithValue("@Email", emailTb.Text);

                    connection.Open();

                    object result = checkCommand.ExecuteScalar();
                    int existingCount = (result != null) ? Convert.ToInt32(result) : 0;

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Bu öğrenci zaten kayıtlı.");
                        return;
                    }
                    connection.Close(); // veritabanı bağlantısı kapatılır
                }

                // öğrenci ekleme sorgusu
                string query = "INSERT INTO StudentRegistration (FirstName, LastName, Email, DateOfBirth, EnrolledDate) VALUES (@FirstName, @LastName, @Email, @DateOfBirth, @EnrolledDate)";

                // using ile connection açılır ve kapatılır
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // parametreler
                    command.Parameters.AddWithValue("@FirstName", firstNameTb.Text);
                    command.Parameters.AddWithValue("@LastName", lastNameTb.Text);
                    command.Parameters.AddWithValue("@Email", emailTb.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirthDp.Value);
                    command.Parameters.AddWithValue("@EnrolledDate", DateTime.Now);

                    // connection açılır
                    connection.Open();

                    // sorgu çalıştırılır
                    int result = command.ExecuteNonQuery();

                    // eğer sorgu başarılı ise
                    if (result > 0)
                    {
                        MessageBox.Show("Öğrenci başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci eklenirken bir hata oluştu.");
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
                // veritabanından kitap listesini çeken sorgu
                string query = "SELECT * FROM StudentRegistration";

                // using ile connection açılır ve kapatılır
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // connection açılır
                    connection.Open();

                    // sorgudan dönen verileri almak için bir SqlDataReader oluşturulur
                    SqlDataReader reader = command.ExecuteReader();

                    // eğer veri varsa
                    if (reader.HasRows)
                    {
                        // datagridview temizlenir
                        dataGridView1.Rows.Clear();

                        // sorgu sonucu okunur
                        while (reader.Read())
                        {
                            // okunan veriler datagridview'e eklenir
                            dataGridView1.Rows.Add(reader["StudentId"], reader["FirstName"], reader["LastName"], reader["Email"], reader["DateOfBirth"], reader["EnrolledDate"]);
                        }
                    }
                    connection.Close(); // veritabanı bağlantısı kapatılır
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
