using System;
using System.Linq;
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
    /// Interaction logic for Hem.xaml
    /// </summary>
    public partial class Sök : UserControl
    {
        public Sök()
        {
            InitializeComponent();
        

                for (int y = 0; y < SearchGrid.RowDefinitions.Count; y++)
                {
                    for (int x = 0; x < SearchGrid.ColumnDefinitions.Count; x++)
                    {
                        int i = y * SearchGrid.ColumnDefinitions.Count + x;
                        if (i < State.Movies.Count)
                        {
                            var movie = State.Movies[i];

                            try
                            {

                                //Movie
                                var text = new Label() { };
                                text.Content = movie.Title; // Movies från databas
                                text.FontWeight = FontWeights.UltraBold;
                                text.FontFamily = new FontFamily("Sans-Serif");
                                text.Foreground = Brushes.White;
                                text.HorizontalAlignment = HorizontalAlignment.Center;
                                text.VerticalAlignment = VerticalAlignment.Top;
                                text.FontSize = 12;

                            var image = new Image();
                            image.MouseUp += Image_MouseUp;
                            try
                            {
                                image.Source = new BitmapImage(new Uri(movie.ImageURL));
                            }

                            catch (Exception e) when
                            (e is ArgumentNullException ||
                            e is System.IO.FileNotFoundException ||
                            e is UriFormatException)

                            {
                                image.Source = new BitmapImage(new Uri("https://wolper.com.au/wp-content/uploads/2017/10/image-placeholder.jpg"));
                            }

                            SearchGrid.Children.Add(image);



                        }
                            catch (Exception e) when
                                (e is ArgumentNullException ||
                                 e is System.IO.FileNotFoundException ||
                                 e is UriFormatException)
                            {
                                continue;
                            }
                        }
                    }
                }
            

            }
            public void MainWindow_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.Key == Key.Enter)
                {
                    State.Movies.Clear();
                    State.Movies.AddRange(DatabaseAPI.GetMovieByName(TextBox.Text));
                }
            }
        private void SearchMovieBox(object sender, MouseButtonEventArgs e)
        {

            TextBox.Clear();
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var x = Grid.GetColumn(sender as UIElement);
            var y = Grid.GetRow(sender as UIElement);

            int i = y * SearchGrid.ColumnDefinitions.Count + x;

            State.Pick = State.Movies[i]; //infor från pick, movie state
            //DatabasAPI lägger till ny rental
            if (DatabaseAPI.RegisterSale(State.User, State.Pick)) // här plockas user-info in från state, infor från pick  movie state
                MessageBox.Show("Du kan nu ladda ner din hyrfilm.", "Nerladdningen lyckades!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("FEL! Ett fel uppstod, vänligen försök ladda ner filmen igen.", "Nerladdningen misslyckades!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
