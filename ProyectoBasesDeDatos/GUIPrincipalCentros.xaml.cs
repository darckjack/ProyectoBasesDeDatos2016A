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
    public partial class GUIPrincipalCentros : NavigationWindow
    {
        public GUIPrincipalCentros()
        {
            InitializeComponent();
        }

        private ICentrosUniv centroUniv;

        public ICentrosUniv listaCentrosUniv
        {
            get { return centroUniv; }
            set { centroUniv = value; }
        }

        private void NavigationWindow_Loaded(object sender, RoutedEventArgs e)
        {
            centroUniv = new AdmiCentrosUniv();
        }

        private void NavigationWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
