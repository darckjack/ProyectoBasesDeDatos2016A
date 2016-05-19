using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public interface ICicloEscolar
    {
        void agregarCiclo(CicloEscolar ciclo);
        void agregarCiclo(String nombre, String inicio, String fin);
        CicloEscolar obtener(int pos);
        CicloEscolar obtener(Guid id);
        CicloEscolar obtener(String nombre);
        CicloEscolar actualizar(CicloEscolar ciclo);
        CicloEscolar actualizar(Guid id, String nombre, String inicio, String fin);
        bool borrar(int pos);
        bool borrar(Guid id);
        bool borrar(CicloEscolar ciclo);
        List<CicloEscolar> listar();
        void cargarArchivo(String archivo);
        void guardarArchivo(String archivo);
        void limpiar();
    }
}
