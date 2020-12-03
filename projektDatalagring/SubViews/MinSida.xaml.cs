using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
            FirstNameLabel.Content = "Förnamn: " + State.User.FirstName;
            LastNameLabel.Content = "Efternamn: " + State.User.LastName;
            EmailLabel.Content = "E-post: " + State.User.Email;
            BirthdayLabel.Content = "Födelsedag: " + State.User.Birthday;
              
            }

             

        }
    }
}
