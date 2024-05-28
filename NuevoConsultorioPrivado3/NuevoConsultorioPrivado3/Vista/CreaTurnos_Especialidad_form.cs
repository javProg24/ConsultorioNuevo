using ConsultorioPrivado.Controlador;
using ConsultorioPrivado.Modelo;
using ConsultorioPrivado.Utilidad.Forms;
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
    public partial class CreaTurnos_Especialidad_form : Form
    {
        private bool ins_nuevo=false;
        private ControladorTurno objcontroladorTurno;
        private ControladorGeneral objcontrolador;
        public CreaTurnos_Especialidad_form()
        {
            InitializeComponent();
            objcontrolador = new ControladorGeneral();
            objcontroladorTurno = new ControladorTurno();
        }

        private void CreaTurnos_Especialidad_Load(object sender, EventArgs e)
        {
            cmb_Dia.DataSource = objcontroladorTurno.cargarDias();
            cmb_Jornada.Items.Add("Matutina");
            cmb_Jornada.Items.Add("Vespertina");
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Turno objturno=crearTurno();
            
        }
        private Turno crearTurno()
        {
            Turno objturno = new Turno();
            objturno.Especialidad=cbx_Especialidad.Text;
            objturno.Numero_Turno = Convert.ToInt32(txt_Numero_Turno.Text);
            objturno.Dia = cmb_Dia.Text;
            objturno.Jornada= cmb_Jornada.Text;
            objturno.Estado= cmb_Estado.Text;
            return objturno;
        }
        private void btn_Canelar_Click(object sender, EventArgs e)
        {

        }
        private void resetearControles()
        {
            txt_Numero_Turno.Text = string.Empty;
            cmb_Dia.Text = string.Empty;
            cmb_Jornada.Text= string.Empty;
            cbx_Especialidad.Text = string.Empty;
            cmb_Estado.Text = string.Empty;
        }
    }
}
