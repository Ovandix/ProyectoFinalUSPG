using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalUSPG
{
    internal class csListaSimple
    {
        private csNodo primerNodo;
        private csNodo ultimoNodo;

        public csListaSimple()
        {
            primerNodo = null;
            ultimoNodo = null;
        }
        public bool listaVacia()
        {
            if (primerNodo != null)
            {
                return false;
            }
            else
            { return true; }
        }

        public void AgregarNodoInicial(csAlumno datos)
        {
            if (listaVacia())
            {
                csNodo nuevoNodo = new csNodo(datos);
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                csNodo nuevoNodo = new csNodo(datos, primerNodo);
                primerNodo = nuevoNodo;
            }
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
                
                ultimoNodo.nodoSiguiente = nuevoNodo;
                nuevoNodo.nodoSiguiente = null;
                ultimoNodo = nuevoNodo;
            }
        }

        public void EliminarNodoInicial()
        {
            if (!listaVacia())
            {
                if(primerNodo == ultimoNodo)
                {
                    primerNodo = null;
                    ultimoNodo = null;
                }
                else 
                { primerNodo = primerNodo.nodoSiguiente; }

            }
            else
            {
                MessageBox.Show("La lista esta vacia.");
            }
        }

        public void EliminarNodoFinal()
        {
            if (!listaVacia())
            {
                if (primerNodo == ultimoNodo)
                {
                    primerNodo = null;
                    ultimoNodo = null;
                }
                else
                { 
                    csNodo auxiliar = primerNodo;
                    while(auxiliar.nodoSiguiente != ultimoNodo) 
                    {
                        auxiliar = auxiliar.nodoSiguiente;
                    }
                    ultimoNodo = auxiliar;
                    ultimoNodo.nodoSiguiente = null;
                }

            }
            else
            {
                MessageBox.Show("La lista esta vacia.");
            }
        }

        public int contarNodos() 
        {
        if (!listaVacia())
            { 
            int numeroNodos = 0;
                csNodo auxiliar = primerNodo;
                while(auxiliar != null)
                {
                    numeroNodos++;
                    auxiliar = auxiliar.nodoSiguiente;
                }
                return numeroNodos;
            }
            else 
            { MessageBox.Show("La lista esta vacia."); 
                return 0; 
            }
        }

        public void mostrarDatosListaSimple(DataGridView griv)
        {
            if(!listaVacia())
            {
                griv.Rows.Clear();
                griv.RowCount = contarNodos();
                csNodo auxiliar = primerNodo;
                int fila = 0;
                while(auxiliar != null) 
                {
                    auxiliar.datos.mostrarDatos(griv, fila);
                    auxiliar = auxiliar.nodoSiguiente;
                    fila++;
                }

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
                    // Obtener el nodo siguiente
                    csNodo nodoSiguiente = nodoSeleccionado.nodoSiguiente;

                    // Mostrar información en un MessageBox
                    string mensaje = "Nodo siguiente: " + ObtenerDatosNodo(nodoSiguiente);
                    MessageBox.Show(mensaje);
                }
            }
        }

        private csNodo ObtenerNodoEnFila(DataGridView griv, int fila)
        {
            csNodo nodo = primerNodo;
            int contador = 0;

            while (nodo != null && contador < fila)
            {
                nodo = nodo.nodoSiguiente;
                contador++;
            }

            return nodo;
        }

        private string ObtenerDatosNodo(csNodo nodo)
        {
            if (nodo != null)
            {
                // Aquí puedes obtener los datos específicos del nodo que deseas mostrar
                return nodo.datos.ToString();
            }
            else
            {
                return "NULL";
            }
        }

        public void agregarNodo(csAlumno datos)
        {
            if (listaVacia())
            {
                csNodo nuevoNodo = new csNodo(datos);
                primerNodo= nuevoNodo;
                ultimoNodo= nuevoNodo;
            }
            else { csNodo nuevoNodo = new csNodo(datos);
                ultimoNodo.nodoSiguiente = nuevoNodo;
                primerNodo= ultimoNodo;
                ultimoNodo = nuevoNodo;
            }
        }
    }
}
