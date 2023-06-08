using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class EnlazadaDoble
    {
        private csNodo primerNodo;
        private csNodo ultimoNodo;

        public bool listaVacia()
        {
            return primerNodo == null;
        }

        public void AgregarNodoFinal(csAlumno datos)
        {
            csNodo nuevoNodo = new csNodo(datos);
            if (listaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.nodoAnterior = ultimoNodo;
                ultimoNodo.nodoSiguiente = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
        }

        public int ContarNodos()
        {
            if (listaVacia())
            {
                return 0;
            }
            else
            {
                int numeroNodos = 0;
                csNodo auxiliar = primerNodo;
                while (auxiliar != null)
                {
                    numeroNodos++;
                    auxiliar = auxiliar.nodoSiguiente;
                }
                return numeroNodos;
            }
        }

        public void MostrarDatosListaDoble(DataGridView griv)
        {
            if (!listaVacia())
            {
                griv.Rows.Clear();
                griv.RowCount = ContarNodos();
                csNodo auxiliar = primerNodo;
                int fila = 0;
                while (auxiliar != null)
                {
                    auxiliar.datos.mostrarDatos(griv, fila);
                    auxiliar = auxiliar.nodoSiguiente;
                    fila++;
                }
            }
        }

        public void MostrarNodoSiguienteAnterior(DataGridView griv, int fila)
        {
            if (!listaVacia() && fila >= 0 && fila < griv.RowCount)
            {
                // Obtener el nodo correspondiente a la fila seleccionada
                csNodo nodoSeleccionado = ObtenerNodoEnFila(griv, fila);

                if (nodoSeleccionado != null)
                {
                    // Obtener el nodo siguiente
                    csNodo nodoSiguiente = nodoSeleccionado.nodoSiguiente;

                    // Obtener el nodo anterior
                    csNodo nodoAnterior = nodoSeleccionado.nodoAnterior;

                    // Mostrar información en un MessageBox
                    string mensaje = "Dato del nodo siguiente: " + ObtenerDatoNodo(nodoSiguiente) + "\n";
                    mensaje += "Dato del nodo anterior: " + ObtenerDatoNodo(nodoAnterior);
                    MessageBox.Show(mensaje);
                }
            }
        }

        private csNodo ObtenerNodoEnFila(DataGridView griv, int fila)
        {
            csNodo nodo = primerNodo;
            int contador = 0;

            while (contador < fila)
            {
                nodo = nodo.nodoSiguiente;
                contador++;
            }

            return nodo;
        }

        private string ObtenerDatoNodo(csNodo nodo)
        {
            if (nodo != null)
            {
                // Aquí puedes obtener el dato específico del nodo que deseas mostrar
                return nodo.datos.ToString();
            }
            else
            {
                return "NULL";
            }
        }
    }
}
