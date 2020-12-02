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
using DatabaseConnection;
using FleraVyer.SubViews;

namespace FleraVyer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoHem_Click(object sender, RoutedEventArgs e)
        {
            HemTitle.Content = "Hem";
            Hem.Visibility = Visibility.Visible;
            MinSida.Visibility = Visibility.Hidden;
            Filmer.Visibility = Visibility.Hidden;
        }

        private void GoMinSida_Click(object sender, RoutedEventArgs e) //vad som sker när jag klickat på Mina sidor knappen
        {
            HemTitle.Content = "Mina sidor";
            Hem.Visibility = Visibility.Hidden;
            MinSida.Visibility = Visibility.Visible;
            Filmer.Visibility = Visibility.Hidden;
        }

        private void GoFilmer_Click(object sender, RoutedEventArgs e) //vad som sker när man klickat på "Filmer"knappen
        {
            HemTitle.Content = "Filmer";
            Hem.Visibility = Visibility.Hidden;
            MinSida.Visibility = Visibility.Hidden;
            Filmer.Visibility = Visibility.Visible;
        }
    }
}
