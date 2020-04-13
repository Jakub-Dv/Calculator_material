using System.Windows;

namespace Calculator___material
{
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
            Left.Text = "+\n−\n×\n÷\nC\nCE\n!\n^\n√\n%\n";
            Right.Text = "Addition\nSubtraction\nMultiplication\nDivision\nClear just the last digit\nClear everything\nFactorial\nExponentiation\nn-th root (Default: 2)\nModulo\n";
        }
    }
}
