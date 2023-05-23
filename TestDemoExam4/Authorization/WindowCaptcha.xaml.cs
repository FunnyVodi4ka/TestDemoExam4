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
using System.Windows.Shapes;

namespace TestDemoExam4.Authorization
{
    /// <summary>
    /// Логика взаимодействия для WindowCaptcha.xaml
    /// </summary>
    public partial class WindowCaptcha : Window
    {
        string rightCaptcha = null;
        public WindowCaptcha()
        {
            InitializeComponent();

            ReloadCaptcha();
        }

        private void ReloadCaptcha()
        {
            rightCaptcha = "";
            string str = "qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM1234567890";
            Random rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                rightCaptcha += str[rnd.Next(str.Length)];
            }

            tblCaptcha.Text = rightCaptcha;
        }

        private void btnCaptcha_Click(object sender, RoutedEventArgs e)
        {
            if(tbCaptcha.Text == rightCaptcha)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No");
                ReloadCaptcha();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReloadCaptcha();
        }
    }
}
