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
using Prestamos.UI.Consultas;
using Prestamos.UI.Registros;
namespace prestamos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void rPersona_Click(object render, RoutedEventArgs e)
        {
            rPersona rPerson = new rPersona();
            rPerson.Show();
        }

        public void rPrestamo_Click(object render, RoutedEventArgs e)
        {
            rPrestamo rPrestam = new rPrestamo();
            rPrestam.Show();
        }

        public void cPersona_Click(object render, RoutedEventArgs e)
        {
            cPersona cPerson = new cPersona();
            cPerson.Show();
        }

        public void cPrestamo_Click(object render, RoutedEventArgs e)
        {
            cPrestamo cPrestam = new cPrestamo();
            cPrestam.Show();
        }
    }
}
