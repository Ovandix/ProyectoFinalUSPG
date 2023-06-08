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
    public partial class frmTablaHash : Form
    {
        csTablaHash Hash = new csTablaHash();
        int id = 0;
        int filaSeleccionada;
        public frmTablaHash()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Tablas Hash
            if (txtName.Text != "" & txtApellido.Text != "" & txtCarnet.Text != "" & txtEdad.Text != "" & txtCarrera.Text != "" & txtFacultad.Text != "")
            {
                csAlumno alumno = new csAlumno();
                alumno.name = txtName.Text;
                alumno.apellido = txtApellido.Text;
                alumno.carnet = txtCarnet.Text;
                alumno.edad = txtEdad.Text;
                alumno.carrera = txtCarrera.Text;
                alumno.facultad = txtFacultad.Text;

                this.Hash.AgregarAlumno(alumno, id);
                this.Hash.MostrarDatosTablaHash(grivAlumno);
                id++;

                limpiarlabels();
            }
        }

        private void grivAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            // Asegurarse de que la fila seleccionada no sea el encabezado
            if (filaSeleccionada >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                agregarDatosLabels();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" & txtApellido.Text != "" & txtCarnet.Text != "" & txtEdad.Text != "" & txtCarrera.Text != "" & txtFacultad.Text != "")
            {
                csAlumno alumnomodificado = new csAlumno();
                alumnomodificado.name = txtName.Text;
                alumnomodificado.apellido = txtApellido.Text;
                alumnomodificado.carnet = txtCarnet.Text;
                alumnomodificado.edad = txtEdad.Text;
                alumnomodificado.carrera = txtCarrera.Text;
                alumnomodificado.facultad = txtFacultad.Text;

                this.Hash.ModificarAlumno(filaSeleccionada,alumnomodificado);
                this.Hash.MostrarDatosTablaHash(grivAlumno);
                limpiarlabels();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hash.EliminarAlumno(id, filaSeleccionada, grivAlumno);
            limpiarlabels();
            id = id - 1;
        }

        public void limpiarlabels()
        {
            txtName.Text = "";
            txtApellido.Text = "";
            txtCarnet.Text = "";
            txtEdad.Text = "";
            txtCarrera.Text = "";
            txtFacultad.Text = "";
        }

        public void agregarDatosLabels()
        {
            txtName.Text = grivAlumno[0, filaSeleccionada].Value.ToString();
            txtApellido.Text = grivAlumno[1, filaSeleccionada].Value.ToString();
            txtCarnet.Text = grivAlumno[2, filaSeleccionada].Value.ToString();
            txtEdad.Text = grivAlumno[3, filaSeleccionada].Value.ToString();
            txtCarrera.Text = grivAlumno[4, filaSeleccionada].Value.ToString();
            txtFacultad.Text = grivAlumno[5, filaSeleccionada].Value.ToString();
        }
    }
}
