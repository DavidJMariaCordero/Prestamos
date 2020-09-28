using System;
using System.Windows;
using System.Collections.Generic;
using Prestamos.BLL;
using Prestamos.Entidades;

namespace Prestamos.UI.Consultas
{
    public partial class cPrestamo : Window
    {
        public cPrestamo(){
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e){
            var listado = new List<Prestamo>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = PrestamoBLL.GetList(p => p.PrestamoId == this.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:                       
                        listado = PrestamoBLL.GetList(p => p.PersonaId == this.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = PrestamoBLL.GetList(c => true);
            }          

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }

        public int ToInt(string value)
        {
            int retorno = 0;

            int.TryParse(value, out retorno);

            return retorno;
        }

        private void DatosDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}