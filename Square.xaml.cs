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
        Yellow,
        Count
    }

    public partial class Square : Page
    {
        public Square()
        {
            InitializeComponent();
        }

        CodeColor insCode;

        int rowCounter = 0;

        bool codeSolved = false;

        CodeColor[] enteredCode = new CodeColor[4];
        public static CodeColor[] findMe = new CodeColor[4];

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
            #region Collumn 1 Button_Click event
            switch (insCode)
            {
                case CodeColor.Blue:
                    switch (rowCounter)
                    {
                        case 0:
                            L11.Fill = blue;
                            break;
                        case 1:
                            L21.Fill = blue;
                            break;
                        case 2:
                            L31.Fill = blue;
                            break;
                        case 3:
                            L41.Fill = blue;
                            break;
                        case 4:
                            L51.Fill = blue;
                            break;
                        case 5:
                            L61.Fill = blue;
                            break;
                        case 6:
                            L71.Fill = blue;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Red:
                    switch (rowCounter)
                    {
                        case 0:
                            L11.Fill = red;
                            break;
                        case 1:
                            L21.Fill = red;
                            break;
                        case 2:
                            L31.Fill = red;
                            break;
                        case 3:
                            L41.Fill = red;
                            break;
                        case 4:
                            L51.Fill = red;
                            break;
                        case 5:
                            L61.Fill = red;
                            break;
                        case 6:
                            L71.Fill = red;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Green:
                    switch (rowCounter)
                    {
                        case 0:
                            L11.Fill = green;
                            break;
                        case 1:
                            L21.Fill = green;
                            break;
                        case 2:
                            L31.Fill = green;
                            break;
                        case 3:
                            L41.Fill = green;
                            break;
                        case 4:
                            L51.Fill = green;
                            break;
                        case 5:
                            L61.Fill = green;
                            break;
                        case 6:
                            L71.Fill = green;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Yellow:
                    switch (rowCounter)
                    {
                        case 0:
                            L11.Fill = yellow;
                            break;
                        case 1:
                            L21.Fill = yellow;
                            break;
                        case 2:
                            L31.Fill = yellow;
                            break;
                        case 3:
                            L41.Fill = yellow;
                            break;
                        case 4:
                            L51.Fill = yellow;
                            break;
                        case 5:
                            L61.Fill = yellow;
                            break;
                        case 6:
                            L71.Fill = yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void P2Btn_Click(object sender, RoutedEventArgs e)
        {
            #region Collumn 2 Button_Click event
            switch (insCode)
            {
                case CodeColor.Blue:
                    switch (rowCounter)
                    {
                        case 0:
                            L12.Fill = blue;
                            break;
                        case 1:
                            L22.Fill = blue;
                            break;
                        case 2:
                            L32.Fill = blue;
                            break;
                        case 3:
                            L42.Fill = blue;
                            break;
                        case 4:
                            L52.Fill = blue;
                            break;
                        case 5:
                            L62.Fill = blue;
                            break;
                        case 6:
                            L72.Fill = blue;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Red:
                    switch (rowCounter)
                    {
                        case 0:
                            L12.Fill = red;
                            break;
                        case 1:
                            L22.Fill = red;
                            break;
                        case 2:
                            L32.Fill = red;
                            break;
                        case 3:
                            L42.Fill = red;
                            break;
                        case 4:
                            L52.Fill = red;
                            break;
                        case 5:
                            L62.Fill = red;
                            break;
                        case 6:
                            L72.Fill = red;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Green:
                    switch (rowCounter)
                    {
                        case 0:
                            L12.Fill = green;
                            break;
                        case 1:
                            L22.Fill = green;
                            break;
                        case 2:
                            L32.Fill = green;
                            break;
                        case 3:
                            L42.Fill = green;
                            break;
                        case 4:
                            L52.Fill = green;
                            break;
                        case 5:
                            L62.Fill = green;
                            break;
                        case 6:
                            L72.Fill = green;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Yellow:
                    switch (rowCounter)
                    {
                        case 0:
                            L12.Fill = yellow;
                            break;
                        case 1:
                            L22.Fill = yellow;
                            break;
                        case 2:
                            L32.Fill = yellow;
                            break;
                        case 3:
                            L42.Fill = yellow;
                            break;
                        case 4:
                            L52.Fill = yellow;
                            break;
                        case 5:
                            L62.Fill = yellow;
                            break;
                        case 6:
                            L72.Fill = yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
        }

        private void P3Btn_Click(object sender, RoutedEventArgs e)
        {
            #region Collumn 3 button_Click event
            switch (insCode)
            {
                case CodeColor.Blue:
                    switch (rowCounter)
                    {
                        case 0:
                            L13.Fill = blue;
                            break;
                        case 1:
                            L23.Fill = blue;
                            break;
                        case 2:
                            L33.Fill = blue;
                            break;
                        case 3:
                            L43.Fill = blue;
                            break;
                        case 4:
                            L53.Fill = blue;
                            break;
                        case 5:
                            L63.Fill = blue;
                            break;
                        case 6:
                            L73.Fill = blue;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Red:
                    switch (rowCounter)
                    {
                        case 0:
                            L13.Fill = red;
                            break;
                        case 1:
                            L23.Fill = red;
                            break;
                        case 2:
                            L33.Fill = red;
                            break;
                        case 3:
                            L43.Fill = red;
                            break;
                        case 4:
                            L53.Fill = red;
                            break;
                        case 5:
                            L63.Fill = red;
                            break;
                        case 6:
                            L73.Fill = red;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Green:
                    switch (rowCounter)
                    {
                        case 0:
                            L13.Fill = green;
                            break;     
                        case 1:        
                            L23.Fill = green;
                            break;     
                        case 2:        
                            L33.Fill = green;
                            break;     
                        case 3:        
                            L43.Fill = green;
                            break;     
                        case 4:        
                            L53.Fill = green;
                            break;     
                        case 5:        
                            L63.Fill = green;
                            break;     
                        case 6:        
                            L73.Fill = green;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Yellow:
                    switch (rowCounter)
                    {
                        case 0:
                            L13.Fill = yellow;
                            break;     
                        case 1:        
                            L23.Fill = yellow;
                            break;     
                        case 2:        
                            L33.Fill = yellow;
                            break;     
                        case 3:       
                            L43.Fill = yellow;
                            break;     
                        case 4:       
                            L53.Fill = yellow;
                            break;    
                        case 5:       
                            L63.Fill = yellow;
                            break;     
                        case 6:        
                            L73.Fill = yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
        }
       
        private void P4Btn_Click(object sender, RoutedEventArgs e)
        {
            #region Collumn 4 Button_Click event
            switch (insCode)
            {
                case CodeColor.Blue:
                    switch (rowCounter)
                    {
                        case 0:
                            L14.Fill = blue;
                            break;
                        case 1:
                            L24.Fill = blue;
                            break;
                        case 2:
                            L34.Fill = blue;
                            break;
                        case 3:
                            L44.Fill = blue;
                            break;
                        case 4:
                            L54.Fill = blue;
                            break;
                        case 5:
                            L64.Fill = blue;
                            break;
                        case 6:
                            L74.Fill = blue;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Red:
                    switch (rowCounter)
                    {
                        case 0:
                            L14.Fill = red;
                            break;
                        case 1:
                            L24.Fill = red;
                            break;
                        case 2:
                            L34.Fill = red;
                            break;
                        case 3:
                            L44.Fill = red;
                            break;
                        case 4:
                            L54.Fill = red;
                            break;
                        case 5:
                            L64.Fill = red;
                            break;
                        case 6:
                            L74.Fill = red;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Green:
                    switch (rowCounter)
                    {
                        case 0:
                            L14.Fill = green;
                            break;     
                        case 1:        
                            L24.Fill = green;
                            break;     
                        case 2:        
                            L34.Fill = green;
                            break;     
                        case 3:        
                            L44.Fill = green;
                            break;     
                        case 4:        
                            L54.Fill = green;
                            break;     
                        case 5:        
                            L64.Fill = green;
                            break;     
                        case 6:        
                            L74.Fill = green;
                            break;
                        default:
                            break;
                    }
                    break;
                case CodeColor.Yellow:
                    switch (rowCounter)
                    {
                        case 0:
                            L14.Fill = yellow;
                            break;     
                        case 1:        
                            L24.Fill = yellow;
                            break;     
                        case 2:        
                            L34.Fill = yellow;
                            break;     
                        case 3:        
                            L44.Fill = yellow;
                            break;     
                        case 4:        
                            L54.Fill = yellow;
                            break;     
                        case 5:        
                            L64.Fill = yellow;
                            break;     
                        case 6:        
                            L74.Fill = yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        #endregion
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
            codeSolved = Game.CheckCode(findMe, enteredCode);
            rowCounter++;

            if (codeSolved)
            {
                //Gewonnen
            }
            else if (rowCounter >= 7)
            {
                //Verloren
            }

            
        }

        private void IngameMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
