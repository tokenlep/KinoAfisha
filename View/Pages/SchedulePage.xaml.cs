using KinoAfisha.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace KinoAfisha.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        List<Schedule> Schedule = App.context.Schedule.ToList();
        

        public SchedulePage()
        {
            InitializeComponent();
            ScheduleLb.ItemsSource = Schedule;
            
        }


        // Обработчик события смены даты
        private void ScheduleDp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ScheduleDp.SelectedDate.HasValue)
            {
                var selectedDate = ScheduleDp.SelectedDate.Value;
                ScheduleLb.ItemsSource = GetFilmsByDate(selectedDate);
            }
        }


        // Возвращает фильмы на выбранную дату

        private List<Schedule> GetFilmsByDate(DateTime date)
        {
            // Фильтрация фильмов по дате
            return Schedule.Where(s => s.Date.Date == date.Date).ToList();
        }
    }
}
