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

namespace Projekt_Mastermind
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            NGArw.Visibility = Visibility.Hidden;
            OptArw.Visibility = Visibility.Hidden;
            HlpArw.Visibility = Visibility.Hidden;
            CrdArw.Visibility = Visibility.Hidden;
            QutArw.Visibility = Visibility.Hidden;
        }
            
            

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Square.findMe = Game.NewCode();
            NavigationService.Navigate(new Square());
        }

        private void Options_MouseEnter(object sender, MouseEventArgs e)
        {
            OptArw.Visibility = Visibility.Visible;
        }

        private void Options_MouseLeave(object sender, MouseEventArgs e)
        {
            OptArw.Visibility = Visibility.Hidden;
        }

        private void NewGame_MouseEnter(object sender, MouseEventArgs e)
        {
            NGArw.Visibility = Visibility.Visible;
        }

        private void NewGame_MouseLeave(object sender, MouseEventArgs e)
        {
            NGArw.Visibility = Visibility.Hidden;
        }

        private void Help_MouseEnter(object sender, MouseEventArgs e)
        {
            HlpArw.Visibility = Visibility.Visible;
        }

        private void Help_MouseLeave(object sender, MouseEventArgs e)
        {
            HlpArw.Visibility = Visibility.Hidden;
        }

        private void Credits_MouseEnter(object sender, MouseEventArgs e)
        {
            CrdArw.Visibility = Visibility.Visible;
        }

        private void Credits_MouseLeave(object sender, MouseEventArgs e)
        {
            CrdArw.Visibility = Visibility.Hidden;
        }

        private void Quit_MouseEnter(object sender, MouseEventArgs e)
        {
            QutArw.Visibility = Visibility.Visible;
        }

        private void Quit_MouseLeave(object sender, MouseEventArgs e)
        {
            QutArw.Visibility = Visibility.Hidden;
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Help());
        }
    }
}
