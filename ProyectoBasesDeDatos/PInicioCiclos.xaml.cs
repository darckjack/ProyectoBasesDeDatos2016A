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
    public partial class PInicioCiclos : Page
    {
        public PInicioCiclos()
        {
            InitializeComponent();
        }

        ICicloEscolar ciclos;

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ciclos = ((GUIPrincipalCiclos)this.Parent).ListaCiclos;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            PAgregarCiclo p = new PAgregarCiclo();
            p.listaCiclos = ciclos;
            this.NavigationService.Navigate(p);
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            PEliminarCiclo p = new PEliminarCiclo();
            p.ListaCiclos = ciclos;
            this.NavigationService.Navigate(p);
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            PModificarCiclo p = new PModificarCiclo();
            p.ListaCiclos = ciclos;
            this.NavigationService.Navigate(p);
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            PListarCiclos p = new PListarCiclos();
            p.ListaCiclos = ciclos;
            this.NavigationService.Navigate(p);
        }
    }
}
