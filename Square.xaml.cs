using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Automation;
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

    public enum CBox
    {
        Empty,
        Black,
        White
    }

    public partial class Square : Page
    {
        public Square()
        {
            InitializeComponent();

            BlArw.Visibility = Visibility.Hidden;
            RdArw.Visibility = Visibility.Hidden;
            GrArw.Visibility = Visibility.Hidden;
            YeArw.Visibility = Visibility.Hidden;

            BlEl.Visibility = Visibility.Hidden;
            RdEl.Visibility = Visibility.Hidden;
            GrEl.Visibility = Visibility.Hidden;
            YeEl.Visibility = Visibility.Hidden;

            R1.Visibility = Visibility.Visible;
            R2.Visibility = Visibility.Hidden;
            R3.Visibility = Visibility.Hidden;
            R4.Visibility = Visibility.Hidden;
            R5.Visibility = Visibility.Hidden;
            R6.Visibility = Visibility.Hidden;
            R7.Visibility = Visibility.Hidden;

            Rgl1.Stroke = white;

            findMe = Game.NewCode();
        }

        CodeColor insCode;

        int rowCounter = 0;
        int allset = 0;

        //bool codeSolved = false;

        readonly CodeColor[] enteredCode = new CodeColor[4];
        public static CodeColor[] findMe = new CodeColor[4];
        CBox[] checkBox = new CBox[4];

        readonly SolidColorBrush blue = new SolidColorBrush(Colors.Blue);
        readonly SolidColorBrush red = new SolidColorBrush(Colors.Red);
        readonly SolidColorBrush green = new SolidColorBrush(Colors.Green);
        readonly SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow);
        readonly SolidColorBrush black = new SolidColorBrush(Colors.Black);
        readonly SolidColorBrush white = new SolidColorBrush(Colors.White);

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
                            enteredCode[0] = CodeColor.Blue;
                            break;
                        case 1:
                            L21.Fill = blue;
                            enteredCode[0] = CodeColor.Blue;
                            break;
                        case 2:
                            L31.Fill = blue;
                            enteredCode[0] = CodeColor.Blue;
                            break;
                        case 3:
                            L41.Fill = blue;
                            enteredCode[0] = CodeColor.Blue;
                            break;
                        case 4:
                            L51.Fill = blue;
                            enteredCode[0] = CodeColor.Blue;
                            break;
                        case 5:
                            L61.Fill = blue;
                            enteredCode[0] = CodeColor.Blue;
                            break;
                        case 6:
                            L71.Fill = blue;
                            enteredCode[0] = CodeColor.Blue;
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
                            enteredCode[0] = CodeColor.Red;
                            break;
                        case 1:
                            L21.Fill = red;
                            enteredCode[0] = CodeColor.Red;
                            break;
                        case 2:
                            L31.Fill = red;
                            enteredCode[0] = CodeColor.Red;
                            break;
                        case 3:
                            L41.Fill = red;
                            enteredCode[0] = CodeColor.Red;
                            break;
                        case 4:
                            L51.Fill = red;
                            enteredCode[0] = CodeColor.Red;
                            break;
                        case 5:
                            L61.Fill = red;
                            enteredCode[0] = CodeColor.Red;
                            break;
                        case 6:
                            L71.Fill = red;
                            enteredCode[0] = CodeColor.Red;
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
                            enteredCode[0] = CodeColor.Green;
                            break;
                        case 1:
                            L21.Fill = green;
                            enteredCode[0] = CodeColor.Green;
                            break;
                        case 2:
                            L31.Fill = green;
                            enteredCode[0] = CodeColor.Green;
                            break;
                        case 3:
                            L41.Fill = green;
                            enteredCode[0] = CodeColor.Green;
                            break;
                        case 4:
                            L51.Fill = green;
                            enteredCode[0] = CodeColor.Green;
                            break;
                        case 5:
                            L61.Fill = green;
                            enteredCode[0] = CodeColor.Green;
                            break;
                        case 6:
                            L71.Fill = green;
                            enteredCode[0] = CodeColor.Green;
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
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        case 1:
                            L21.Fill = yellow;
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        case 2:
                            L31.Fill = yellow;
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        case 3:
                            L41.Fill = yellow;
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        case 4:
                            L51.Fill = yellow;
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        case 5:
                            L61.Fill = yellow;
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        case 6:
                            L71.Fill = yellow;
                            enteredCode[0] = CodeColor.Yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            allset++;
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
                            enteredCode[1] = CodeColor.Blue;
                            break;
                        case 1:
                            L22.Fill = blue;
                            enteredCode[1] = CodeColor.Blue;
                            break;
                        case 2:
                            L32.Fill = blue;
                            enteredCode[1] = CodeColor.Blue;
                            break;
                        case 3:
                            L42.Fill = blue;
                            enteredCode[1] = CodeColor.Blue;
                            break;
                        case 4:
                            L52.Fill = blue;
                            enteredCode[1] = CodeColor.Blue;
                            break;
                        case 5:
                            L62.Fill = blue;
                            enteredCode[1] = CodeColor.Blue;
                            break;
                        case 6:
                            L72.Fill = blue;
                            enteredCode[1] = CodeColor.Blue;
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
                            enteredCode[1] = CodeColor.Red;
                            break;
                        case 1:
                            L22.Fill = red;
                            enteredCode[1] = CodeColor.Red;
                            break;
                        case 2:
                            L32.Fill = red;
                            enteredCode[1] = CodeColor.Red;
                            break;
                        case 3:
                            L42.Fill = red;
                            enteredCode[1] = CodeColor.Red;
                            break;
                        case 4:
                            L52.Fill = red;
                            enteredCode[1] = CodeColor.Red;
                            break;
                        case 5:
                            L62.Fill = red;
                            enteredCode[1] = CodeColor.Red;
                            break;
                        case 6:
                            L72.Fill = red;
                            enteredCode[1] = CodeColor.Red;
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
                            enteredCode[1] = CodeColor.Green;
                            break;
                        case 1:
                            L22.Fill = green;
                            enteredCode[1] = CodeColor.Green;
                            break;
                        case 2:
                            L32.Fill = green;
                            enteredCode[1] = CodeColor.Green;
                            break;
                        case 3:
                            L42.Fill = green;
                            enteredCode[1] = CodeColor.Green;
                            break;
                        case 4:
                            L52.Fill = green;
                            enteredCode[1] = CodeColor.Green;
                            break;
                        case 5:
                            L62.Fill = green;
                            enteredCode[1] = CodeColor.Green;
                            break;
                        case 6:
                            L72.Fill = green;
                            enteredCode[1] = CodeColor.Green;
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
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        case 1:
                            L22.Fill = yellow;
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        case 2:
                            L32.Fill = yellow;
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        case 3:
                            L42.Fill = yellow;
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        case 4:
                            L52.Fill = yellow;
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        case 5:
                            L62.Fill = yellow;
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        case 6:
                            L72.Fill = yellow;
                            enteredCode[1] = CodeColor.Yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            allset++;
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
                            enteredCode[2] = CodeColor.Blue;
                            break;
                        case 1:
                            L23.Fill = blue;
                            enteredCode[2] = CodeColor.Blue;
                            break;
                        case 2:
                            L33.Fill = blue;
                            enteredCode[2] = CodeColor.Blue;
                            break;
                        case 3:
                            L43.Fill = blue;
                            enteredCode[2] = CodeColor.Blue;
                            break;
                        case 4:
                            L53.Fill = blue;
                            enteredCode[2] = CodeColor.Blue;
                            break;
                        case 5:
                            L63.Fill = blue;
                            enteredCode[2] = CodeColor.Blue;
                            break;
                        case 6:
                            L73.Fill = blue;
                            enteredCode[2] = CodeColor.Blue;
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
                            enteredCode[2] = CodeColor.Red;
                            break;
                        case 1:
                            L23.Fill = red;
                            enteredCode[2] = CodeColor.Red;
                            break;
                        case 2:
                            L33.Fill = red;
                            enteredCode[2] = CodeColor.Red;
                            break;
                        case 3:
                            L43.Fill = red;
                            enteredCode[2] = CodeColor.Red;
                            break;
                        case 4:
                            L53.Fill = red;
                            enteredCode[2] = CodeColor.Red;
                            break;
                        case 5:
                            L63.Fill = red;
                            enteredCode[2] = CodeColor.Red;
                            break;
                        case 6:
                            L73.Fill = red;
                            enteredCode[2] = CodeColor.Red;
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
                            enteredCode[2] = CodeColor.Green;
                            break;
                        case 1:
                            L23.Fill = green;
                            enteredCode[2] = CodeColor.Green;
                            break;
                        case 2:
                            L33.Fill = green;
                            enteredCode[2] = CodeColor.Green;
                            break;
                        case 3:
                            L43.Fill = green;
                            enteredCode[2] = CodeColor.Green;
                            break;
                        case 4:
                            L53.Fill = green;
                            enteredCode[2] = CodeColor.Green;
                            break;
                        case 5:
                            L63.Fill = green;
                            enteredCode[2] = CodeColor.Green;
                            break;
                        case 6:
                            L73.Fill = green;
                            enteredCode[2] = CodeColor.Green;
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
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        case 1:
                            L23.Fill = yellow;
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        case 2:
                            L33.Fill = yellow;
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        case 3:
                            L43.Fill = yellow;
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        case 4:
                            L53.Fill = yellow;
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        case 5:
                            L63.Fill = yellow;
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        case 6:
                            L73.Fill = yellow;
                            enteredCode[2] = CodeColor.Yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            allset++;
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
                            enteredCode[3] = CodeColor.Blue;
                            break;
                        case 1:
                            L24.Fill = blue;
                            enteredCode[3] = CodeColor.Blue;
                            break;
                        case 2:
                            L34.Fill = blue;
                            enteredCode[3] = CodeColor.Blue;
                            break;
                        case 3:
                            L44.Fill = blue;
                            enteredCode[3] = CodeColor.Blue;
                            break;
                        case 4:
                            L54.Fill = blue;
                            enteredCode[3] = CodeColor.Blue;
                            break;
                        case 5:
                            L64.Fill = blue;
                            enteredCode[3] = CodeColor.Blue;
                            break;
                        case 6:
                            L74.Fill = blue;
                            enteredCode[3] = CodeColor.Blue;
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
                            enteredCode[3] = CodeColor.Red;
                            break;
                        case 1:
                            L24.Fill = red;
                            enteredCode[3] = CodeColor.Red;
                            break;
                        case 2:
                            L34.Fill = red;
                            enteredCode[3] = CodeColor.Red;
                            break;
                        case 3:
                            L44.Fill = red;
                            enteredCode[3] = CodeColor.Red;
                            break;
                        case 4:
                            L54.Fill = red;
                            enteredCode[3] = CodeColor.Red;
                            break;
                        case 5:
                            L64.Fill = red;
                            enteredCode[3] = CodeColor.Red;
                            break;
                        case 6:
                            L74.Fill = red;
                            enteredCode[3] = CodeColor.Red;
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
                            enteredCode[3] = CodeColor.Green;
                            break;
                        case 1:
                            L24.Fill = green;
                            enteredCode[3] = CodeColor.Green;
                            break;
                        case 2:
                            L34.Fill = green;
                            enteredCode[3] = CodeColor.Green;
                            break;
                        case 3:
                            L44.Fill = green;
                            enteredCode[3] = CodeColor.Green;
                            break;
                        case 4:
                            L54.Fill = green;
                            enteredCode[3] = CodeColor.Green;
                            break;
                        case 5:
                            L64.Fill = green;
                            enteredCode[3] = CodeColor.Green;
                            break;
                        case 6:
                            L74.Fill = green;
                            enteredCode[3] = CodeColor.Green;
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
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        case 1:
                            L24.Fill = yellow;
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        case 2:
                            L34.Fill = yellow;
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        case 3:
                            L44.Fill = yellow;
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        case 4:
                            L54.Fill = yellow;
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        case 5:
                            L64.Fill = yellow;
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        case 6:
                            L74.Fill = yellow;
                            enteredCode[3] = CodeColor.Yellow;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            allset++;
            #endregion
        }
        
        private void BlueRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Blue;

            BlArw.Visibility = Visibility.Visible;
            RdArw.Visibility = Visibility.Hidden;
            GrArw.Visibility = Visibility.Hidden;
            YeArw.Visibility = Visibility.Hidden;

            BlEl.Visibility = Visibility.Visible;
            RdEl.Visibility = Visibility.Hidden;
            GrEl.Visibility = Visibility.Hidden;
            YeEl.Visibility = Visibility.Hidden;

            BlRgl.Stroke = white;
            RdRgl.Stroke = black;
            GrRgl.Stroke = black;
            YwRgl.Stroke = black;
        }

        private void RedRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Red;

            BlArw.Visibility = Visibility.Hidden;
            RdArw.Visibility = Visibility.Visible;
            GrArw.Visibility = Visibility.Hidden;
            YeArw.Visibility = Visibility.Hidden;

            BlEl.Visibility = Visibility.Hidden;
            RdEl.Visibility = Visibility.Visible;
            GrEl.Visibility = Visibility.Hidden;
            YeEl.Visibility = Visibility.Hidden;

            BlRgl.Stroke = black;
            RdRgl.Stroke = white;
            GrRgl.Stroke = black;
            YwRgl.Stroke = black;
        }

        private void GreenRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Green;

            BlArw.Visibility = Visibility.Hidden;
            RdArw.Visibility = Visibility.Hidden;
            GrArw.Visibility = Visibility.Visible;
            YeArw.Visibility = Visibility.Hidden;

            BlEl.Visibility = Visibility.Hidden;
            RdEl.Visibility = Visibility.Hidden;
            GrEl.Visibility = Visibility.Visible;
            YeEl.Visibility = Visibility.Hidden;

            BlRgl.Stroke = black;
            RdRgl.Stroke = black;
            GrRgl.Stroke = white;
            YwRgl.Stroke = black;
        }

        private void YellowRdBtn_Checked(object sender, RoutedEventArgs e)
        {
            insCode = CodeColor.Yellow;

            BlArw.Visibility = Visibility.Hidden;
            RdArw.Visibility = Visibility.Hidden;
            GrArw.Visibility = Visibility.Hidden;
            YeArw.Visibility = Visibility.Visible;

            BlEl.Visibility = Visibility.Hidden;
            RdEl.Visibility = Visibility.Hidden;
            GrEl.Visibility = Visibility.Hidden;
            YeEl.Visibility = Visibility.Visible;

            BlRgl.Stroke = black;
            RdRgl.Stroke = black;
            GrRgl.Stroke = black;
            YwRgl.Stroke = white;
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {

            if (allset > 3)
            {
                checkBox = Game.CheckCode(findMe, enteredCode);

                switch (rowCounter)
                {
                    case 0:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB1TL.Fill = black;
                                break;
                            case CBox.White:
                                CB1TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB1TR.Fill = black;
                                break;
                            case CBox.White:
                                CB1TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB1BL.Fill = black;
                                break;
                            case CBox.White:
                                CB1BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB1BR.Fill = black;
                                break;
                            case CBox.White:
                                CB1BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        R1.Visibility = Visibility.Hidden;
                        R2.Visibility = Visibility.Visible;
                        R3.Visibility = Visibility.Hidden;
                        R4.Visibility = Visibility.Hidden;
                        R5.Visibility = Visibility.Hidden;
                        R6.Visibility = Visibility.Hidden;
                        R7.Visibility = Visibility.Hidden;
                        Rgl1.Stroke = black;
                        Rgl2.Stroke = white;
                        break;
                    case 1:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB2TL.Fill = black;
                                break;
                            case CBox.White:
                                CB2TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB2TR.Fill = black;
                                break;
                            case CBox.White:
                                CB2TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB2BL.Fill = black;
                                break;
                            case CBox.White:
                                CB2BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB2BR.Fill = black;
                                break;
                            case CBox.White:
                                CB2BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        R1.Visibility = Visibility.Hidden;
                        R2.Visibility = Visibility.Hidden;
                        R3.Visibility = Visibility.Visible;
                        R4.Visibility = Visibility.Hidden;
                        R5.Visibility = Visibility.Hidden;
                        R6.Visibility = Visibility.Hidden;
                        R7.Visibility = Visibility.Hidden;
                        Rgl2.Stroke = black;
                        Rgl3.Stroke = white;
                        break;
                    case 2:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB3TL.Fill = black;
                                break;
                            case CBox.White:
                                CB2TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB3TR.Fill = black;
                                break;
                            case CBox.White:
                                CB3TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB3BL.Fill = black;
                                break;
                            case CBox.White:
                                CB3BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB3BR.Fill = black;
                                break;
                            case CBox.White:
                                CB3BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        R1.Visibility = Visibility.Hidden;
                        R2.Visibility = Visibility.Hidden;
                        R3.Visibility = Visibility.Hidden;
                        R4.Visibility = Visibility.Visible;
                        R5.Visibility = Visibility.Hidden;
                        R6.Visibility = Visibility.Hidden;
                        R7.Visibility = Visibility.Hidden;
                        Rgl3.Stroke = black;
                        Rgl4.Stroke = white;
                        break;
                    case 3:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB4TL.Fill = black;
                                break;
                            case CBox.White:
                                CB4TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB4TR.Fill = black;
                                break;
                            case CBox.White:
                                CB4TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB4BL.Fill = black;
                                break;
                            case CBox.White:
                                CB4BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB4BR.Fill = black;
                                break;
                            case CBox.White:
                                CB4BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        R1.Visibility = Visibility.Hidden;
                        R2.Visibility = Visibility.Hidden;
                        R3.Visibility = Visibility.Hidden;
                        R4.Visibility = Visibility.Hidden;
                        R5.Visibility = Visibility.Visible;
                        R6.Visibility = Visibility.Hidden;
                        R7.Visibility = Visibility.Hidden;
                        Rgl4.Stroke = black;
                        Rgl5.Stroke = white;
                        break;
                    case 4:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB5TL.Fill = black;
                                break;
                            case CBox.White:
                                CB5TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB5TR.Fill = black;
                                break;
                            case CBox.White:
                                CB5TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB5BL.Fill = black;
                                break;
                            case CBox.White:
                                CB5BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB5BR.Fill = black;
                                break;
                            case CBox.White:
                                CB5BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        R1.Visibility = Visibility.Hidden;
                        R2.Visibility = Visibility.Hidden;
                        R3.Visibility = Visibility.Hidden;
                        R4.Visibility = Visibility.Hidden;
                        R5.Visibility = Visibility.Hidden;
                        R6.Visibility = Visibility.Visible;
                        R7.Visibility = Visibility.Hidden;
                        Rgl5.Stroke = black;
                        Rgl6.Stroke = white;
                        break;
                    case 5:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB6TL.Fill = black;
                                break;
                            case CBox.White:
                                CB6TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB6TR.Fill = black;
                                break;
                            case CBox.White:
                                CB6TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB6BL.Fill = black;
                                break;
                            case CBox.White:
                                CB6BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB6BR.Fill = black;
                                break;
                            case CBox.White:
                                CB6BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        R1.Visibility = Visibility.Hidden;
                        R2.Visibility = Visibility.Hidden;
                        R3.Visibility = Visibility.Hidden;
                        R4.Visibility = Visibility.Hidden;
                        R5.Visibility = Visibility.Hidden;
                        R6.Visibility = Visibility.Hidden;
                        R7.Visibility = Visibility.Visible;
                        Rgl6.Stroke = black;
                        Rgl7.Stroke = white;
                        break;
                    case 6:
                        switch (checkBox[0])
                        {
                            case CBox.Black:
                                CB7TL.Fill = black;
                                break;
                            case CBox.White:
                                CB7TL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[1])
                        {
                            case CBox.Black:
                                CB7TR.Fill = black;
                                break;
                            case CBox.White:
                                CB7TR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[2])
                        {
                            case CBox.Black:
                                CB7BL.Fill = black;
                                break;
                            case CBox.White:
                                CB7BL.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        switch (checkBox[3])
                        {
                            case CBox.Black:
                                CB7BR.Fill = black;
                                break;
                            case CBox.White:
                                CB7BR.Fill = white;
                                break;
                            case CBox.Empty:
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                rowCounter++;
                allset = 0;

                for (int i = 0; i < checkBox.Length; i++)
                {
                    checkBox[i] = CBox.Empty;
                }
            }
        }

        private void IngameMenu_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
