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

namespace IndividualWPF22._11._18._3._2
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

        private double SeriesCalc(double x, double n, double k)
        {
            double z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    z = (Math.Cos(Math.Pow(x, i)) + j) / (i * j);
                }
            }
            return z;
           
        }

        private void ButtonCalc_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(PerX.Text);
            double n = Convert.ToDouble(PerN.Text);
            double k = Convert.ToDouble(PerK.Text);
            MessageBox.Show("Ответ: " + SeriesCalc(x, n, k).ToString("F"));
        }
    }
}
