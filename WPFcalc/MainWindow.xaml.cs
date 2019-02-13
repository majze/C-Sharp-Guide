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

namespace WpfApp
{
    /// Interaction logic for MainWindow.xaml
    //  Routed Events - WPF functions to handle events
    //  Bubbling Event - Bubbling occurs while event is not handled by element
    //  Tunneling Event - Event travels down visual tree toward source element 
    public partial class MainWindow : Window
    {
        string[] operands = { "", "", "" };
        int index = 0;

        public MainWindow()
        {
            //starting window
            InitializeComponent();
        }

        private void CalcPress(object sender, RoutedEventArgs e)
        {
            System.Console.Beep(400, 200);
            Button btn = (Button)sender;
            string input = btn.Content.ToString();

            switch (index)
            {
                case 0:
                    if (IsNaN(input))
                        break;
                    NumberField.Text = input;
                    index++;
                    break;
                case 1:
                    if (IsNaN(input))
                    {
                        operands[0] = NumberField.Text;
                        switch (input)
                        {
                            case ".":
                                NumberField.Text += input;
                                break;
                            case "ENTER":
                                break;
                            default:
                                operands[1] = input;
                                NumberField.Text = input;
                                index++;
                                break;
                        }
                    }
                    else
                    {
                        NumberField.Text += input;
                    }
                    break;
                case 2:
                    if (IsNaN(input))
                    {
                        switch (input)
                        {
                            case "ENTER":
                            case ".":
                                break;
                            default:
                                operands[1] = input;
                                NumberField.Text = input;
                                break;
                        }
                    }
                    else
                    {
                        NumberField.Text = input;
                        index++;
                    }
                    break;
                case 3:
                    if (IsNaN(input))
                    {
                        switch (input)
                        {
                            case ".":
                                NumberField.Text += input;
                                break;
                            case "ENTER":
                                operands[2] = NumberField.Text;
                                double result = Calculate(operands[0], operands[1], operands[2]);
                                if (result != -256.99)
                                    NumberField.Text = result.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        NumberField.Text += input;
                    }
                    break;
                case 4:
                    if (IsNaN(input))
                    {
                        switch (input)
                        {
                            case "ENTER":
                            case ".":
                                break;
                            default:
                                operands[0] = NumberField.Text;
                                operands[1] = input;
                                index = 2;
                                break;
                        }
                    } else
                    {
                        NumberField.Text = input;
                        index = 1;
                    }
                    break;
            }
        }

        private bool IsNaN(string input)
        {
            switch (input)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case ".":
                case "ENTER":
                    return true;
                default:
                    return false;
            }
        }

        private double Calculate(string a, string b, string c)
        {
            try
            {
                double A = double.Parse(a);
                double C = double.Parse(c);
                index++;
                switch (b)
                {
                    case "+":
                        return A + C;
                    case "-":
                        return A - C;
                    case "*":
                        return A * C;
                    case "/":
                        return A / C;
                }
            } catch
            {
                NumberField.Text = "Input Error!";
                index = 0;
            }
            return -256.99;
        }
    }
}
