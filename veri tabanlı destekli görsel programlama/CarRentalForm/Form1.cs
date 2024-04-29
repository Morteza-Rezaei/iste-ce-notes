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

namespace CarRentalForm
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void kaytdetButton_Click(object sender, EventArgs e)
        {
            string customerName = nameTextBox.Text;
            string email = emailTextBox.Text;
            DateTime rentalDate = rentalDateTimePicker.Value;
            DateTime returnDate = returnDateTimePicker.Value;
            string carModel = carModelTextBox.Text;
            int phone;
            bool isPhoneValid = int.TryParse(phoneTextBox.Text, out phone);
            if (!isPhoneValid)
            {
                MessageBox.Show("Telefon numarası geçersiz");
            }
            decimal price;
            bool isPriceValid = decimal.TryParse(priceTextBox.Text, out price);
            if (!isPriceValid)
            {
                MessageBox.Show("Fiyat geçersiz");
            }

            using (var connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO carRentals (CustomerName, Email, PickupDate, ReturnDate, CarModel, Telefon, Price) VALUES (@CustomerName, @Email, @RentalDate, @ReturnDate, @CarModel, @Phone, @Price)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@RentalDate", rentalDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.Parameters.AddWithValue("@CarModel", carModel);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Price", price);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Araç kiralama işlemi başarıyla kaydedildi");
                    }
                    else
                    {
                        MessageBox.Show("Araç kiralama işlemi sırasında bir hata oluştu");
                    }

                    connection.Close();

                }

            }
        }
    }
}
