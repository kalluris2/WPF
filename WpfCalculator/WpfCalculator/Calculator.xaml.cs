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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long Number1 = 0;
        long Number2 = 0;
        string Operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 1;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 1;
                textDisplay.Text = Number2.ToString();
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 2;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 2;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 3;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 3;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 4;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 4;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 5;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number1 = (Number2 * 10) + 6;
                textDisplay.Text = Number1.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 6;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 6;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 7;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 7;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 8;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 8;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) + 9;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) + 9;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 * 10) ;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 * 10) ;
                textDisplay.Text = Number2.ToString();
            }
        }

        private void buttonPositive_Click(object sender, RoutedEventArgs e)
        {
            Operation = "+";
            textDisplay.Text = "0";
        }

        private void buttonNegative_Click(object sender, RoutedEventArgs e)
        {
            Operation = "-";
            textDisplay.Text = "0";
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            Operation = "*";
            textDisplay.Text = "0";
        }

        private void buttonDivison_Click(object sender, RoutedEventArgs e)
        {
            Operation = "/";
            textDisplay.Text = "0";
        }

        private void buttonEqualTo_Click(object sender, RoutedEventArgs e)
        {

            switch (Operation)
            {
                case "+":
                    textDisplay.Text = (Number1 + Number2).ToString();
                    break;
                case "-":
                    textDisplay.Text = (Number1 - Number2).ToString();
                    break;
                case "*":
                    textDisplay.Text = (Number1 * Number2).ToString();
                    break;
                case "/":
                    try
                    {
                        textDisplay.Text = (Number1 / Number2).ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
            }
        }

        private void buttonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if(Operation == "")
            {
                Number1 = 0;
                
            }
            else
            {
                Number2 = 0;
            }
            textDisplay.Text = "0";
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            Number2 = 0;
            Number1 = 0;
            Operation = "";
            textDisplay.Text = "0";
        }

        private void buttonBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 = (Number1 / 10) + 1;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number2 = (Number2 / 10) + 1;
                textDisplay.Text = Number2.ToString();
            }

        }

        private void buttonPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (Operation == "")
            {
                Number1 *= -1;
                textDisplay.Text = Number1.ToString();
            }
            else
            {
                Number1 *=  - 1;
                textDisplay.Text = Number1.ToString();
            }
        }
    }
}
