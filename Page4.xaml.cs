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

namespace _2do_Parcial_LanzadorGeneral_GZF_12
{
    /// <summary>
    /// Lógica de interacción para Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void multitipo_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("15-03-2022 Multitipos.exe");
        }

        private void arreglo_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("15_03_2022 ConArreglos.exe");
        }
    }
}
