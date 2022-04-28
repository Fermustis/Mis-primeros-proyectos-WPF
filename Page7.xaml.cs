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
    /// Lógica de interacción para Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void grid_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("24_03_2022 WPF grid.exe");
        }

        private void stack_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("24_02_2022 WPF stackPanel.exe");
        }

        private void canvas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("24_02_2022 WPF Canvas.exe");
        }
    }
}
