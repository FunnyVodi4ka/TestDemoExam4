﻿using System;
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
using TestDemoExam4.MainList;

namespace TestDemoExam4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AppConnect.modelDB = new DemoExamEntities();
            AppFrame.frameMain = frmMain;

            AppFrame.frameMain.Navigate(new PageLogin());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            switch (btnExit.Content)
            {
                case "Enter as Guest":
                    AuthorizedUser.user = null;
                    AppFrame.frameMain.Navigate(new PageUsers());
                    btnExit.Content = "Exit";
                    break;
                case "Exit":
                    AuthorizedUser.user = null;
                    AppFrame.frameMain.Navigate(new PageLogin());
                    btnExit.Content = "Enter as Guest";
                    break;
            }
        }

        private void frmMain_Navigated(object sender, NavigationEventArgs e)
        {
            if(AuthorizedUser.user != null)
            {
                btnExit.Content = "Exit";
            }
            else
            {
                btnExit.Content = "Enter as Guest";
            }
        }
    }
}
