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
    public partial class frmCircular : Form
    {
        csListaCircular listaCircular = new csListaCircular();
        public frmCircular()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Lista Circular
            if (txtName.Text != "" & txtApellido.Text != "" & txtCarnet.Text != "" & txtEdad.Text != "" & txtCarrera.Text != "" & txtFacultad.Text != "")
            {
                csAlumno alumno = new csAlumno();
                alumno.name = txtName.Text;
                alumno.apellido = txtApellido.Text;
                alumno.carnet = txtCarnet.Text;
                alumno.edad = txtEdad.Text;
                alumno.carrera = txtCarrera.Text;
                alumno.facultad = txtFacultad.Text;

                this.listaCircular.AgregarNodoFinal(alumno);
                this.listaCircular.MostrarDatosListaCircular(grivAlumno);

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
                this.listaCircular.MostrarNodoSiguiente(grivAlumno, filaSeleccionada);
            }
        }
    }
}