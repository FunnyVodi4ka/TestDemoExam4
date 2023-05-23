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
using TestDemoExam4.DatabaseConnection;
using TestDemoExam4.MainList;
using TestDemoExam4.Validation;

namespace TestDemoExam4.Authorization
{
    /// <summary>
    /// Логика взаимодействия для PageRegister.xaml
    /// </summary>
    public partial class PageRegister : Page
    {
        ValidationClass validation = new ValidationClass();
        Users currentUser = new Users();

        public PageRegister()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private bool CheckAllData()
        {
            tbLogin.BorderBrush = Brushes.Black;
            tbEmail.BorderBrush = Brushes.Black;
            tbPhone.BorderBrush = Brushes.Black;
            pbPassword.BorderBrush = Brushes.Black;
            tbCost.BorderBrush = Brushes.Black;
            dpDeteOfBirth.BorderBrush = Brushes.Black;

            if (!validation.CheckStringData(tbLogin.Text, 2, 50))
            {
                tbLogin.BorderBrush = Brushes.Red;
                MessageBox.Show("Error login");
                return false;
            }
            if (!validation.CheckEmail(tbEmail.Text))
            {
                tbEmail.BorderBrush = Brushes.Red;
                MessageBox.Show("Error email");
                return false;
            }
            if (!validation.CheckPhone(tbPhone.Text))
            {
                tbPhone.BorderBrush = Brushes.Red;
                MessageBox.Show("Error phone");
                return false;
            }
            if (!validation.CheckPassword(pbPassword.Password))
            {
                pbPassword.BorderBrush = Brushes.Red;
                MessageBox.Show("Error password");
                return false;
            }
            if (!validation.CheckIntData(tbCost.Text, 0))
            {
                tbCost.BorderBrush = Brushes.Red;
                MessageBox.Show("Error cost");
                return false;
            }
            if (!validation.CheckDate(dpDeteOfBirth.Text))
            {
                dpDeteOfBirth.BorderBrush = Brushes.Red;
                MessageBox.Show("Error date");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CheckAllData())
            {
                try
                {
                    currentUser.Login = tbLogin.Text;
                    currentUser.Email = tbEmail.Text;
                    currentUser.Phone = tbPhone.Text;
                    currentUser.Password = pbPassword.Password;
                    currentUser.pCost = Int32.Parse(tbCost.Text);
                    currentUser.DeteOfBirth = DateTime.Parse(dpDeteOfBirth.Text);
                    var role = AppConnect.modelDB.Roles.FirstOrDefault(x => x.Name == "Сотрудник");
                    currentUser.IdRole = role.IdRole;

                    AppConnect.modelDB.Users.Add(currentUser);
                    AppConnect.modelDB.SaveChanges();
                    MessageBox.Show("Reg yes");

                    AppFrame.frameMain.Navigate(new PageLogin());
                }
                catch
                {
                    MessageBox.Show("Error reg");
                }
            }
        }

        private void tbCost_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "[0-9]"))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "[0-9]") || tbPhone.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }
    }
}
