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
using MyApplication.pages;


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
            string password = txtPassword.Password; // קבלת הסיסמה מה-PasswordBox

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("נא להזין סיסמה", "שגיאה", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (ValidateLogin(password))
            {
                // אם הסיסמה נכונה, עוברים לדף המתנדבים
                
            }
            else
            {
                MessageBox.Show("סיסמה שגויה!", "כניסה נכשלה", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private bool ValidateLogin(string pwd)
        {
            bool isValid = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // שאילתה שבודקת אם קיימת סיסמה כזו בטבלת המתנדבים
                    string query = "SELECT COUNT(*) FROM Volunteers WHERE Password = @pwd";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pwd", pwd); // שימוש בפרמטר למניעת SQL Injection

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0) isValid = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בחיבור למסד הנתונים: " + ex.Message);
            }

            return isValid;
        }
    }




}

