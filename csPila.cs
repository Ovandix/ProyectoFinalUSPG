using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class csPila
    {
        private csNodo primerNodo;
        private csNodo ultimoNodo;

        public csPila()
        {
            primerNodo = null;
            ultimoNodo = null;
        }

        public bool ColaVacia()
        {
            return ultimoNodo == null;
        }

        public void AgregarElemento(csAlumno datos)
        {
            csNodo nuevoNodo = new csNodo(datos);

            if (ColaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.nodoSiguiente = primerNodo;
                primerNodo = nuevoNodo;
            }
        }

        public void EliminarElemento()
        {
            if (!ColaVacia())
            {
                primerNodo = primerNodo.nodoSiguiente;
                if (ultimoNodo == null)
                {
                    primerNodo = null;
                }
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }
        public csAlumno MoverElemento()
        {
            // csNodo nodoMover = new csNodo();
            // nodoMover = primerNodo;
            // nodoMover.nodoSiguiente = null;
            return primerNodo.datos;
        }
        public int ContarElementos()
        {
            int contador = 0;
            csNodo actual = primerNodo;
            while (actual != null)
            {
                contador++;
                actual = actual.nodoSiguiente;
            }
            return contador;
        }

        public void MostrarDatosPila(DataGridView griv)
        {
            griv.Rows.Clear();
            if (ContarElementos() != 0)
            {
                griv.RowCount = ContarElementos();
                int fila = 0;
                csNodo actual = primerNodo;
                while (actual != null)
                {
                    actual.datos.mostrarDatos(griv, fila);
                    actual = actual.nodoSiguiente;
                    fila++;
                }
            }
        }
    }
}
