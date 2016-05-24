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
    /// <summary>
    /// Interaction logic for PEliminarCentros.xaml
    /// </summary>
    public partial class PEliminarCentros : Page
    {
        public PEliminarCentros()
        {
            InitializeComponent();
        }

        private ICentrosUniv centrosUniv;

        public ICentrosUniv CentrosUniv
        {
            get { return centrosUniv; }
            set { centrosUniv = value; }
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = centrosUniv.listarCentros();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedIndex >= 0)
            {
                centrosUniv.borrarCentro((CentroUniv)dataGrid.SelectedItem);
                MessageBox.Show("Registro eliminado", this.Title, MessageBoxButton.OK);
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", this.Title, MessageBoxButton.OK);
            }
        }
    }
}
