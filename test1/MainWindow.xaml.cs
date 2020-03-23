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
            ComboBox txtBox = new ComboBox();
            txtBox.HorizontalAlignment = HorizontalAlignment.Left;
            txtBox.VerticalAlignment = VerticalAlignment.Top;
            txtBox.Height = 30;
            txtBox.Width = 30;
            txtBox.Items.Add('+');
            txtBox.Items.Add('-');
            txtBox.Items.Add('*');
            txtBox.Items.Add('/');
            Ultra.Children.Add(txtBox);
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
            int Count = 0;
            for(var i=0;i<Ultra.Children.Count;i++)
            {
                if(Ultra.Children[i] is TextBox)
                {
                    TextBox textInTextbox = (TextBox)Ultra.Children[i];
                    ComboBox boxInCombobox = (ComboBox)Ultra.Children[i-1];
                    int num=0;
                    try 
                    {
                        num = Convert.ToInt32(textInTextbox.Text);
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
                    switch (boxInCombobox.SelectedItem)
                    {
                        case '+': Count = Count + num; break;
                        case '-': Count = Count - num; break;
                        case '*': Count = Count * num; break;
                        case '/': Count = Count / num; break;
                    }
                }
            }
            Result.Content = "Результат= " + Count;
        }
        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Sum();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ultra.Children.RemoveAt(Ultra.Children.Count - 1);Sum();
        }
    }
}
