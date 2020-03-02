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

namespace test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int y = 20;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox txt = new TextBox();
            txt.HorizontalAlignment = HorizontalAlignment.Left;
            txt.VerticalAlignment = VerticalAlignment.Top;
            txt.Height = 30;
            txt.Width = 120;
            txt.Margin = new Thickness(5, y, 0, 0);
            Super.Children.Add(txt);
            y = y + 35;
        }
        void Sum()
        {
            int resultSum = 0;
            for(var i=0;i<Super.Children.Count;i++)
            {
                if(Super.Children[i] is TextBox)
                {
                    TextBox textInTextbox = (TextBox)Super.Children[i];
                    try 
                    {
                        resultSum = resultSum + Convert.ToInt32(textInTextbox.Text);
                    }
                    catch 
                    {
                        if (textInTextbox.Text == "")
                        {

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }                      
                    }                   
                }
            }
            Result.Content = "Результат= " + resultSum;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sum();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            Sum();
        }
    }
}
