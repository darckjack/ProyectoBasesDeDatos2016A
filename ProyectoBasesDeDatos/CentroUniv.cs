using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public class CentroUniv
    {
        private int id;        
        private String nombre;                      

        public int Id
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
            id = -1;
            nombre = "";
        }

        public  CentroUniv(int id,String nomCentro)
        {
            this.id = id;
            nombre = nomCentro;
        }

    }
}
