using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Turno: IEntidad
    {
        private int id_turno;
        private int numero_turno;
        private string especialidad;
        private string dia;
        private string jornada;
        private string estado;
        private int id_paciente;
        private int id_medico;
        public Turno()
        {
            id_medico = 0;
            id_turno = 0;
            id_paciente = 0;
            numero_turno = 0;
            especialidad=string.Empty;
            dia=string.Empty;
            jornada=string.Empty;
            estado="Disponible";
        }
        public Turno(int id_turno, int numero_turno, string especialidad, string dia, string jornada, string estado, int id_paciente, int id_medico)
        {
            this.id_turno = id_turno;
            this.numero_turno = numero_turno;
            this.especialidad = especialidad;
            this.dia = dia;
            this.jornada = jornada;
            this.estado = estado;
            this.id_paciente = id_paciente;
            this.id_medico = id_medico;
        }
        public int ID_Paciente { get { return id_paciente; } set { id_paciente = value; } }
        public int ID_Medico { get {  return id_medico; } set {id_medico = value;} }
        public string Especialidad { get {  return especialidad; } set {  especialidad = value;} }
        public string Dia { get {  return dia; } set {  dia = value; } }
        public string Jornada { get {  return jornada; } set {  jornada = value; } }
        public int ID_Turno {  get { return id_turno; } set { id_turno = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public int Numero_Turno { get { return numero_turno; }set { numero_turno = value; } }

    }
}
