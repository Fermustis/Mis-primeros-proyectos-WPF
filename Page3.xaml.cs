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
    /// Lógica de interacción para Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void G1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("10_03_2022 WF generacontol1.exe");
        }

        private void g2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("10_03_2022 WF generacontol12.exe");
        }
    }
}
