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

namespace ProyectoBasesDeDatos
{
    public partial class PModificarCiclo : Page
    {
        public PModificarCiclo()
        {
            InitializeComponent();
        }

        private ICicloEscolar ciclos;

        public ICicloEscolar ListaCiclos
        {
            get { return ciclos; }
            set { ciclos = value; }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CicloEscolar temp = (CicloEscolar)dataGrid.SelectedItem;
            txtNombre.Text = temp.Nombre;
            dpInicio.Text = temp.FechaInicio;
            dpFin.Text = temp.FechaFin;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = ciclos.listarCiclos();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedIndex >= 0)
            {
                CicloEscolar temp = (CicloEscolar)dataGrid.SelectedItem;
                temp.Nombre = txtNombre.Text.Trim();
                temp.FechaInicio = dpInicio.Text.Trim();
                temp.FechaFin = dpInicio.Text.Trim();
                ciclos.actualizarCiclo(temp);
                MessageBox.Show("Registro Modificado", this.Title, MessageBoxButton.OK);
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Selecciona un registro", this.Title, MessageBoxButton.OK);
            }
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
