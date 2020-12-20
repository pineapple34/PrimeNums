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

namespace PrimeNums
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

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(TBn.Text);
                int a = int.Parse(TBa.Text);
                int b = int.Parse(TBb.Text);

                if (isPrime(N)) LblOut.Content = "N - простое число";
                    else LblOut.Content = "N - составное число";

                int summ = 0;
                for (int i = a; i <= b; i++)
                {
                    if (!isPrime(i)) summ += i;
                }
                LblOut.Content += "\nСумма составных от a до b = " + summ;

            }
            catch (Exception)
            {
                LblOut.Content = "Неверные данные";
            }
        }

        public bool isPrime(int num)
        {
            double m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
