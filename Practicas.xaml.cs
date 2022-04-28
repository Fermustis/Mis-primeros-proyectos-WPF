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
using System.Windows.Shapes;

namespace _2do_Parcial_LanzadorGeneral_GZF_12
{
    /// <summary>
    /// Lógica de interacción para Practicas.xaml
    /// </summary>
    public partial class Practicas : Window
    {
        public Practicas()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFGonzalez Zamora.exe");
        }

       

     

        private void _070322_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page1());
        }

        private void _080322_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page2());
        }

        private void _100322(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page3());
        }

        private void _150322_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page4());
        }

        private void _170322_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page5());
        }

        private void _220322_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Page6());
        }
    }
}
