using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsultorioPrivado.Controlador
{
    public class ControladorTurno : I_ControladorOpc<Turno>
    {
        private DataAccess_DB interfaceDatos;
        private string error;
        private string rol;
        private string num;
        public ControladorTurno()
        {
            error = "Error";
            interfaceDatos = new ExecuteSP();
            rol = E_ROL._TURNO.ToString();
        }
        public List<string> cargarEspecialidad()
        {
            List<string> listaEspecialidad = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Especialidad)))
            {
                listaEspecialidad.Add(item.ToString());
            }
            return listaEspecialidad;
        }
        public List<string> cargarDias()
        {
            List<string> listaDias = new List<string>();
            foreach (var item in Enum.GetValues(typeof(Dia)))
            {
                listaDias.Add(item.ToString());
            }
            return listaDias;
        }

        public bool agregar(Turno objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                for (int i = 1; i <= objeto.Numero_Turno; i++)
                {
                    lista.Add(new CD_Parameter_SP("@parametro1", i, SqlDbType.Int));
                    lista.Add(new CD_Parameter_SP("@parametro2", objeto.Especialidad, SqlDbType.Text));
                    lista.Add(new CD_Parameter_SP("@parametro3", objeto.Dia, SqlDbType.Text));
                    lista.Add(new CD_Parameter_SP("@parametro4", objeto.Jornada, SqlDbType.Text));
                    lista.Add(new CD_Parameter_SP("@parametro8", objeto.ID_Medico, SqlDbType.Int));
                }
                objeto.Numero_Turno = 0;
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.crear(E_ROL._TURNO, lista);
            }
            catch (Exception e)
            {
                throw new Exception(error + ", no se pudo agregar el" + rol + " en " + objeto.Especialidad + e.Message);
            }
        }
        public bool asignar(Turno objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = [
                    new CD_Parameter_SP("@parametro1", objeto.Numero_Turno, SqlDbType.Int),
                    new CD_Parameter_SP("@parametro5", objeto.Estado, SqlDbType.Text),
                    new CD_Parameter_SP("@parametro6", objeto.ID_Paciente, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.asignar(E_ROL._TURNO, lista);
            }
            catch (Exception e)
            {
                throw new Exception(error + ", no se pudo asignar el" + rol + " en " + objeto.Especialidad + e.Message);
            }
        }

        public DataTable get(Turno objeto)
        {
            try
            {
                List<CD_Parameter_SP> lista = [
                    new CD_Parameter_SP("@parametro2", objeto.Especialidad, SqlDbType.Int)
                ];
                DataAccess_DB interfaceDatos = new ExecuteSP();
                return interfaceDatos.getId(E_ROL._TURNO, lista);
            }
            catch (Exception e)
            {
                throw new Exception(error + ", no puede ver los" + rol + e.Message);
            }
        }
    }
}
