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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WPFGonzalez Zamora.exe");
        }

        private void botonPracticas_Click(object sender, RoutedEventArgs e)
        {
            Practicas practicas = new Practicas();
            practicas.Show();
        }

        private void botonProyectos_Click(object sender, RoutedEventArgs e)
        {
            Window1 proyectos = new Window1();
            proyectos.Show();
        }

        private void botonExamen_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Examen 2do parcial GZF_8CM12.exe");
        }

        private void botonApuntes_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("2do_Apuntes_GZF.pdf");
        }
    }
}
