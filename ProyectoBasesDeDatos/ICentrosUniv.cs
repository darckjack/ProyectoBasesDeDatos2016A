using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    public interface ICentrosUniv
    {
        void agregarCentro(CentroUniv centro);
        void agregarCentro(String nombre);
        CentroUniv obtener(int pos);
        CentroUniv obtener(Guid id);
        CentroUniv obtener(String nombre);
        CentroUniv actualizar(CentroUniv centro);
        CentroUniv actualizar(Guid id, String nombreCentro);
        bool borrar(int pos);
        bool borrar(Guid id);
        bool borrar(CentroUniv centro);
        List<CentroUniv> listar();
        void cargarArchivo(String archivo);
        void guardarArchivo(String archivo);
        void limpiar();
    }
}
