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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox txt = new TextBox();
            txt.TextChanged += Txt_TextChanged;
            txt.HorizontalAlignment = HorizontalAlignment.Left;
            txt.VerticalAlignment = VerticalAlignment.Top;
            txt.Height = 30;
            txt.Width = 120;
            Ultra.Children.Add(txt);
        }
        void Sum()
        {
            int resultSum = 0;
            for(var i=0;i<Ultra.Children.Count;i++)
            {
                if(Ultra.Children[i] is TextBox)
                {
                    TextBox textInTextbox = (TextBox)Ultra.Children[i];
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
        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Sum();
        }
    }
}
