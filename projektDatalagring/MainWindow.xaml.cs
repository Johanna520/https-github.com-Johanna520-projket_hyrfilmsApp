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

namespace projektDatalagring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
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
