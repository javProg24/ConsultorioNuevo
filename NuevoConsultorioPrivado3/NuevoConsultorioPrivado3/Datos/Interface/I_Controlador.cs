using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.Interface
{
    public interface I_Controlador<T>
    {
        DataTable getTabla();
        DataTable getId(T objeto);
        bool crear(T objeto);
        bool actualizar(T objeto);
        bool eliminar(T objeto);
        DataTable buscar(T objeto);
    }
}
