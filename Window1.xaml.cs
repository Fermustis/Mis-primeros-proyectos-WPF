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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmascotaVirtual.exe");
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("24_03_2022 Proyecto interfaz basica.exe");
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("10_03_2022 Proyecto IGU con CSHARP.exe");
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("03_03_2022 WFgraficador01.exe");
        }
    }
}
