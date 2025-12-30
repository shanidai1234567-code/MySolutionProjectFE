using MyApplication.pages;
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

namespace MyApplication
{

    public partial class MainWindow : Window
    {

            // מחרוזת התחברות למסד הנתונים - שנה אותה לפי ההגדרות שלך
            private string connectionString = @"Data Source=C:\Users\User\source\repos\shanidai1234567-code\MySolutionProjectFE\ViewModel\DatabaseBySup.accdb;";

            public MainWindow()
            {
                InitializeComponent();
            }

        private void BtnGoToLogin_Click(object sender, RoutedEventArgs e)
        {
            Login loginWin = new Login(); // יצירת החלון שיצרנו קודם
            loginWin.Show(); // פתיחת חלון ההתחברות
            this.Close();    // סגירת החלון הנוכחי (הראשי)
        }

    }
    }

