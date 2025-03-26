using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;

namespace WinFormsLogin
{
    public partial class Registration : Form
    {
        IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .Build();

        private string imagePath = "";
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для регистрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string username = textBox1.Text;
                string email = textBox2.Text;
                string password = textBox3.Text;
                string confrim_password = textBox4.Text;

                string hashedPassword = HashPassword(password);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM Info WHERE Username = @Username";
                    using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                    {
                        checkUserCommand.Parameters.AddWithValue("@Username", username);
                        int userExists = (int)checkUserCommand.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Пользователь с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string registerQuery = "INSERT INTO Info (Username, Email, Password, profile_picture) VALUES (@Username, @Email, @Password, @profile_picture)";
                    using (SqlCommand registerCommand = new SqlCommand(registerQuery, connection))
                    {
                        registerCommand.Parameters.AddWithValue("@Username", username);
                        registerCommand.Parameters.AddWithValue("@Email", email);
                        registerCommand.Parameters.AddWithValue("@Password", hashedPassword);

                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            registerCommand.Parameters.AddWithValue("@profile_picture", imagePath);
                        }
                        else
                        {
                            registerCommand.Parameters.AddWithValue("@profile_picture", DBNull.Value);
                        }

                        int rowsAffected = registerCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно зарегистрирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            login.StartPosition = FormStartPosition.CenterScreen;
                            login.Show();

                            this.Hide();
                            login.FormClosed += (s, args) => this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при регистрации пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            string confrim_password = textBox4.Text;

            Registration registration = new Registration();
            registration.StartPosition = FormStartPosition.CenterScreen;
            registration.Show();
            registration.LoadData(username, email, password, confrim_password);

            this.Hide();
            registration.FormClosed += (s, args) => this.Close();
        }

        public void LoadData(string username, string email, string password, string confrim_password)
        {
            textBox1.Text = username;
            textBox2.Text = email;
            textBox3.Text = password;
            textBox4.Text = confrim_password;
        }
    }
}
