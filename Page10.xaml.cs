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
    /// Lógica de interacción para Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public Page10()
        {
            InitializeComponent();
        }

        private void ctrl_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFcontroles01.exe");
        }

        private void Tarjeta_presentacion_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFGonzalez Zamora.exe");
        }
    }
}
