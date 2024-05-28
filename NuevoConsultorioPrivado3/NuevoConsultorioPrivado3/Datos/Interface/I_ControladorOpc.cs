using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Datos.Interface
{
    public interface I_ControladorOpc<T>
    {
        bool agregar(T objeto);
        bool asignar(T objeto);
        DataTable get(T objeto);
    }
}
