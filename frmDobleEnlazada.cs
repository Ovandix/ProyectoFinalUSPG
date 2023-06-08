using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUSPG
{
    public partial class frmDobleEnlazada : Form
    {
        EnlazadaDoble Doble = new EnlazadaDoble();
        public frmDobleEnlazada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lista Enlazada Doble
            if (txtName.Text != "" & txtApellido.Text != "" & txtCarnet.Text != "" & txtEdad.Text != "" & txtCarrera.Text != "" & txtFacultad.Text != "")
            {
                csAlumno alumno = new csAlumno();
                alumno.name = txtName.Text;
                alumno.apellido = txtApellido.Text;
                alumno.carnet = txtCarnet.Text;
                alumno.edad = txtEdad.Text;
                alumno.carrera = txtCarrera.Text;
                alumno.facultad = txtFacultad.Text;

                this.Doble.AgregarNodoFinal(alumno);
                this.Doble.MostrarDatosListaDoble(grivAlumno);

                txtName.Text = "";
                txtApellido.Text = "";
                txtCarnet.Text = "";
                txtEdad.Text = "";
                txtCarrera.Text = "";
                txtFacultad.Text = "";
            }
        }

        private void grivAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            // Asegurarse de que la fila seleccionada no sea el encabezado
            if (filaSeleccionada >= 0)
            {
                // Llamar al método con la fila seleccionada
                this.Doble.MostrarNodoSiguienteAnterior(grivAlumno, filaSeleccionada);
            }
        }
    }
}
