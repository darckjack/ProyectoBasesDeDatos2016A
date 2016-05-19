using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoBasesDeDatos
{
    class AdmiCiclosEscolares : ICicloEscolar
    {

        List<CicloEscolar> ciclos = null;

        public AdmiCiclosEscolares()
        {
            ciclos = new List<CicloEscolar>();
        }

        public CicloEscolar actualizar(CicloEscolar ciclo)
        {
            CicloEscolar cicl = ciclos.Where(c => c.ID == ciclo.ID).FirstOrDefault();
            if (cicl != null && cicl.ID != Guid.Empty)
            {
                cicl = ciclo;
            }
            return cicl;
        }

        public CicloEscolar actualizar(Guid id, string nombre, string inicio, string fin)
        {
            CicloEscolar ciclo = ciclos.Where(c => c.ID == id).FirstOrDefault();
            if (ciclo != null && ciclo.ID != Guid.Empty)
            {
                ciclo.Nombre = nombre;
                ciclo.FechaInicio = inicio;
                ciclo.FechaFin = fin;
            }
            return ciclo;
        }

        public void agregarCiclo(CicloEscolar ciclo)
        {
            ciclos.Add(ciclo);
        }

        public void agregarCiclo(string nombre, string inicio, string fin)
        {
            ciclos.Add(new CicloEscolar(nombre, inicio, fin));
        }

        public bool borrar(CicloEscolar ciclo)
        {
            ciclos.Remove(ciclos.Where(c => c.ID == ciclo.ID).FirstOrDefault());
            return true;
        }

        public bool borrar(Guid id)
        {
            ciclos.Remove(ciclos.Where(c => c.ID == id).FirstOrDefault());
            return true;
        }

        public bool borrar(int pos)
        {
            if(pos < ciclos.Count)
            {
                ciclos.RemoveAt(pos);
                return true;
            }
            return false;
        }

        public void cargarArchivo(string archivo)
        {
            if (File.Exists(archivo))
            {
                using (var sr = new StreamReader(archivo))
                {
                    var l = new XmlSerializer(typeof(List<CicloEscolar>));
                    ciclos = (List<CicloEscolar>)l.Deserialize(sr);
                }
            }
        }

        public void guardarArchivo(string archivo)
        {
            using (var sw = new StreamWriter(archivo))
            {
                var g = new XmlSerializer(typeof(List<CicloEscolar>));
                g.Serialize(sw, ciclos);
            }
        }

        public void limpiar()
        {
            ciclos.Clear();
        }

        public List<CicloEscolar> listar()
        {
            return ciclos;
        }

        public CicloEscolar obtener(string nombre)
        {
            return ciclos.Where(c => c.Nombre == nombre).FirstOrDefault();
        }

        public CicloEscolar obtener(Guid id)
        {
            return ciclos.Where(c => c.ID == id).FirstOrDefault();
        }

        public CicloEscolar obtener(int pos)
        {
            return ciclos[pos];
        }
    }
}
