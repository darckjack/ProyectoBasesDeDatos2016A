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
    public partial class PAgregarCiclo : Page
    {
        public PAgregarCiclo()
        {
            InitializeComponent();
        }

        private ICicloEscolar ciclos;
        
        public ICicloEscolar listaCiclos
        {
            get { return ciclos; }
            set { ciclos = value; }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String nombre, inicio, fin;
                nombre = txtNombre.Text.Trim();
                inicio = dpFechaInicio.Text.Trim();
                fin = dpFechaFin.Text.Trim();
                ciclos.agregarCiclo(nombre, inicio, fin);
                MessageBox.Show((Window)this.Parent, "Ciclo Escolar Agregado", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
