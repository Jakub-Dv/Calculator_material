using System;
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



        public MainWindow()
        {
            InitializeComponent();
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
            HistoryBox.Text = OutputBox.Text;
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            number1 = default(double);
            OutputBox.Clear();
            decimalCount = 0;
            if (decimalCount == 0)
            {
                isDecimal = false;
            }
            InputBox.Text = "0";
            
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if(e.Handled >= char(0))
            { }
            Numbers NumPad or OPad only
            */

            /*
            switch (e.Key)
            {
                case Key.Enter:
                    ButtonEqv_Click(sender, e);
                    break;
            }
            */
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("+");
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("-");
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("/");
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("*");
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 / 10;
                number1 = Math.Floor(number1);
            }
            else
            {
                double numberHelp = number1 * Math.Pow(10, decimalCount);
                numberHelp = numberHelp % 10;
                number1 = number1 - Math.Pow(10, -(decimalCount)) * numberHelp;
                decimalCount--;
                if (decimalCount <= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }
            string toBePrinted = number1.ToString();
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
    }
}
