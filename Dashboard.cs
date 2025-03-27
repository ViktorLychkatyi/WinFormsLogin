using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsLogin
{
    public partial class Dashboard : Form
    {
        IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .Build();

        private string currentUsername;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Hide();
            login.FormClosed += (s, args) => this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string username = Login.GetLoggedInUsername();
            label1.Text = username;
            LoadUserProfilePicture(username);
        }

        private void LoadUserProfilePicture(string username)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT profile_picture FROM Info WHERE Username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    object result = command.ExecuteScalar();
                    if (result != null && result is byte[] imageBytes)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
