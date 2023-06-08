using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class csAlumno
    {
        private String Name;
        private String Apellido;
        private String Carnet;
        private String Edad;
        private String Carrera;
        private String Facultad;

        public String name
        {
            get { return Name; }
            set { Name = value; }
        }
        public String apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public String carnet
        {
            get { return Carnet; }
            set { Carnet = value; }
        }
        public String edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public String carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public String facultad
        {
            get { return Facultad; }
            set { Facultad = value; }
        }

        public void mostrarDatos(DataGridView griv, int fila)
        {
            griv[0, fila].Value = name;
            griv[1, fila].Value = apellido;
            griv[2, fila].Value = carnet;
            griv[3, fila].Value = edad;
            griv[4, fila].Value = carrera;
            griv[5, fila].Value = facultad;
        }

        public override string ToString()
        {
            return $" Nombre: {name} Apellido: {apellido} Carnet: {carnet} Edad: {edad} Carrera: {carrera} Facultad: {facultad}";
        }
    }
}
