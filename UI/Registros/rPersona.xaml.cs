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
    public partial class rPersona : Window
    {
        
        private Persona person;
        public rPersona()
        {
            InitializeComponent();
            Limpiar();
        }

        public void SaveButton_Click(object render, RoutedEventArgs e)
        {
            if(!Validar())
                return;
            var paso = PersonaBLL.Save(person);
            if(paso){
                Limpiar();
                MessageBox.Show("Guardado con Exito", "Exito!!",MessageBoxButton.OK);
            }
            else
            MessageBox.Show("Error al guardar", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void Limpiar(){
            this.person = new Persona();
            this.DataContext = person;
        }

        private void SearchButton_Click(object render, RoutedEventArgs e)
        {

            Contexto context = new Contexto();

            var found = PersonaBLL.Search(Convert.ToInt32(PersonaIdTextBox.Text));

            if(found != null)
            this.person = found;
            else{
            this.person = new Persona();
            MessageBox.Show("No encontrado", "Error",MessageBoxButton.OK);
            }
            

            this.DataContext = this.person;
        }

        private bool Validar(){
            bool esValido = true;
            if(NombresTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Le falta incluir el nombre", "Error",MessageBoxButton.OKCancel);

                
            }
            return esValido;
        }

        private void NewButton_Click(object render, RoutedEventArgs e){
            Limpiar();
        }

        private void DeleteButton_Click(object render, RoutedEventArgs e){
            if(PersonaBLL.Delete(Convert.ToInt32(PersonaIdTextBox.Text))){
                Limpiar();
                MessageBox.Show("Eliminado", "Exito",MessageBoxButton.OK);
            }
            else
            MessageBox.Show("Error al eliminar", "Error",MessageBoxButton.OK);
            
        }
        

    }
}