using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public class CicloEscolar
    {
        private int id;
        private String nombre;
        private String fechaInicio;
        private String fechaFin;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public String FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public CicloEscolar()
        {
            id = -1;
            nombre = "";
            fechaInicio = "";
            fechaFin = "";
        }

        public CicloEscolar(int id, String nom, String inicio, String fin)
        {
            this.id = id;
            nombre = nom;
            fechaInicio = inicio;
            fechaFin = fin;
        }

    }
}
