///-------------------------------------------------------------------------------------------------
/// @file   MainWindow.xaml.cs.
///
/// @brief  Implements the main window.xaml class
///-------------------------------------------------------------------------------------------------

using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace Calculator___material
{
    ///-------------------------------------------------------------------------------------------------
    /// @class  MainWindow
    ///
    /// @brief  The application's main form.
    ///
    /// @author Jakub
    /// @date   09.04.2020
    ///
    /// ### remarks Jakub, 08.04.2020.
    ///-------------------------------------------------------------------------------------------------

    public partial class MainWindow : Window
    {
        
        /// @brief  Default variable for number creating.
        private double number1 = 0;

        /// @brief  Default variable for result interpretation.
        private double number2 = 0;

        /// @brief  True if is decimal, false if not.
        private bool isDecimal = false;

        /// @brief  Number of decimals.
        private int decimalCount = 0;

        /// @brief  It is used for idetification of previous equalization.
        private string prevEqv;

        /// @brief  The mathematics library.
        Mathematics.Math Math = new Mathematics.Math();

        ///-------------------------------------------------------------------------------------------------
        /// @fn public MainWindow()
        ///
        /// @brief  Default constructor.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        public MainWindow()
        {
            InitializeComponent();
            InputBox.Text = "0";
            HistoryBox_Text.Text = "History:";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Number_Ctor(int number)
        ///
        /// @brief  Number constructor.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  number  Number of.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Number_Ctor(int number)
        {
            //Keyboard.Focus(ButtonEqv);
            if (prevEqv == "eqv")
            {
                number1 = 0;
                prevEqv = default(string);
            }
            if (!isDecimal)
            {
                number1 = number1 * 10 + number;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * number;
            }
            
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button0_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button0 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(0);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button1_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button1 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(1);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button2_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button2 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(2);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button3_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button3 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(3);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button4_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button4 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(4);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button5_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button5 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(5);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button6_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button6 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(6);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button7_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button7 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(7);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button8_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button8 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(8);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Button9_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by Button9 for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(9);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Defaults()
        ///
        /// @brief  Defaults this.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Defaults()
        {
                //System.Math.Round(number2 * System.Math.Pow(10, -decimalCount + 1));
                //number2 = number2 * System.Math.Pow(10, decimalCount - 1);
            
            
            OutputBox.Text = number2.ToString();
            number1 = default(double);
            decimalCount = 0;
            isDecimal = false;
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void Operations(string prevEqv)
        ///
        /// @brief  Operations.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  prevEqv The previous eqv.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void Operations(string prevEqv)
        {
            switch (prevEqv)
            {
                case "add":
                    number2 = Math.Sum(number2, number1);
                    break;
                case "sub":
                    number2 = Math.Sub(number2, number1);
                    break;
                case "mul":
                    number2 = Math.Mul(number2, number1);
                    break;
                case "div":
                    number2 = Math.Div(number2, number1);
                    break;
                case "pow":
                    number2 = Math.Pow(number2, number1);
                    break;
                case "fac":
                    number2 = Math.Fac(number1);
                    break;
                case "sqrt":
                    number2 = Math.Sqrt(number1, number2);
                    break;
                case "mod":
                    number2 = Math.Mod(number2, number1);
                    break;

                case "eqv":
                    number2 = number1;
                    break;
                default:
                    number2 = number1;
                    break;
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonEqv_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonEqv for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonEqv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "=";
            switch (prevEqv)
            {
                case "add":
                    number2 = Math.Sum(number2, number1);
                    break;
                case "sub":
                    number2 = Math.Sub(number2, number1);
                    break;
                case "mul":
                    number2 = Math.Mul(number2, number1);
                    break;
                case "div":
                    number2 = Math.Div(number2, number1);
                    break;
                case "pow":
                    number2 = Math.Pow(number2, number1);
                    break;
                case "sqrt":
                    number2 = Math.Sqrt(number1, number2);
                    break;
                case "mod":
                    number2 = Math.Mod(number2, number1);
                    break;


                case "eqv":
                    number2 = number1;
                    break;
                default:
                    break;
            }

            OutputBox.Text = number2.ToString();
            InputBox.Clear();

            HistoryBox.Text = OutputBox.Text + "\n" + HistoryBox.Text;
            
            number1 = number2;
            prevEqv = "eqv";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonCE_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonCE for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            OutputBox.Clear();
            decimalCount = 0;
            SignBox.Clear();
            prevEqv = default(string);
            isDecimal = false;
            InputBox.Text = "0";
            
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonAdd for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "+";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "add";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonSub_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonSub for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "-";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "sub";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonMul_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonMul for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "×";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "mul";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonDiv for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "÷";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "div";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonC_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonC for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 / 10;
                number1 = Math.Floor(number1);

                if (decimalCount >= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }
            else
            {
                double numberHelp = number1 * Math.Pow(10, decimalCount);
                numberHelp = numberHelp % 10;
                number1 = number1 - (Math.Pow(10, -(decimalCount)) * numberHelp);
                decimalCount--;
                if (decimalCount <= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }

            string toBePrinted = number1.ToString();
            if (InputBox.Text.Length != 0)
            {
                InputBox.Text = toBePrinted;
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonDec_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonDec for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonDec_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                InputBox.AppendText(",");
            }
            isDecimal = true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonPow_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonPow for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "^";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "pow";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonFac_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonFac for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonFac_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "!";
            InputBox.Text = "0";
            prevEqv = "fac";

            Operations(prevEqv);
            Defaults();

            prevEqv = default(string);
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonRoot for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "√";
            InputBox.Text = "0";
            if (prevEqv == "eqv")
            {
                number1 = 0;
            }
            Operations(prevEqv);
            Defaults();

            prevEqv = "sqrt";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonMod_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonMod for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonMod_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "%";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "mod";
        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void InputBox_KeyDown(object sender, KeyEventArgs e)
        ///
        /// @brief  Event handler. Called by InputBox for key down events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Key event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.NumPad0:
                    
                    Button0_Click(sender, e);
                    break;
                case Key.NumPad1:
                    Button1_Click(sender, e);
                    break;
                case Key.NumPad2:
                    Button2_Click(sender, e);
                    break;
                case Key.NumPad3:
                    Button3_Click(sender, e);
                    break;
                case Key.NumPad4:
                    Button4_Click(sender, e);
                    break;
                case Key.NumPad5:
                    Button5_Click(sender, e);
                    break;
                case Key.NumPad6:
                    Button6_Click(sender, e);
                    break;
                case Key.NumPad7:
                    Button7_Click(sender, e);
                    break;
                case Key.NumPad8:
                    Button8_Click(sender, e);
                    break;
                case Key.NumPad9:
                    Button9_Click(sender, e);
                    break;
                case Key.Back:
                    ButtonC_Click(sender, e);
                    break;
                case Key.Enter:
                    ButtonEqv_Click(sender, e);
                    break;
                case Key.Subtract:
                    ButtonSub_Click(sender, e);
                    break;
                case Key.Add:
                    ButtonAdd_Click(sender, e);
                    break;
                case Key.Multiply:
                    ButtonMul_Click(sender, e);
                    break;
                case Key.Divide:
                    ButtonDiv_Click(sender, e);
                    break;
                case Key.OemComma:
                    ButtonDec_Click(sender, e);
                    break;
                case Key.OemPeriod:
                    ButtonDec_Click(sender, e);
                    break;
                case Key.Decimal:
                    ButtonDec_Click(sender, e);
                    break;
                default:
                    break;
            }

        }

        ///-------------------------------------------------------------------------------------------------
        /// @fn private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        ///
        /// @brief  Event handler. Called by ButtonHelp for click events.
        ///
        /// @author Jakub
        /// @date   09.04.2020
        ///
        /// @param  sender  Source of the event.
        /// @param  e       Routed event information.
        ///
        /// ### remarks Jakub, 08.04.2020.
        ///-------------------------------------------------------------------------------------------------

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {

            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();

        }
    }
}
