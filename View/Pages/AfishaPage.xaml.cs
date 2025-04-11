using KinoAfisha.Model;
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

namespace KinoAfisha.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AfishaPage.xaml
    /// </summary>
    /// 
    public partial class AfishaPage : Page
    {
        List<Film> film = App.context.Film.ToList();
        
        public AfishaPage()
        {
            InitializeComponent();
                        
        }

        private void FilmsLb_Loaded(object sender, RoutedEventArgs e)
        {
            FilmsLb.ItemsSource = App.context.Film.ToList();
        }
    }
}
