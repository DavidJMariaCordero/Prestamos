using System;
using System.Windows;
using System.Collections.Generic;
using Prestamos.BLL;
using Prestamos.Entidades;

namespace Prestamos.UI.Consultas
{
    public partial class cPersona : Window
    {
        public cPersona(){
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e){
            var listado = new List<Persona>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = PersonaBLL.GetList(p => p.PersonaId == this.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = PersonaBLL.GetList(c => true);
            }          

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }

        public int ToInt(string value)
        {
            int return_ = 0;

            int.TryParse(value, out return_);

            return return_;
        }

        private void DatosDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}