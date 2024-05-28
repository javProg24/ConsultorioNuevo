﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsultorioPrivado.Modelo
{
    public abstract class Persona
    {
        private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string correo;
        private string telefono;
        private string direccion;
        public Persona()
        {
            id = 0;
            cedula = string.Empty;
            nombres = string.Empty;
            apellidos = string.Empty;
            correo = string.Empty;
            telefono = string.Empty;
            direccion = string.Empty;
        }
        public Persona(int id, string cedula, 
                       string nombres, string apellidos, 
                       string correo,string telefono,string direccion)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.correo = correo;
            this.telefono = telefono;
            this.direccion = direccion;
        }
        public int Id { get => id; set => id = value; }
        public string Telefono { get => telefono;set => telefono = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
