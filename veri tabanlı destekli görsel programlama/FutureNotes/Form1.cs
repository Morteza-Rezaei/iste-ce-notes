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

namespace FutureNotes
{
    public partial class Form1 : Form
    {
        // SQL Server connection string
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            // Timer'ı başlatır
            timer.Start();

            // upComingNotes'e sütunlar eklenir
            upComingNotes.Columns.Add("recipient", "Alıcı");
            upComingNotes.Columns.Add("note", "Not");
            upComingNotes.Columns.Add("display_date", "Görüntüleme Tarihi");
            upComingNotes.Columns.Add("created_at", "Oluşturulma Tarihi");

            // expiredNotes'e sütunlar eklenir
            expiredNotes.Columns.Add("recipient", "Alıcı");
            expiredNotes.Columns.Add("note", "Not");
            expiredNotes.Columns.Add("display_date", "Görüntüleme Tarihi");
            expiredNotes.Columns.Add("created_at", "Oluşturulma Tarihi");



            // upComingNotes ve expiredNotes DataGridView'lerinin boyutlarını ayarlar
            upComingNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            expiredNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // note içeriğinin çok satırlı olmasını sağlar
            upComingNotes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            expiredNotes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // note içeriğinin oto boyutlanmasını sağlar
            upComingNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            expiredNotes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // satırların içeriğini en üstten başlatır
            upComingNotes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            expiredNotes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            // Notları güncellemek için
            RefreshData();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Notu veritabanına ekleme sorgusu
            string query = "INSERT INTO Future_Notes (recipients, note, display_date, created_at) VALUES (@recipients, @note, @displayDate, @createdAt)";

            // using ile bağlantıyı açıp işlem bittikten sonra kapatıyoruz
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL sorgusunu ve bağlantıyı parametre olarak veriyoruz
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametrelerin değerlerini atıyoruz
                    command.Parameters.AddWithValue("@recipients", recipients.Text);
                    command.Parameters.AddWithValue("@note", note.Text);
                    command.Parameters.AddWithValue("@displayDate", dateTimePicker.Value);
                    command.Parameters.AddWithValue("@createdAt", DateTime.Now);

                    // Bağlantıyı açıyoruz
                    connection.Open();

                    // Sorguyu çalıştırıyoruz
                    int result = command.ExecuteNonQuery();

                    // eğer sorgu başarılı bir şekilde çalıştıysa
                    if (result > 0)
                    {
                        MessageBox.Show("Not başarıyla eklendi.");
                    }
                    // eğer sorgu çalışmadıysa
                    else
                    {
                        MessageBox.Show("Not eklenirken bir hata oluştu.");
                    }

                    // Formu temizliyoruz
                    recipients.Text = "";
                    note.Text = "";
                    dateTimePicker.Value = DateTime.Now;

                    // Bağlantıyı kapatıyoruz
                    connection.Close();
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // using ile bağlantıyı açıp işlem bittikten sonra kapatıyoruz
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // veritabanındaki notları Güncellemek için
                string query = "SELECT * FROM Future_Notes";

                // SQL sorgusunu ve bağlantıyı parametre olarak veriyoruz
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Bağlantıyı açıyoruz
                    connection.Open();

                    // Sorgudan dönen verileri okumak için bir SqlDataReader oluşturuyoruz
                    SqlDataReader reader = command.ExecuteReader();

                    // Eğer veri varsa
                    if (reader.HasRows)
                    {
                        // upComingNotes temizlenir
                        upComingNotes.Rows.Clear();
                        // expiredNotes temizlenir
                        expiredNotes.Rows.Clear();

                        while (reader.Read())
                        {
                            // Tarihi gelecek Notlar upComingNotes'e yüklenir
                            if (DateTime.Compare((DateTime)reader["display_date"], DateTime.Now) > 0)
                            {
                                // upComingNotes'e veri eklenir
                                upComingNotes.Rows.Add(reader["recipients"], reader["note"], reader["display_date"], reader["created_at"]);
                            }
                            // Tarihi geçmiş Notlar expiredNotes'e yüklenir
                            if (DateTime.Compare((DateTime)reader["display_date"], DateTime.Now) < 0)
                            {
                                // expiredNotes'e veri eklenir
                                expiredNotes.Rows.Add(reader["recipients"], reader["note"], reader["display_date"], reader["created_at"]);
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void CheckForNote()
        {
            // otomatik olarak eğer tarih şimdiki zamana eşitse kullanıcıya notu gösterir
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // veritabanındaki notları Güncellemek için
                string query = "SELECT * FROM Future_Notes";

                // SQL sorgusunu ve bağlantıyı parametre olarak veriyoruz
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Bağlantıyı açıyoruz
                    connection.Open();

                    // Sorgudan dönen verileri okumak için bir SqlDataReader oluşturuyoruz
                    SqlDataReader reader = command.ExecuteReader();

                    // Eğer veri varsa
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Eğer notun görüntüleme tarihi şu anki tarihe eşitse notu gösterir
                            // bu yüzden sadece saat ve dakika kıyası yapılır ve milisaniye göz ardı edilir
                            // tarih saat ve dakikayi önce değişkene atarız
                            int year = ((DateTime)reader["display_date"]).Year;
                            int month = ((DateTime)reader["display_date"]).Month;
                            int day = ((DateTime)reader["display_date"]).Day;
                            int hour = ((DateTime)reader["display_date"]).Hour;
                            int minute = ((DateTime)reader["display_date"]).Minute;

                            DateTime displayDate = new DateTime(year, month, day, hour, minute, 0);

                            // şu anki tarihi alırız
                            DateTime now = DateTime.Now;
                            now = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);

                            if (DateTime.Compare(displayDate, now) == 0)
                            {
                                MessageBox.Show(reader["note"].ToString(), "Not");
                                // mesajı sadece bir kez göstermek döngüyü kırar
                                break;
                            }
                        
                        }
                    }
                    connection.Close();
                    
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer'ın interval'i (60000) kadar sürede bir CheckForNote fonksiyonunu çalıştırır
            Task.Run(() => CheckForNote());
        }
    }
}
