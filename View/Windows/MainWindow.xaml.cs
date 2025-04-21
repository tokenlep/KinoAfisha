using KinoAfisha.AppData;
using KinoAfisha.View.Pages;
using System.Windows;
using System.Windows.Controls;

namespace KinoAfisha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Открываем начальную страницу
            
            ClassFrame.mainFrame = new Frame();
            MainFrame.Navigate(new AfishaPage());

            //ClassFrame.mainFrame = MainFrame;
            //MainFrame.Navigate(new EnterPage());
        }

        private void AfishaBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AfishaPage());

        }

        private void ScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SchedulePage());
        }
    }
}
