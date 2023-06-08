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
    public partial class frmPila : Form
    {
        csPila pila = new csPila();
        csPila pila2 = new csPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" & txtApellido.Text != "" & txtCarnet.Text != "" & txtEdad.Text != "" & txtCarrera.Text != "" & txtFacultad.Text != "")
            {
                csAlumno alumno = new csAlumno();
                alumno.name = txtName.Text;
                alumno.apellido = txtApellido.Text;
                alumno.carnet = txtCarnet.Text;
                alumno.edad = txtEdad.Text;
                alumno.carrera = txtCarrera.Text;
                alumno.facultad = txtFacultad.Text;

                this.pila.AgregarElemento(alumno);
                this.pila.MostrarDatosPila(grivAlumno);

                txtName.Text = "";
                txtApellido.Text = "";
                txtCarnet.Text = "";
                txtEdad.Text = "";
                txtCarrera.Text = "";
                txtFacultad.Text = "";
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            this.pila2.AgregarElemento(this.pila.MoverElemento());
            this.pila.EliminarElemento();
            this.pila.MostrarDatosPila(grivAlumno);
            this.pila2.MostrarDatosPila(dataGridView1);
        }
    }
}
