using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class csCola
    {
        private csNodo primerNodo;
        private csNodo ultimoNodo;

        public csCola()
        {
            primerNodo = null;
            ultimoNodo = null;
        }

        public bool ColaVacia()
        {
            return primerNodo == null;
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
                ultimoNodo.nodoSiguiente = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
        }

        public void EliminarElemento()
        {
            if (!ColaVacia())
            {
                primerNodo = primerNodo.nodoSiguiente;
                if (primerNodo == null)
                {
                    ultimoNodo = null;
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

        public void MostrarDatosCola(DataGridView griv)
        {
            griv.Rows.Clear();
            if (ContarElementos() != 0) {
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
