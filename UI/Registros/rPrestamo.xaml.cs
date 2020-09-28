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
            
            if(MontoTextBox.Text.Length == 1 && ConceptoTextBox.Text.Length == 0 && PersonaIdTextBox.Text.Length == 1) 
            {
                esValido = false;
                MessageBox.Show("Todos los campos deben estar completos. \nPor favor complete todos los campos", "Error",MessageBoxButton.OKCancel);

                
            }
            else if(!PersonaBLL.Exist(Convert.ToInt32(PersonaIdTextBox.Text))){
                esValido = false;
                MessageBox.Show("El ID de la persona no existe", "Error",MessageBoxButton.OKCancel);
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