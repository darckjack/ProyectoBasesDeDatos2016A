using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public interface ICentrosUniv
    {        
        void agregarCentro(String nombre);
        CentroUniv obtenerCentro(int id);
        bool actualizarCentro(CentroUniv centro);
        bool actualizarCentro(int id, String nombreCentro);
        bool borrarCentro(int id);
        bool borrarCentro(CentroUniv centro);
        List<CentroUniv> listarCentros();        
    }
}
