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
    /// Interaction logic for PAgregarCentro.xaml
    /// </summary>
    public partial class PAgregarCentro : Page
    {
        public PAgregarCentro()
        {
            InitializeComponent();
        }

        private ICentrosUniv centrosUniv;

        public ICentrosUniv CentrosUniv
        {
            get { return centrosUniv; }
            set { centrosUniv = value; }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String nombre = txtNombre.Text.Trim();
                centrosUniv.agregarCentro(nombre);
                MessageBox.Show((Window)this.Parent, "Centro Universitario Agregado", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: " + this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }            
        }
    }
}
