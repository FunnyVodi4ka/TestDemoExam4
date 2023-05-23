using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using TestDemoExam4.Validation;

namespace TestDemoExam4.MainList
{
    /// <summary>
    /// Логика взаимодействия для PageAddEditUser.xaml
    /// </summary>
    public partial class PageAddEditUser : Page
    {
        ValidationClass validation = new ValidationClass();
        Users currentUser = new Users();
        string saveFilename = null, newFilename = null;
        public PageAddEditUser(Users user)
        {
            InitializeComponent();

            SetRoles();

            if (user != null )
            {
                DataContext = user;
                currentUser = user;

                FindRole();
            }
        }

        private void FindRole()
        {
            var role = AppConnect.modelDB.Roles.FirstOrDefault(x => x.IdRole == currentUser.IdRole);
            cbRole.SelectedItem = role.Name;
        }

        private void SetRoles()
        {
            cbRole.Items.Add("Choose role");

            foreach (var role in AppConnect.modelDB.Roles)
            {
                cbRole.Items.Add(role.Name);
            }

            cbRole.SelectedIndex = 0;
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

            if(!validation.CheckStringData(tbLogin.Text, 2, 50))
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
            if(currentUser.IdUser != 0 && pbPassword.Password.Length == 0)
            { }
            else
            {
                if (!validation.CheckPassword(pbPassword.Password))
                {
                    pbPassword.BorderBrush = Brushes.Red;
                    MessageBox.Show("Error password");
                    return false;
                }
            }
            if(!CheckRole())
            {
                MessageBox.Show("Error role");
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

        private bool CheckRole()
        {
            var role = AppConnect.modelDB.Roles.FirstOrDefault(x => x.Name == cbRole.Text);
            if(role !=  null)
            {
                return true;
            }
            return false;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(CheckAllData())
            {
                try
                {
                    currentUser.Login = tbLogin.Text;
                    currentUser.Email = tbEmail.Text;
                    currentUser.Phone = tbPhone.Text;
                    if (currentUser.IdUser != 0 && pbPassword.Password.Length == 0)
                    { }
                    else
                    {
                        currentUser.Password = pbPassword.Password;
                    }
                    AddRole();
                    currentUser.pCost = Int32.Parse(tbCost.Text);
                    currentUser.DeteOfBirth = DateTime.Parse(dpDeteOfBirth.Text);
                    
                    if(newFilename != null)
                    {
                        if(LoadInDirectory())
                        {
                            currentUser.pImage = newFilename;
                        }
                    }

                    if(currentUser.IdUser == 0)
                    {
                        AppConnect.modelDB.Users.Add(currentUser);
                    }
                    AppConnect.modelDB.SaveChanges();
                    MessageBox.Show("Save yes");

                    AppFrame.frameMain.Navigate(new PageUsers());
                }
                catch
                {
                    MessageBox.Show("Error save");
                }
            }
        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();

                saveFilename = dialog.FileName;

                Random rnd = new Random();

                newFilename = rnd.Next(1000, 10000).ToString() + rnd.Next(1000, 10000).ToString() + ".png";
            }
            catch { }
        }

        private bool LoadInDirectory()
        {
            try
            {
                File.Copy(saveFilename, System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Resources\\UserImages\\" + newFilename);
                return true;
            }
            catch
            {
                MessageBox.Show("Error load photo");
                return false;
            }
        }

        private void tbCost_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "[0-9]"))
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

        private void AddRole()
        {
            var role = AppConnect.modelDB.Roles.FirstOrDefault(x => x.Name == cbRole.Text);
            currentUser.IdRole = role.IdRole;
        }
    }
}
