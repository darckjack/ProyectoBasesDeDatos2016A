using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ProyectoBasesDeDatos
{
    public class AdmiCentrosUniv : ICentrosUniv
    {
        CentroUnivDAO DAO;

        public AdmiCentrosUniv()
        {
            DAO = new CentroUnivDAO();            
        }

        public bool actualizarCentro(CentroUniv centro)
        {
            return DAO.actualizar(centro.Id, centro.Nombre);
        }

        public bool actualizarCentro(int id, string nombreCentro)
        {
            return DAO.actualizar(id, nombreCentro);
        }

        public void agregarCentro(string nombre)
        {
            DAO.agregar(nombre);
        }

        public bool borrarCentro(CentroUniv centro)
        {
            return DAO.borrar(centro.Id);
        }

        public bool borrarCentro(int id)
        {
            return DAO.borrar(id);
        }

        public List<CentroUniv> listarCentros()
        {
            return DAO.listar();
        }

        public CentroUniv obtenerCentro(int id)
        {
            return DAO.obtener(id);
        }
    }
}
