using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class csNodo
    {
        private csAlumno Datos;
        private csNodo NodoSiguiente;
        private csNodo NodoAnterior;
        public csAlumno datos
        {
            get { return Datos; }
            set { Datos = value; }
        }

        public csNodo nodoSiguiente
        {
            get { return NodoSiguiente; }
            set { NodoSiguiente = value; }
        }

        public csNodo nodoAnterior
        {
            get { return NodoAnterior; }
            set { NodoAnterior = value; }
        }

       
        public csNodo(csAlumno alumno, csNodo nodo)
        {
            this.Datos = alumno;
            this.NodoSiguiente = nodo;
            
        }
        public csNodo(csAlumno alumno) 
        {
            this.Datos = alumno;
            this.NodoSiguiente = null;
            this.NodoAnterior = null;
        }
        public csNodo()
        {
            this.NodoSiguiente = null;
            this.NodoAnterior = null;
        }

        public string cambiarApellido(string apellido1) 
        {
            apellido1 = "Nuevo Apellido";
            return apellido1;
        }


    }
}
