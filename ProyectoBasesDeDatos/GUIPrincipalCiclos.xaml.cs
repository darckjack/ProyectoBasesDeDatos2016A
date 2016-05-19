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
    public partial class GUIPrincipalCiclos : NavigationWindow
    {
        public GUIPrincipalCiclos()
        {
            InitializeComponent();
        }

        private ICicloEscolar listaCiclos;

        public ICicloEscolar ListaCiclos
        {
            get { return listaCiclos; }
            set { listaCiclos = value; }
        }

        private void NavigationWindow_Loaded(object sender, RoutedEventArgs e)
        {
            listaCiclos = new AdmiCiclosEscolares();
        }
    }
}
