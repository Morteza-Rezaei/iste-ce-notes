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

namespace ReservationForm
{
    public partial class Form1 : Form
    {
        // SQL Server bağlantı stringi
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan verileri değişkenlere 
            // string name = this.Controls["customerNameTb"].Text; // Bu şekilde de alınabilir.
            String name = customerNameTb.Text;
            String email = emailTb.Text;
            DateTime checkInDate = checkInDateTp.Value;
            DateTime checkOutDate = CheckOutDateTp.Value;

            // Veritabanı bağlantısı ve Kaydı Ekleme
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Reservations (CustomerName, Email, CheckInDate, CheckOutDate) VALUES (@Name, @Email, @CheckInDate, @CheckOutDate)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                    command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                    
                    // veritabanı bağlantısını aç
                    connection.Open();

                    // sorguyu çalıştır ve etkilenen satır sayısını döndür
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
                    }

                    // veritabanı bağlantısını kapat
                    connection.Close();
                }
            }
        }
    }
}
