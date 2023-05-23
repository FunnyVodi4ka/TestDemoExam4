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
using TestDemoExam4.AppConnection;
using TestDemoExam4.MainList;

namespace TestDemoExam4.Authorization
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageRegister());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = AppConnect.modelDB.Users.FirstOrDefault(x => x.Login == tbLogin.Text && x.Password == pbPassword.Password);
            if (user != null)
            {
                MessageBox.Show("Hello, " + user.Login);
                AuthorizedUser.user = user;
                AppFrame.frameMain.Navigate(new PageUsers());
            }
            else
            {
                MessageBox.Show("Error login or password");
                WindowCaptcha captcha = new WindowCaptcha();
                captcha.ShowDialog();
            }
        }
    }
}
