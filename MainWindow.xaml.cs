using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace FindSimilarity
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

        private void FinisButton_Click(object sender, RoutedEventArgs e)
        {
            string FirstString = FirstTextBox.Text; // строка для первого текста
            string SecondString = SecondTextBox.Text; // строка для второго текста

            char[] first_arr = FirstString.ToCharArray();
            char[] second_arr = SecondString.ToCharArray();

            float res = 0;

            if (first_arr.Length < second_arr.Length)
            {

                float symbol_proc = 100f / second_arr.Length;

                for (int i = 0; i < first_arr.Length; i++)
                {
                    if (first_arr[i] == second_arr[i])
                    {
                        res++;
                    }
                }

                MessageBox.Show("Тексты совпадают на " + Convert.ToString(res * symbol_proc) + "%");
            }
            else
            {
                
                float symbol_proc = 100f / first_arr.Length;

                for (int i = 0; i < second_arr.Length; i++)
                {
                    if (first_arr[i] == second_arr[i])
                    {
                        res++;
                    }
                }

                MessageBox.Show("Тексты совпадают на " + Convert.ToString(res * symbol_proc) + "%");
            }

            //MessageBox.Show(res.ToString());

        }

        private void ThemeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ThemeCheckBox.Foreground = Brushes.White;
            FirstTextBlock.Foreground = Brushes.White;
            SecondTextBlock.Foreground = Brushes.White;
            FirstTextBox.Background = Brushes.Black;
            FirstTextBox.Foreground = Brushes.White;
            SecondTextBox.Background = Brushes.Black;
            SecondTextBox.Foreground = Brushes.White;
            Grid.Background = Brushes.Black;
        }

        private void ThemeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ThemeCheckBox.Foreground = Brushes.Black;
            FirstTextBlock.Foreground = Brushes.Black;
            SecondTextBlock.Foreground = Brushes.Black;
            FirstTextBox.Background = Brushes.White;
            FirstTextBox.Foreground = Brushes.Black;
            SecondTextBox.Background = Brushes.White;
            SecondTextBox.Foreground = Brushes.Black;
            Grid.Background = Brushes.White;
        }
    }
}
