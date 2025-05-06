using KinoAfisha.AppData;
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
    /// Логика взаимодействия для AdministrationFilmPage.xaml
    /// </summary>
    public partial class AdministrationFilmPage : Page
    {
        public AdministrationFilmPage()
        {
            InitializeComponent();
        }

        private void AddFilmBtn_Click(object sender, RoutedEventArgs e)
        {
            // Проверка наличия введённых данных
            if (string.IsNullOrEmpty(TitleTb.Text) ||
                string.IsNullOrEmpty(GenreCmb.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(FullDescriptionTb.Text))
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            

            // Создание экземпляра фильма
            var film = new Film
            {
                Poster = PosterTb.Text,
                Title = TitleTb.Text,
                Genre = (Genre)GenreCmb.SelectedItem,
                Video = VideoTb.Text,
                FullDescription = FullDescriptionTb.Text
            };

            // Сохранение фильма (сюда добавьте логику сохранения, например, в базу данных)
            SaveFilm(film);

            var filmCrew = new FilmCrew
            {
                IdFilm = film.Id,
                //IdCinematographer,
                //IdRole = film.Id,
            };

            // Очистка полей
            ResetForm();


        }
        private void SaveFilm(Film film)
        {
            // Сюда вставляете реальную логику сохранения фильма в базу данных или службу
            MessageBox.Show("Фильм успешно добавлен.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ResetForm()
        {
            PosterTb.Clear();
            TitleTb.Clear();
            GenreCmb.SelectedIndex = -1;
            VideoTb.Clear();
            FullDescriptionTb.Clear();
            //DirectorsCmb.SelectedIndex = -1;
            //DirectorsTb.Clear();
            //ActorsCmb.SelectedIndex = -1;
            //ActorsTb.Clear();
        }

        private void AddFilmCreatorBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = new Frame();
            AddFilmCreatorPage addFilmCreatorPage = new AddFilmCreatorPage();
        }
    }
}
