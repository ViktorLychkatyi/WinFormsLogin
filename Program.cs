using Microsoft.Data.SqlClient;

namespace WinFormsLogin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string connectionString = "Server=localhost; Database=BaseUsers; TrustServerCertificate=True;";
            Application.Run(new Login());

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    //MessageBox.Show("Connection successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}