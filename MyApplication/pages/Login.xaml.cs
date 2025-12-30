using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyApplication.pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private string connectionString = @"Data Source=C:\Users\User\source\repos\shanidai1234567-code\MySolutionProjectFE\ViewModel\DatabaseBySup.accdb;";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("אנא הכנס סיסמה", "שגיאה", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CheckUserPassword(password))
            {
                MessageBox.Show("התחברת בהצלחה כמשתמש!", "ברוך הבא", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("סיסמה שגויה", "שגיאה", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnAdminLogin_Click(object sender, RoutedEventArgs e)
        {
            string password = txtPassword.Password;
            string adminPassword = "123";

            if (password == adminPassword)
            {
                MessageBox.Show("שלום מנהל, המערכת מוכנה", "כניסת מנהל", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("סיסמת מנהל שגויה!", "אבטחה", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }


        private bool CheckUserPassword(string pass)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM Person WHERE Password = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pass", pass);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בחיבור למסד הנתונים: " + ex.Message);
                return false;
            }
        }
    }
}
