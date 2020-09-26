using System;
using System.Windows;
using Prestamos.DAL;
using Prestamos.Entidades;
using Prestamos.BLL;
using Prestamos.UI;

namespace Prestamos.UI.Registros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class rPrestamo : Window
    {
        
        private Prestamo prestamo;
        //private Persona persona;
        public rPrestamo()
        {
            InitializeComponent();
            prestamo = new Prestamo();
            this.DataContext = prestamo;
        }

        public void SaveButton_Click(object render, RoutedEventArgs e)
        {
            if(!Validar())
                return;
            var paso = PrestamoBLL.Save(prestamo);
            if(paso){
                Limpiar();
                MessageBox.Show("Guardado con Exito", "Exito!!",MessageBoxButton.OK);
            }
            else
            MessageBox.Show("Error al guardar", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void Limpiar(){
            this.prestamo = new Prestamo();
            this.DataContext = prestamo;
        }

        private void SearchButton_Click(object render, RoutedEventArgs e)
        {

            Contexto context = new Contexto();

            var found = PrestamoBLL.Search(Convert.ToInt32(PrestamoIdTextBox.Text));

            if(found != null)
            this.prestamo = found;
            else{
            this.prestamo = new Prestamo();
            MessageBox.Show("No encontrado", "Error",MessageBoxButton.OK);
            }
            

            this.DataContext = this.prestamo;
        }

        private bool Validar(){
            bool esValido = true;
            if(PrestamoIdTextBox.Text.Length == 0 && MontoTextBox.Text.Length == 0 && ConceptoTextBox.Text.Length == 0 && PersonaIdTextBox.Text.Length == 0 /*&& PersonaBLL.Exist(Convert.ToInt32(PersonaIdTextBox.Text)) == false*/) 
            {
                esValido = false;
                MessageBox.Show("Error, Intentelo de nuevo", "Error",MessageBoxButton.OKCancel);

                
            }
            return esValido;
        }

        private void NewButton_Click(object render, RoutedEventArgs e){
            Limpiar();
        }

        private void DeleteButton_Click(object render, RoutedEventArgs e){
            if(PrestamoBLL.Delete(Convert.ToInt32(PrestamoIdTextBox.Text))){
                Limpiar();
                MessageBox.Show("Eliminado", "Exito",MessageBoxButton.OK);
            }
            else
            MessageBox.Show("Error al eliminar", "Error",MessageBoxButton.OK);
            
        }
        

    }
}