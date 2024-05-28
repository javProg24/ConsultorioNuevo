using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad.Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsultorioPrivado.Datos.Interface
{
    public interface DataAccess_DB
    {
        DataTable getTabla(E_ROL rol);
        DataTable getId(E_ROL rol, List<CD_Parameter_SP> lista);
        bool crear(E_ROL rol, List<CD_Parameter_SP> lista);
        bool actualiza(E_ROL rol, List<CD_Parameter_SP> lista);
        bool elimina(E_ROL rol, List<CD_Parameter_SP> lista);
        DataTable buscar(E_ROL rol, List<CD_Parameter_SP> lista);
        DataTable getNombresCompletos(E_ROL rol);
        bool asignar(E_ROL rol, List<CD_Parameter_SP> lista);
    }
}
