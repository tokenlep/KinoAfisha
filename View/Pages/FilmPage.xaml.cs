using KinoAfisha.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для FilmPage.xaml
    /// </summary>
    public partial class FilmPage : Page
    {
        List<Film> film = App.context.Film.ToList();

        public FilmPage()
        {
            InitializeComponent();
            PosterLb.Items.Clear();
            PosterLb.ItemsSource = App.context.Film.ToList();
            
            MovieLb.Items.Clear();
            MovieLb.ItemsSource = App.context.Film.ToList();

            DescriptLb.ItemsSource = App.context.Film.ToList();
            CinemaLb.ItemsSource = App.context.Cinematographer.ToList();
        }
    }
}
