using KinoAfisha.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

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
            FilmsLb.ItemsSource = App.context.Film.ToList();
            

        }

        
    }
}
