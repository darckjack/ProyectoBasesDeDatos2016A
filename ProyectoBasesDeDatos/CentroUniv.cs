using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public class CentroUniv
    {
        private Guid id;        
        private String nombre;                      

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public CentroUniv()
        {
            id = Guid.Empty;
            nombre = "";
        }

        public  CentroUniv(String nomCentro)
        {
            id = Guid.NewGuid();
            nombre = nomCentro;
        }

    }
}
