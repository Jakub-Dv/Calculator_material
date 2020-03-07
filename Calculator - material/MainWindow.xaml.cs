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

namespace Calculator___material
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 0;
        private double result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("1");
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("0");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("3");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("6");
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            InputBox.AppendText("9");
        }

        private void ButtonEqv_Click(object sender, RoutedEventArgs e)
        {
            HistoryBox.AppendText(OutputBox.Text);
            if (InputBox.Text != null)
            {
                result += double.Parse(InputBox.Text);
            }
            if (count != 0)
            {
                OutputBox.AppendText(result.ToString());
                InputBox.Clear();
            }
            
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            result = default(double);
            OutputBox.Clear();
            InputBox.Clear();
            count = default(int);
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if(e.Handled >= char(0))
            { }
            Numbers NumPad or OPad only
            */


            switch (e.Key)
            {
                case Key.Enter:
                    ButtonEqv_Click(sender, e);
                    break;
            }
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
            if(InputBox.Text.Length != 0)
                InputBox.Text = InputBox.Text.Substring(0, InputBox.Text.Length - 1);
        }
    }
}
