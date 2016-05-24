using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public interface ICicloEscolar
    {
        void agregarCiclo(String nombre, String inicio, String fin);
        CicloEscolar obtenerCiclo(int id);
        bool actualizarCiclo(CicloEscolar ciclo);
        bool actualizarCiclo(int id, String nombre, String inicio, String fin);
        bool borrarCiclo(int id);
        bool borrarCiclo(CicloEscolar ciclo);
        List<CicloEscolar> listarCiclos();
    }
}
