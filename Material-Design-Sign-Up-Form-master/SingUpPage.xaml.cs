using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sign_Up_Form
{
    /// <summary>
    /// Логика взаимодействия для SingUpPage.xaml
    /// </summary>
    public partial class SingUpPage : Page
    {
        ApplicationContext db;
        
        public SingUpPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void GoLogin(object sender, RoutedEventArgs e)
        {
            Manager.LogSingFrame.Navigate(new LogInPage());
        }

        public void MarkInvalid(Control control)
        {
            control.ToolTip = "Поле не корректно";
        }

        private void GoSingUp(object sender, RoutedEventArgs e)
        {
            string login = userNameTextBox.Text.Trim();
            string password = passwdTextBox.Password.Trim();
            string rewritePassword = retypePasswdTextBox.Password.Trim();
            string email = emailTextBox.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                MarkInvalid(userNameTextBox);
                userNameTextBox.Text = "Логин должен быть больше 5 знаков";
            }
            else if (password.Length < 5) 
            { 
                MarkInvalid(passwdTextBox);
                passwdTextBox.Password = "";
                
            }
            else if (password != rewritePassword)
            {
                MarkInvalid(passwdTextBox);
                passwdTextBox.Password = "";
                retypePasswdTextBox.Password = "";
            }
            else if (email.Length < 5 || email.Contains("@"))
            {
                MarkInvalid(emailTextBox);
                emailTextBox.Text = "";
            }
            else
            {
                User user = new User(login, email, password);

                db.Users.Add(user);
                db.SaveChanges();
            }

        }
    }
}
