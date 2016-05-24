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
    public partial class PEliminarCiclo : Page
    {
        public PEliminarCiclo()
        {
            InitializeComponent();
        }

        private ICicloEscolar ciclos;

        public ICicloEscolar ListaCiclos
        {
            get { return ciclos; }
            set { ciclos = value; }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = ciclos.listarCiclos();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedIndex >= 0)
            {                                               
                ciclos.borrarCiclo((CicloEscolar)dataGrid.SelectedItem);
                MessageBox.Show("Registro eliminado", this.Title, MessageBoxButton.OK);
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", this.Title, MessageBoxButton.OK);
            }
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
