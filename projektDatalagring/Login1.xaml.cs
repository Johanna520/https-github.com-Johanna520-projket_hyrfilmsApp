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
using System.Windows.Shapes;
using DatabaseConnection;
using FleraVyer;
using FleraVyer.SubViews;

namespace Store
{
    /// <summary>
    /// Interaction logic for Login1.xaml
    /// </summary>
    public partial class Login1 : Window
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void LogIn_click(object sender, RoutedEventArgs e)
        {
            string userName = NameBox.Text.Trim();

            if (State.User != null)
            {
                State.User = DatabaseAPI.GetCustomerByName(userName);
                var next_window = new MainWindow();
                next_window.Show();

                this.Close();
            }

            else 
            {
                NameBox.Text = "Fel namn, välj ett annat...";
            }
        }

    }
}
