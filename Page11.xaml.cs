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
    /// Lógica de interacción para Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public Page11()
        {
            InitializeComponent();
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("07_04_2022 Consola circuito.exe");
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("07_04_2022 WPFCircuito.exe");
        }
    }
}
