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
    /// Логика взаимодействия для AdministrationSchedulePage.xaml
    /// </summary>
    public partial class AdministrationSchedulePage : Page
    {
        public AdministrationSchedulePage()
        {
            InitializeComponent();
        }

        private void AddScheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            // Сбор введённых данных
            string title = TitleTb.Text.Trim();
            DateTime date = DatePickerDp.SelectedDate ?? DateTime.Today;
            string hours = HoursTb.Text.Trim();
            string minutes = MinutesTb.Text.Trim();
            string priceStr = PriceTb.Text.Trim();

            // Проверка полноты введённых данных
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(hours) || string.IsNullOrEmpty(minutes) || string.IsNullOrEmpty(priceStr))
            {
                MessageBox.Show("Необходимо заполнить все поля.");
                return;
            }

            // Парсинг времени
            if (!int.TryParse(hours, out int hour) || hour > 23 || hour < 0)
            {
                MessageBox.Show("Введите корректные часы (от 0 до 23)");
                return;
            }

            if (!int.TryParse(minutes, out int minute) || minute > 59 || minute < 0)
            {
                MessageBox.Show("Введите корректные минуты (от 0 до 59)");
                return;
            }

            // Парсинг цены
            if (!decimal.TryParse(priceStr, out decimal price))
            {
                MessageBox.Show("Введите корректную цену.");
                return;
            }

            // Объединение часа и минуты в единое время
            TimeSpan time = new TimeSpan(hour, minute, 0);

            // Здесь выполняйте логику сохранения данных (например, добавляйте в коллекцию или записывайте в базу данных)
            MessageBox.Show("Расписание успешно добавлено.");

            // Очистка полей
            TitleTb.Clear();
            HoursTb.Clear();
            MinutesTb.Clear();
            PriceTb.Clear();
        }

    }
}