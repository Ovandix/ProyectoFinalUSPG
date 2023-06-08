using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class csListaCircular
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
                ultimoNodo.nodoSiguiente = primerNodo; // Hacemos que el último nodo apunte al primer nodo para formar la lista circular.
            }
            else
            {
                nuevoNodo.nodoSiguiente = primerNodo; // Hacemos que el nuevo nodo apunte al primer nodo.
                ultimoNodo.nodoSiguiente = nuevoNodo; // Hacemos que el antiguo último nodo apunte al nuevo nodo.
                ultimoNodo = nuevoNodo; // Establecemos el nuevo nodo como el último nodo.
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
                do
                {
                    numeroNodos++;
                    auxiliar = auxiliar.nodoSiguiente;
                }
                while (auxiliar != primerNodo);
                return numeroNodos;
            }
        }

        public void MostrarDatosListaCircular(DataGridView griv)
        {
            if (!listaVacia())
            {
                griv.Rows.Clear();
                griv.RowCount = ContarNodos();
                csNodo auxiliar = primerNodo;
                int fila = 0;
                do
                {
                    auxiliar.datos.mostrarDatos(griv, fila);
                    auxiliar = auxiliar.nodoSiguiente;
                    fila++;
                }
                while (auxiliar != primerNodo);
            }
        }

   

        public void MostrarNodoSiguiente(DataGridView griv, int fila)
        {
            if (!listaVacia() && fila >= 0 && fila < griv.RowCount)
            {
                // Obtener el nodo correspondiente a la fila seleccionada
                csNodo nodoSeleccionado = ObtenerNodoEnFila(griv, fila);

                if (nodoSeleccionado != null)
                {
                    // Obtener el nodo siguiente en una lista circular
                    csNodo nodoSiguiente = nodoSeleccionado.nodoSiguiente != null ? nodoSeleccionado.nodoSiguiente : primerNodo;

                    // Mostrar información en un MessageBox
                    string mensaje = "Dato del nodo siguiente: " + ObtenerDatoNodo(nodoSiguiente);
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
                nodo = nodo.nodoSiguiente != null ? nodo.nodoSiguiente : primerNodo;
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
