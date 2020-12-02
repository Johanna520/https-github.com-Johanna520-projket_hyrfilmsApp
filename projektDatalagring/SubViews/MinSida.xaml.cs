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
using DatabaseConnection;

namespace FleraVyer.SubViews
{
    /// <summary>
    /// Interaction logic for MyPage.xaml
    /// </summary>
    public partial class MinSida : UserControl
    {
        public MinSida()
        {
            InitializeComponent();
             



           // MinSidaLabel.Content = "Personuppgifter"; 
            MinSidaLabel.Content = "Namn: " + State.User.FirstName + State.User.LastName;
           // * MinSidaLabel.Content = "E-post: " + State.User.Email;
           // MinSidaLabel.Content = "Födelsedag: " + State.User.Birthday;
                
            
        }
    }
}
