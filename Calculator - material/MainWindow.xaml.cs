using System.Windows;
using System.Windows.Input;

namespace Calculator___material
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        
        private double number1 = 0;
        private double number2 = 0;
        private bool isDecimal = false;
        private int decimalCount = 0;
        private string prevEqv; //used for idetification of previous equalization
        Mathematics.Math Math = new Mathematics.Math();

        public MainWindow()
        {
            InitializeComponent();
            InputBox.Text = "0";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 0;
            }
            else
            {
                
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 0;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            if (!isDecimal)
            {
                number1 = number1 * 10 + 1;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 1;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 2;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 2;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 3;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 3;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 4;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 4;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 5;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 5;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 6;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 6;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 7;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 7;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 8;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 8;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 * 10 + 9;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * 9;
            }
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        private void Defaults()
        {
            OutputBox.Text = number2.ToString();
            number1 = default(double);
            decimalCount = 0;
            isDecimal = false;
        }

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

        private void ButtonEqv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "=";
            switch (prevEqv)
            {
                case "add":
                    number2 = Math.Sum(number2, number1);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;
                case "sub":
                    number2 = Math.Sub(number2, number1);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;
                case "mul":
                    number2 = Math.Mul(number2, number1);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;
                case "div":
                    number2 = Math.Div(number2, number1);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;
                case "pow":
                    number2 = Math.Pow(number2, number1);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;
                case "sqrt":
                    number2 = Math.Sqrt(number1, number2);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;
                case "mod":
                    number2 = Math.Mod(number2, number1);
                    OutputBox.Text = number2.ToString();
                    InputBox.Clear();
                    break;


                case "eqv":
                    number2 = number1;
                    break;
                default:
                    break;
            }
            HistoryBox.Text = OutputBox.Text + "\n" + HistoryBox.Text;
            number1 = 0;
            prevEqv = "eqv";
        }

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

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "+";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "add";
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "-";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "sub";
        }

        

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "×";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "mul";
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "÷";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "div";
        }

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

        private void ButtonDec_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                InputBox.AppendText(",");
            }
            isDecimal = true;
        }

        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "^";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "pow";
        }

        private void ButtonFac_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "!";
            InputBox.Text = "0";
            prevEqv = "fac";

            Operations(prevEqv);
            Defaults();

            prevEqv = default(string);
        }

        private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "√";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "sqrt";
        }

        private void ButtonMod_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "%";
            InputBox.Text = "0";

            Operations(prevEqv);
            Defaults();

            prevEqv = "mod";
        }

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

        
        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {

            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();

        }
    }
}
