using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Modelo
{
    public class Paciente :Persona, IEntidad
    {
        /*private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string correo;
        private int telefono;*/
        public Paciente()
        { 
        }

        public Paciente(int id, 
                        string cedula, 
                        string nombres, 
                        string apellidos, 
                        string correo, 
                        string telefono,
                        string direccion)
            : base(id, cedula, nombres, apellidos, correo, telefono,direccion)
        {
            /*this.id = id;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.correo = correo;
            this.telefono = telefono;*/
        }
/*
        public int Id { getTabla => id; set => id = value; }
        public string Cedula { getTabla => cedula; set => cedula = value; }
        public string Nombre { getTabla => nombres; set => nombres = value; }
        public string Apellido { getTabla => apellidos; set => apellidos = value; }
        public string Correo { getTabla => correo; set => correo = value; }
        public int Telefono { getTabla => telefono; set => telefono = value; }*/
    }
}
