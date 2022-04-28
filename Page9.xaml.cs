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
    /// Lógica de interacción para Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();
        }

        
        private void controladas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("31_03_2022 Lanzador de aplicaciones controladas.exe");
        }

        private void alarma_Click(object sender, RoutedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("31_02_2022 WPF alarma.exe");
        }
    }
}
