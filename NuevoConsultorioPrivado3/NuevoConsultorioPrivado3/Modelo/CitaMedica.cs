using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioPrivado.Utilidad.Datos;

namespace ConsultorioPrivado.Modelo
{
    internal class CitaMedica : IEntidad
    {
        private int idCitaMedica;
        private Paciente paciente;
        private Medico medico;
        private TipoConsulta tipoConsulta;
        private DateTime horaConsulta;
        public CitaMedica(int idCitaMedica, Paciente paciente, 
            DateTime horaConsulta, TipoConsulta tipoConsulta, Medico medico)
        {
            this.idCitaMedica = idCitaMedica;
            this.paciente = paciente;
            this.horaConsulta = horaConsulta;
            this.medico = medico;
            this.tipoConsulta = tipoConsulta;
        }

        public int IdCitaMedica { get => idCitaMedica; set => idCitaMedica = value; }
        public DateTime HoraConsulta { get => horaConsulta; set => horaConsulta = value; }
        internal Paciente Paciente { get => paciente; set => paciente = value; }
        internal Medico Medico { get => medico; set => medico = value; }
        internal TipoConsulta TipoConsulta { get => tipoConsulta; set => tipoConsulta = value; }
    }
}
