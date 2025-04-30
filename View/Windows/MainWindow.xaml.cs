using KinoAfisha.AppData;
using KinoAfisha.View.Pages;
using KinoAfisha.View.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            ClassFrame.mainFrame = new Frame();
            MainFrame.Navigate(new AfishaPage());
        }

     

        private void AfishaBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AfishaPage());

        }

        private void ScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SchedulePage());
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt)
            {
                LoginWindow loginWindow =new LoginWindow();
                loginWindow.ShowDialog();
            }
        }

        
    }
}
