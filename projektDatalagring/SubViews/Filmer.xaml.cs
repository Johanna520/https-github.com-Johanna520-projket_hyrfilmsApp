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

namespace FleraVyer.SubViews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Filmer : UserControl //kopplas ihop med usercontrol 
    {
        public Filmer()
        {
            InitializeComponent();
            int movie_skip_count = 0;
            int movie_take_count = 50;
            State.Movies = DatabaseAPI.GetMovieSlice(movie_skip_count, movie_take_count); //här läggs  filmerna till från databasAPI samt info från movie-state

            int coloumn_count = MovieGrid.ColumnDefinitions.Count;

            int row_count = (int)Math.Ceiling((double)State.Movies.Count / (double)coloumn_count);//här kommer info från state.user

            for (int y = 0; y < row_count; y++)
            {
                MovieGrid.RowDefinitions.Add(
                    new RowDefinition()
                    {
                        Height = new GridLength(148, GridUnitType.Pixel)
                    });

                for (int x = 0; x < coloumn_count; x++)
                {
                    int i = y * coloumn_count + x;

                    if (i < State.Movies.Count)//infor från state.movie
                    {
                        var movie = State.Movies[i];//infor från state movie

                        var image = new Image()
                        {
                            Cursor = Cursors.Hand,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                            Margin = new Thickness(4, 4, 4, 4),
                        };
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

                        MovieGrid.Children.Add(image);

                        Grid.SetRow(image, y);
                        Grid.SetColumn(image, x);
                    }
                }
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var x = Grid.GetColumn(sender as UIElement);
            var y = Grid.GetRow(sender as UIElement);

            int i = y * MovieGrid.ColumnDefinitions.Count + x;

            State.Pick = State.Movies[i]; //infor från pick, movie state
            //DatabasAPI lägger till ny rental
            if (DatabaseAPI.RegisterSale(State.User, State.Pick)) // här plockas user-info in från state, infor från pick  movie state
                MessageBox.Show("Du kan nu ladda ner din hyrfilm.", "Nerladdningen lyckades!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("FEL! Ett fel uppstod, vänligen försök ladda ner filmen igen.", "Nerladdningen misslyckades!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
