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
    /// Interaction logic for Square.xaml
    /// </summary>
    /// 

    public enum CodeColor
    {
        Blue,
        Red,
        Green,
        Yellow
    }

    public partial class Square : Page
    {
        public Square()
        {
            InitializeComponent();
        }

        //public int insCode;
        
        CodeColor insCode;

        

        

        SolidColorBrush blue = new SolidColorBrush(Colors.Blue);
        SolidColorBrush red = new SolidColorBrush(Colors.Red);
        SolidColorBrush green = new SolidColorBrush(Colors.Green);
        SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow);


        private void blueRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Blue;
        }

        private void P1Btn_Click(object sender, RoutedEventArgs e)
        {
            switch (insCode)
            {
                case CodeColor.Blue:
                    L11.Fill = blue;
                    break;
                case CodeColor.Red:
                    L11.Fill = red;
                    break;
                case CodeColor.Green:
                    L11.Fill = green;
                    break;
                case CodeColor.Yellow:
                    L11.Fill = yellow;
                    break;
                default:
                    break;
            }
        }
        private void P2Btn_Click(object sender, RoutedEventArgs e)
        {
            switch (insCode)
            {
                case CodeColor.Blue:
                    L12.Fill = blue;
                    break;
                case CodeColor.Red:
                    L12.Fill = red;
                    break;
                case CodeColor.Green:
                    L12.Fill = green;
                    break;
                case CodeColor.Yellow:
                    L12.Fill = yellow;
                    break;
                default:
                    break;
            }
        }
        private void P3Btn_Click(object sender, RoutedEventArgs e)
        {
            switch (insCode)
            {
                case CodeColor.Blue:
                    L13.Fill = blue;
                    break;
                case CodeColor.Red:
                    L13.Fill = red;
                    break;
                case CodeColor.Green:
                    L13.Fill = green;
                    break;
                case CodeColor.Yellow:
                    L13.Fill = yellow;
                    break;
                default:
                    break;
            }
        }

        private void P4Btn_Click(object sender, RoutedEventArgs e)
        {
            switch (insCode)
            {
                case CodeColor.Blue:
                    L14.Fill = blue;
                    break;
                case CodeColor.Red:
                    L14.Fill = red;
                    break;
                case CodeColor.Green:
                    L14.Fill = green;
                    break;
                case CodeColor.Yellow:
                    L14.Fill = yellow;
                    break;
                default:
                    break;
            }
        }

        

        private void redRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Red;
        }

        private void greenRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Green;
        }

        private void yellowRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Yellow;
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
