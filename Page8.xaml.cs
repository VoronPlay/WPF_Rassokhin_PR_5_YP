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
    /// Логика взаимодействия для Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        public Page8()
        {
            InitializeComponent();


            Person johnSmith = new Person();

            johnSmith.Место = "Вход офис";
            johnSmith.Точка = "У двери";
            johnSmith.Серийный_номер = "55484403";
            johnSmith.IP_адрес = "192.168.201.23";
            johnSmith.MAC_адрес = "00:60:36:22:82:СБ";
            johnSmith.Состояние_подключения = "Подключено";
            johnSmith.Дата_и_время_Детектора = "2016.06.24 04:04:38";

            DataGridXAML.Items.Add(johnSmith);

        }
        public class Person
        {
            public string Место { get; set; }
            public string Точка { get; set; }
            public string Серийный_номер { get; set; }
            public string IP_адрес { get; set; }
            public string MAC_адрес { get; set; }
            public string Состояние_подключения { get; set; }
            public string Дата_и_время_Детектора { get; set; }


        }


    }
}