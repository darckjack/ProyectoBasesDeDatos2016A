using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoBasesDeDatos
{
    public class AdmiCentrosUniv : ICentrosUniv
    {
        private List<CentroUniv> listaCentrosUniv = null;

        public AdmiCentrosUniv()
        {
            listaCentrosUniv = new List<CentroUniv>();
        }

        public void agregarCentro(CentroUniv centro)
        {
            listaCentrosUniv.Add(centro);
        }

        public void agregarCentro(string nombre)
        {
            listaCentrosUniv.Add(new CentroUniv(nombre));
        }        

        public CentroUniv obtener(int pos)
        {
            return listaCentrosUniv[pos];
        }

        public CentroUniv obtener(Guid id)
        {
            return listaCentrosUniv.Where(c => c.Id == id).FirstOrDefault();
        }

        public CentroUniv obtener(string nombre)
        {
            return listaCentrosUniv.Where(c => c.Nombre == nombre).FirstOrDefault();
        }

        public CentroUniv actualizar(Guid id, string nombreCentro)
        {
            CentroUniv cent = listaCentrosUniv.Where(c => c.Id == id).FirstOrDefault();
            if(cent != null && cent.Id != Guid.Empty)
            {
                cent.Nombre = nombreCentro;
            }
            return cent;
        }

        public CentroUniv actualizar(CentroUniv centro)
        {
            CentroUniv cent = listaCentrosUniv.Where(c => c.Id == centro.Id).FirstOrDefault();
            if (cent != null && cent.Id != Guid.Empty){
                cent = centro;
            }
            return cent;
        }        

        public bool borrar(int pos)
        {
            if(pos < listaCentrosUniv.Count)
            {
                listaCentrosUniv.RemoveAt(pos);
                return true;
            }
            return false;
        }

        public bool borrar(Guid id)
        {
            listaCentrosUniv.Remove(listaCentrosUniv.Where(c => c.Id == id).FirstOrDefault());
            return true;
        }

        public bool borrar(CentroUniv centro)
        {
            listaCentrosUniv.Remove(listaCentrosUniv.Where(c => c.Id == centro.Id).FirstOrDefault());
            return true;
        }

        public List<CentroUniv> listar()
        {
            return listaCentrosUniv;
        }

        public void cargarArchivo(string archivo)
        {
            if (File.Exists(archivo))
            {
                using (var sr = new StreamReader(archivo))
                {
                    var l = new XmlSerializer(typeof(List<CentroUniv>));
                    listaCentrosUniv = (List<CentroUniv>)l.Deserialize(sr);
                }                    
            }
        }

        public void guardarArchivo(string archivo)
        {
            using (var sw = new StreamWriter(archivo))
            {
                var g = new XmlSerializer(typeof(List<CentroUniv>));
                g.Serialize(sw, listaCentrosUniv);
            }
        }

        public void limpiar()
        {
            listaCentrosUniv.Clear();
        }

    }
}
