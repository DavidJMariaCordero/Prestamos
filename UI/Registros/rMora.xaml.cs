using Prestamos.Entidades;
using Prestamos.BLL;
using System;
using System.Linq;
using System.Windows;

namespace Prestamos.UI.Registros
{
    /// <summary>
    /// Interaction logic for rMoras.xaml
    /// </summary>
    public partial class rMora : Window
    {
        Moras moras = new Moras();
    
        public rMora()
        {
            InitializeComponent();
            PrestamosComboBox.ItemsSource = PrestamoBLL.GetList();
            PrestamosComboBox.SelectedValuePath = "PrestamoId";
            PrestamosComboBox.DisplayMemberPath = "PrestamoId";
            Limpiar(); 
        }
        private void Limpiar()
        {
            this.moras = new Moras();
            this.moras.Fecha = DateTime.Now;
            this.DataContext = moras;
            TotalTextBox.Text = "0";

        }
        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            Moras encontrado = MorasBLL.Buscar(Convert.ToInt32(IdTextBox.Text));

            if (encontrado != null)
            {
                this.moras = encontrado;
                this.DataContext = null;
                this.DataContext = moras;
            }
            else
            {
                Limpiar();
                MessageBox.Show("La Mora no existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            Moras existe = MorasBLL.Buscar(this.moras.MoraId);

            if (existe == null)
            {
                MessageBox.Show("No existe la mora en la base de datos", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MorasBLL.Eliminar(this.moras.MoraId);
                MessageBox.Show("Eliminado", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            }
        }
        private void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;

            if (this.moras.MoraId == 0)
            {
                paso = MorasBLL.Guardar(moras);
            }
            else
            {
                if (Existe())
                {
                    paso = MorasBLL.Guardar(moras);
                }
                else
                {
                    MessageBox.Show("No existe en la base de datos", "Error");
                }
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Fallo al guardar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool Existe()
        {
            Moras esValido = MorasBLL.Buscar(moras.MoraId);

            return (esValido != null);
        }
        private void AgregarBoton_Click(object sender, RoutedEventArgs e)
        {
            moras.Total += Convert.ToDecimal(ValorTextBox.Text);
            moras.Detalle.Add(new MorasDetalle(moras.MoraId, Convert.ToInt32(PrestamosComboBox.SelectedValue), Convert.ToDecimal(ValorTextBox.Text)));
            
            this.DataContext = null;
            this.DataContext = moras;

            ValorTextBox.Clear();
        }

        private void RemoverBoton_Click(object sender, RoutedEventArgs e)
        {
            if (MorasDataGrid.Items.Count >= 1 && MorasDataGrid.SelectedIndex <= MorasDataGrid.Items.Count - 1)
            {
                MorasDetalle mora = (MorasDetalle)MorasDataGrid.SelectedValue;
                moras.Total -= mora.Valor;
                moras.Detalle.RemoveAt(MorasDataGrid.SelectedIndex);
                this.DataContext = null;
                this.DataContext = moras;
            }
        }

        private void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
    }
}