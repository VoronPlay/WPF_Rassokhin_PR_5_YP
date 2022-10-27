using System;
using System.Collections.Generic;
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

namespace WPF_Rassokhin_PR_5_YP
{
    /// <summary>
    /// Логика взаимодействия для Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();

            Person johnSmith = new Person();

            johnSmith.JobID = "1";
            johnSmith.JobData = "28/04/2015";
            johnSmith.UserID = "Admin";
            johnSmith.IssueSubject = "intial Logged Job";
            johnSmith.Screen = "intial Logged Job";
            johnSmith.Furtherlnformation = "intial Logged Job";
            johnSmith.JobStatus = "Closed";

            DataGridXAML.Items.Add(johnSmith);

            Person johnSmith2 = new Person();

            johnSmith2.JobID = "2";
            johnSmith2.JobData = "28/04/2015";
            johnSmith2.UserID = "geoffc";
            johnSmith2.IssueSubject = "Test 2";
            johnSmith2.Screen = "Test 2";
            johnSmith2.Furtherlnformation = "Test 2";
            johnSmith2.JobStatus = "Open";

            DataGridXAML.Items.Add(johnSmith2);
        }
        public class Person
        {
            public string JobID { get; set; }
            public string JobData { get; set; }
            public string UserID { get; set; }
            public string IssueSubject { get; set; }
            public string Screen { get; set; }
            public string Furtherlnformation { get; set; }
            public string JobStatus { get; set; }


        }
    }
}
