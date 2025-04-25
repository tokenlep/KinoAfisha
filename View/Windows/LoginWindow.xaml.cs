using KinoAfisha.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace KinoAfisha.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PasswordPb.Password;

            // Проверка учетных данных
            var administrator = App.context.Administrator.FirstOrDefault(admin => admin.Login == login && admin.Password == password);

            if (administrator != null)
            {
                MessageBox.Show("Авторизация успешна!");
                // Здесь можно добавить логику перехода на главную страницу
                
            }
            else
            {
                MessageBox.Show("Неверные учетные данные");
                PasswordPb.Clear();
                LoginTb.Focus();
            }
        }
    }
}