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

namespace Kullanici_kayit_form
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-N88BE0R;Initial Catalog=iste;Integrated Security=True;Trust Server Certificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO kullanicilar (KullaniciAdi, Eposta, Sifre) VALUES (@kadi, @eposta, @sifre)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kadi", textBox1.Text);
                        command.Parameters.AddWithValue("@eposta", textBox2.Text);
                        command.Parameters.AddWithValue("@sifre", textBox3.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı başarıyla eklendi.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message);
            }
        }
    }
}
