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

namespace AppointmentForm
{
    public partial class Form1 : Form
    {
        // SQL Server bağlantı stringi
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveAppointmentButton_Click(object sender, EventArgs e)
        {
            // Formdan verileri alıyoruz
            string patientName = patientNameTextBox.Text;
            string patientEmail = patientEmailTextBox.Text;
            DateTime appointmentDate = appointmentDateTimePicker.Value;
            string doctorName = doctorNameTextBox.Text;
            string department = departmentComboBox.SelectedItem != null ? departmentComboBox.SelectedItem.ToString() : "";

            // veritabanı kaydı
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Randevuyu veritabanına kaydeden SQL sorgusu
                string query = "INSERT INTO Appointments (PatientName, PatientEmail, AppointmentDate, DoctorName, Department) VALUES (@PatientName, @PatientEmail, @AppointmentDate, @DoctorName, @Department)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // SQL sorgusuna parametreleri ekliyoruz
                    command.Parameters.AddWithValue("@PatientName", patientName);
                    command.Parameters.AddWithValue("@PatientEmail", patientEmail);
                    command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@DoctorName", doctorName);
                    command.Parameters.AddWithValue("@Department", department);

                    // veritabanı bağlantısını açıyoruz ve soruguyu çalıştırıyoruz
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Rendevu kaydı başarılı mı kontrol ediyoruz
                    if (result > 0)
                    {
                        MessageBox.Show("Randevu başarıyla kaydedildi");
                    }
                    else
                    {
                        MessageBox.Show("Randevu kaydedilirken bir hata oluştu");
                    }
                }
            }


        }
    }
}
