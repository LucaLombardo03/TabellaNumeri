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

namespace InterfacciaGrafica
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

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            double max;
            double min;
            double media;
            double num1 = double.Parse(TxtNum1.Text);
            double num2 = double.Parse(TxtNum2.Text);
            if (num1 > num2)
            {
                max = num1;
                min = num2;
            }
            else
            {
                max = num2;
                min = num1;
            }
            media = (num1 + num2) / 2;
            LblMassimo.Content = max.ToString();
            LblMinimo.Content = min.ToString();
            LblMedia.Content = media.ToString();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            TxtNum1.Clear();
            TxtNum2.Clear();
            LblMassimo.Content = ("");
            LblMinimo.Content = ("");
            LblMedia.Content = ("");
        }
    }
}
