using KinoAfisha.AppData;
using KinoAfisha.View.Pages;
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
using System.Windows.Shapes;

namespace KinoAfisha.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdministratorWindow.xaml
    /// </summary>
    public partial class AdministratorWindow : Window
    {
        public AdministratorWindow()
        {
            InitializeComponent();
            ClassFrame.adminFrame = new Frame();
            AdminFrame.Navigate(new AdministrationFilmPage());
        }

        private void AdminFilmBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new AdministrationFilmPage());
        }

        private void AdminScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new AdministrationSchedulePage());
        }

        private void AddFilmCreatorBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new AddFilmCreatorPage());
        }
    }
}
