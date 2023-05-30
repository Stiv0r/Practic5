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

namespace zad1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            int count = 0;

            // Разбиваем строку на числа, используя разделитель " "
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in numbers)
            {
                int value = int.Parse(number);

                if (value == 0)
                {
                    break;
                }

                if (value % 2 == 0 && value % 7 == 0)
                {
                    count++;
                }
            }

            otv.Text = $"Количество четных чисел, кратных 7: {count}";
        }
    }
}

