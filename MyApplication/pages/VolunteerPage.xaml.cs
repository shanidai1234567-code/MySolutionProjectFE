using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Model;

namespace MyApplication.pages
{
    /// <summary>
    /// Interaction logic for VolunteerPage.xaml
    /// </summary>
    public partial class VolunteerPage : Page
    {
        public ObservableCollection<Report> Reports { get; set; }
        public VolunteerPage()
        {
            InitializeComponent();
            // אתחול הרשימה
            Reports = new ObservableCollection<Report>();

            // קישור הרשימה ל-ListBox שב-XAML
            lstReports.ItemsSource = Reports;

            // דוגמה לטעינת נתונים ראשונית
            LoadMockData();
        }

        private void LoadMockData()
        {
            Reports.Add(new Report
            {
          
            });

            Reports.Add(new Report
            {
                Title = "ליווי רפואי",
                Description = "ליווי אדם מבוגר לבדיקה בבית חולים",
                Location = "רמת גן",
                CategoryName = "עזרה רפואית",
                IsUrgent = false,
                TimeAgo = "לפני שעה"
            });
        }

        // פונקציה שאפשר לקרוא לה כשמתקבל דיווח חדש (למשל משרת או מטיימר)
        public void AddNewReport(Report newReport)
        {
            Reports.Insert(0, newReport); // מוסיף לראש הרשימה
        }
    }
}

