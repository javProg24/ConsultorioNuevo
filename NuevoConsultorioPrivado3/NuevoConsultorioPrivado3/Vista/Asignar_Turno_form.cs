using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Utilidad.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioPrivado.Vista
{
    public partial class Asignar_Turno_form : Form
    {
        private Especialidad especialidad;
        private ControladorTurno controlador = new ControladorTurno();
        public Asignar_Turno_form()
        {
            InitializeComponent();    
        }

        private void cargarComboEspecialidad()
        {
            cbx_Especialidad.DataSource=controlador.cargarEspecialidad();      
        }

        private void TurnoEspecialidad_Load(object sender, EventArgs e)
        {
            cargarComboEspecialidad();
        }
    }
}
