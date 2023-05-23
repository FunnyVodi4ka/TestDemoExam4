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
using TestDemoExam4.Authorization;
using TestDemoExam4.DatabaseConnection;

namespace TestDemoExam4.MainList
{
    /// <summary>
    /// Логика взаимодействия для PageUsers.xaml
    /// </summary>
    public partial class PageUsers : Page
    {
        public PageUsers()
        {
            InitializeComponent();

            SetFilter();
            SetSort();

            listUsers.ItemsSource = SearchFilterSort();
        }

        Users[] SearchFilterSort()
        {
            List<Users> rows = AppConnect.modelDB.Users.ToList();
            int allRows = rows.Count;

            if(tbSearch.Text.Length > 0)
            {
                rows = rows.Where(x => x.Login.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
            }

            if(cbFilter.SelectedIndex > 0)
            {
                rows = rows.Where(x => x.Roles.Name == cbFilter.SelectedItem.ToString()).ToList();
            }

            switch(cbSort.SelectedIndex)
            {
                case 1:
                    rows = rows.OrderBy(x => x.Login).ToList();
                    break;
                case 2:
                    rows = rows.OrderByDescending(x => x.Login).ToList();
                    break;
            }

            if(allRows > 0)
            {
                tblCounter.Text = "Found: " + rows.Count + " of " + allRows;
            }
            else
            {
                tblCounter.Text = "Not found";
            }

            return rows.ToArray();
        }

        private void SetFilter()
        {
            cbFilter.Items.Add("Choose filter");

            foreach (var role in AppConnect.modelDB.Roles) 
            {
                cbFilter.Items.Add(role.Name);
            }

            cbFilter.SelectedIndex = 0;
        }

        private void SetSort()
        {
            cbSort.Items.Add("Choose sort");

            cbSort.Items.Add("Po ubivaniy");
            cbSort.Items.Add("Po vorzostaniy");

            cbSort.SelectedIndex = 0;
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUsers.ItemsSource = SearchFilterSort();
        }

        private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listUsers.ItemsSource = SearchFilterSort();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listUsers.ItemsSource = SearchFilterSort();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageAddEditUser(null));
        }

        private void listUsers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Users user = listUsers.SelectedItem as Users;
            AppFrame.frameMain.Navigate(new PageAddEditUser(user));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var user = listUsers.SelectedItem as Users;
            if (user != null)
            {
                try
                {
                    if(user.IdUser != AuthorizedUser.user.IdUser)
                    {
                        if (MessageBox.Show("Vi uverini?", "???", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            AppConnect.modelDB.Users.Remove(user);
                            AppConnect.modelDB.SaveChanges();
                            MessageBox.Show("Delete yes");
                            listUsers.ItemsSource = SearchFilterSort();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can`t delete yourself");
                    }
                }
                catch
                {
                    MessageBox.Show("Delete error");
                }
            }
            else
            {
                MessageBox.Show("Choose row");
            }
        }
    }
}
