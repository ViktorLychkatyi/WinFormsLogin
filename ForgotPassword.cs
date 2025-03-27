using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WinFormsLogin
{
    public partial class ForgotPassword : Form
    {
        IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .Build();

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Hide();
            login.FormClosed += (s, args) => this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string login = textBox3.Text.Trim();
                string new_password = textBox1.Text.Trim();
                string confirm_password = textBox2.Text.Trim();
                string hashedPassword = HashPassword(new_password);

                if (new_password != confirm_password)
                {
                    MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string checkQuery = "SELECT COUNT(*) FROM Info WHERE Username = @username";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", login);
                    int userExists = (int)checkCommand.ExecuteScalar();

                    if (userExists == 1)
                    {
                        string updateQuery = "UPDATE Info SET Password = @newPassword WHERE Username = @username";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@username", login);
                            updateCommand.Parameters.AddWithValue("@newPassword", hashedPassword);
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Пароль успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Login loginn = new Login();
                                loginn.StartPosition = FormStartPosition.CenterScreen;
                                loginn.Show();

                                this.Hide();
                                loginn.FormClosed += (s, args) => this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при изменении пароля! Запись не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
