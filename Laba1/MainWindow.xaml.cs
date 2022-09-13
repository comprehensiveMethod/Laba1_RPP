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

namespace Laba1
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
            int N, K;
            double y, p;
            if (double.TryParse(pValue.Text, out p) && double.TryParse(yValue.Text, out y) && int.TryParse(nValue.Text, out N) && int.TryParse(kValue.Text, out K))
            {
                double Z = 0;
                for (int i = 1; i < N; i++)
                {
                    for (int j = 1; j < K; j++)
                    {
                        Z += (Math.Pow(p, i) * Math.Pow(y, j)) / i * j;
                    }
                }
                answer.Content = "Z = " + Z;
            }
            else {
                answer.Content = "Wrong input, try again";
                yValue.Text = "0,00";
                pValue.Text = "0,00";
            }

            
           

        }
    }
}
