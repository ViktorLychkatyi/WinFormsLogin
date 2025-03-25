using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using System.Xml;
namespace WinFormsLogin;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string connectionString = "Server=localhost; Database=BaseUsers; Integrated Security=True; TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            string query = "SELECT * FROM Info WHERE Username = @username AND Password = @password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", login);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        OpenDashboard();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

    private void OpenDashboard()
    {
        Dashboard dashboard = new Dashboard();
        dashboard.StartPosition = FormStartPosition.CenterScreen;
        dashboard.Show();
        this.Hide();
        dashboard.FormClosed += (s, args) => this.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Registration registration = new Registration();
        registration.StartPosition = FormStartPosition.CenterScreen;
        registration.Show();

        this.Hide();
        registration.FormClosed += (s, args) => this.Close();
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        ForgotPassword forgot_password = new ForgotPassword();
        forgot_password.StartPosition = FormStartPosition.CenterScreen;
        forgot_password.Show();

        this.Hide();
        forgot_password.FormClosed += (s, args) => this.Close();
    }
}
