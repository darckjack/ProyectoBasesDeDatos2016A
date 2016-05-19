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
    /// Interaction logic for PInicioCentros.xaml
    /// </summary>
    public partial class PInicioCentros : Page
    {
        public PInicioCentros()
        {
            InitializeComponent();
        }

        ICentrosUniv centros;

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            PAgregarCentro p = new PAgregarCentro();
            p.CentrosUniv = centros;
            this.NavigationService.Navigate(p);
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            PListarCentros p = new PListarCentros();
            p.CentrosUniv = centros;
            this.NavigationService.Navigate(p);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            PEliminarCentros p = new PEliminarCentros();
            p.CentrosUniv = centros;
            this.NavigationService.Navigate(p);
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            PModificarCentro p = new PModificarCentro();
            p.CentrosUniv = centros;
            this.NavigationService.Navigate(p);
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            centros = ((GUIPrincipalCentros)this.Parent).listaCentrosUniv;
        }
    }
}
