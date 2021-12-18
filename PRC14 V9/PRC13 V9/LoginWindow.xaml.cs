using System;
using System.Windows;

namespace PRC13_V9
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        public LoginWindow()
        {
            InitializeComponent();
            myPassword.Focus();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (myPassword.Password == "123")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                myPassword.Focus();
            }
        }
    }
}
