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

namespace Filmer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        public MainWindow()
        {
            InitializeComponent();
            int movie_skip_count = 0;
            int movie_take_count = 50;
            State.Movies = DatabaseAPI.GetMovieSlice(movie_skip_count, movie_take_count);

            int coloumn_count = MovieGrid.ColumnDefinitions.Count;

            int row_count = (int)Math.Ceiling((double)State.Movies.Count / (double)coloumn_count);

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

                    if (i < State.Movies.Count)
                    {
                        var movie = State.Movies[i];

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

            State.Pick = State.Movies[i];

            if (DatabaseAPI.RegisterSale(State.User, State.Pick))
                MessageBox.Show("All is well and you can download your movie now.", "Sale Succeeded", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("An error happened while buying the movie, please try again at a later time.", "Sale Failed!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
        */
    }
}

/*

        Title="MainWindow" 
        Height="600" 
        Width="800"
        ResizeMode="NoResize"
        Topmost="True"
        WindowStyle="None"
        WindowStartupLocation="CenterScreen">

    <Window.Resources>
        
        <!--Toggle Button Style Template-->

        <ImageBrush x:Key="tb_mouse_over"
                    ImageSource="Assets/tgBtn_MouseOver.png"/>

        <Style x:Key="tb_style" TargetType="{x:Type ToggleButton}">

            <Setter Property="Template">

                <Setter.Value>

                    <ControlTemplate TargetType="{x:Type ToggleButton}">

                        <Border x:Name="border"
                                BorderThickness="{TemplateBinding BorderThickness}"
                                Background="{TemplateBinding Background}"
                                SnapsToDevicePixels="True">
                            
                        </Border>

                        <ControlTemplate.Triggers>

                            <Trigger Property="IsMouseOver" Value="true">

                                <Setter Property="Background"
                                        TargetName="border"
                                        Value="{StaticResource tb_mouse_over}"/>

                                <Setter Property="BorderBrush"
                                        TargetName="border"
                                        Value="{StaticResource tb_mouse_over}"/>

                            </Trigger>
                            
                        </ControlTemplate.Triggers>
                        
                    </ControlTemplate>
                    
                </Setter.Value>
                
            </Setter>
            
        </Style>
        
        
    </Window.Resources>
    
    <Grid>

        <!--// Background Color //-->

        <Grid Background="Black">
            
            <!--Navigation Panel-->

            <Grid x:Name="nav_pnl"
                  HorizontalAlignment="Left"
                  Width="65"
                  Background="#2E333A">

                <StackPanel x:Name="st_pnl">
                    
                    <!--Grid for the Menu Toggle Button-->

                    <Grid Height="90">
                        
                        <!--Toggle Button-->

                        <ToggleButton x:Name="Tg_Btn"
                                      Grid.Column="0"
                                      VerticalAlignment="Center"
                                      HorizontalAlignment="Left"
                                      Margin="18,-20,0,0"
                                      Height="30"
                                      Width="30"
                                      BorderThickness="0">
                            
                            <!--Toggle button default background image-->

                            <ToggleButton.Background>

                                <ImageBrush ImageSource=""
                                            Stretch="None"/>

                            </ToggleButton.Background>
                            
                            <!--Toggle Buttton - Checked, Unchecked events-->

                            <ToggleButton.Triggers>

                                <EventTrigger RoutedEvent="ToggleButton.Unchecked">

                                    <BeginStoryboard>

                                        <Storyboard x:Name="HideStackPanel">

                                            <DoubleAnimation
                                                
                                                Storyboard.TargetName="nav_pnl"
                                                Storyboard.TargetProperty="Width"
                                                BeginTime="0:0:0"
                                                From="230" To="65"
                                                Duration="0:0:0:2">
                                                
                                            </DoubleAnimation>
                                                
                                        </Storyboard>

                                    </BeginStoryboard>
                                    
                                </EventTrigger>

                                <EventTrigger RoutedEvent="ToggleButton.Checked">

                                    <BeginStoryboard>

                                        <Storyboard x:Name="ShowStackPanel">

                                            <DoubleAnimation
                                                
                                                Storyboard.TargetName="nav_pnl"
                                                Storyboard.TargetProperty="Width"
                                                BeginTime="0:0:0"
                                                From="65" To="230"
                                                Duration="0:0:0:3">
                                                
                                            </DoubleAnimation>
                                            
                                        </Storyboard>
                                        
                                    </BeginStoryboard>
                                    
                                </EventTrigger>
                                
                            </ToggleButton.Triggers>
                               
                        </ToggleButton>
                        
                    </Grid>
                    
                    
                </StackPanel>
                
            </Grid>
            
        </Grid>
        
    </Grid>
</Window>

 */
