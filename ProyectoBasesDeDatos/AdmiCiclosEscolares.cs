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
    class AdmiCiclosEscolares : ICicloEscolar
    {
        CicloEscolarDAO DAO;

        public AdmiCiclosEscolares()
        {
            DAO = new CicloEscolarDAO();
        }

        public bool actualizarCiclo(CicloEscolar ciclo)
        {
            return DAO.actualizar(ciclo.ID, ciclo.Nombre, ciclo.FechaInicio, ciclo.FechaFin);
        }

        public bool actualizarCiclo(int id, string nombre, string inicio, string fin)
        {
            return DAO.actualizar(id, nombre, inicio, fin);
        }

        public void agregarCiclo(string nombre, string inicio, string fin)
        {
            DAO.agregar(nombre, inicio, fin);
        }

        public bool borrarCiclo(CicloEscolar ciclo)
        {
            return DAO.borrar(ciclo.ID);
        }

        public bool borrarCiclo(int id)
        {
            return DAO.borrar(id);
        }
        
        public List<CicloEscolar> listarCiclos()
        {
            return DAO.listar();
        }
        
        public CicloEscolar obtenerCiclo(int id)
        {
            return DAO.obtener(id);
        }
    }
}
