using System;
using System.Security.Cryptography;
using System.Security.RightsManagement;
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
        private bool isDecimal;
        private int decimalCount = 0;
        private bool isNegative;
        private int op = 0;
        private string prevEqv; //used for idetification of previous equalization




        public MainWindow()
        {
            InitializeComponent();
            InputBox.Text = "0";
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

        private void ButtonEqv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "=";
            HistoryBox.Text = OutputBox.Text;
            switch (prevEqv)
            {
                case "add":
                    OutputBox.Text = (number2 + number1).ToString();
                    InputBox.Clear();
                    break;
                case "sub":
                    break;
                case "mul":
                    break;
                case "div":
                    break;
                default:
                    break;
            }
            
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            number1 = default(double);
            number2 = default(double);
            OutputBox.Clear();
            decimalCount = 0;
            op = 0;
            SignBox.Clear();
            prevEqv = default(string);
            
            if (decimalCount == 0)
            {
                isDecimal = false;
            }
            InputBox.Text = "0";
            
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "+";
            
            switch (prevEqv)
            {
                case "add":
                    number2 += number1;
                    break;
                case "sub":
                    number2 -= number1;
                    break;
                case "mul":
                    break;
                case "div":
                    break;
                default:
                    number2 += number1;
                    break;
            }

            OutputBox.Text = number2.ToString();
            prevEqv = "add";
            number1 = default(double);
            op++;
            decimalCount = 0;
            isDecimal = false;
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "-";
            if (op == 0)
            {
                number2 = number1;
                number1 = default(double);
            }
            switch (prevEqv)
            {
                case "add":
                    number2 += number1;
                    break;
                case "sub":
                    number2 -= number1;
                    break;
                case "mul":
                    break;
                case "div":
                    break;
                default:
                    number2 -= number1;
                    break;
            }

            if (number2 < 0)
            {
                isNegative = true;
            }

            prevEqv = "sub";
            number1 = default(double);
            OutputBox.Text = number2.ToString();
            op++;
            decimalCount = 0;
            isDecimal = false;


        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "÷";
            prevEqv = "div";
            
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "×";
            prevEqv = "mul";
            
        }


        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                if (op % 2 == 0)
                {
                    number1 = number1 / 10;
                    number1 = Math.Floor(number1);
                }
                else
                {
                    number2 = number2 / 10;
                    number2 = Math.Floor(number2);
                }
                
                if (decimalCount <= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }
            else if (isDecimal && decimalCount == 0)
            {
                isDecimal = false;
            }
            else
            {
                if (op % 2 == 0)
                {
                    double numberHelp = number1 * Math.Pow(10, decimalCount);
                    numberHelp = numberHelp % 10;
                    number1 = number1 - Math.Pow(10, -(decimalCount)) * numberHelp;
                }
                else
                {
                    double numberHelp = number2 * Math.Pow(10, decimalCount);
                    numberHelp = numberHelp % 10;
                    number2 = number2 - Math.Pow(10, -(decimalCount)) * numberHelp;
                }
                decimalCount--;
                if (decimalCount <= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }

            string toBePrinted;
            if (op % 2 == 0)
            {
                toBePrinted = number1.ToString();
            }
            else
            {
                toBePrinted = number2.ToString();
            }
            if (InputBox.Text.Length != 0)
                InputBox.Text = toBePrinted;
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

        }

        private void ButtonFac_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "!";
            if (number1 % 1 == 0 && number1 > 0)
                Factorial_Count();
            else
                OutputBox.Text = "NaN";
        }

        //////////////////////////////////////////////////////////////
        //////////////////FUNCTIONS///////////////////////////////////
        //////////////////////////////////////////////////////////////

        void Factorial_Count()
        {
            double x = 1;
            for (double i = 1; i <= number1; i++)
            {
                x = i * x;
            }
            string toBePrinted = x.ToString();
            number1 = x;
            InputBox.Text = toBePrinted;
        }
    }


}
