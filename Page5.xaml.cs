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
    /// Lógica de interacción para Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void consola_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("17_03_2022  consola matriz de multitipos.exe");
        }

        private void clase_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("17_02_2022 Clase matriz con consola.exe");
        }

        private void datagrid_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("17-03-2022 WFDataGrid01.exe");
        }
    }
}
