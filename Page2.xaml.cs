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
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void graficaLissajus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("08_03_2022 Grafica de lissajus.exe");
        }

        private void parametricas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("08_03_2022 Graficador de funciones parametricas.exe");
        }
    }
}
