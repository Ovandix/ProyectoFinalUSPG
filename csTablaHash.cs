using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinalUSPG
{
    internal class csTablaHash
    {
        private Dictionary<int, csAlumno> tablaHash;

        public csTablaHash()
        {
            tablaHash = new Dictionary<int, csAlumno>();
        }

        public bool EstaVacia()
        {
            return tablaHash.Count == 0;
        }

        public void AgregarAlumno(csAlumno alumno, int id)
        {
            tablaHash.Add(id, alumno);
        }

        public void ModificarAlumno(int id, csAlumno alumnoModificado)
        {
            if (tablaHash.ContainsKey(id))
            {
                tablaHash[id] = alumnoModificado;
            }
        }

        public void EliminarAlumno(int id, int fila, DataGridView grivA)
        {

            tablaHash.Remove(fila);
            

            if ((id-1) == fila)
            {
                grivA[0, fila].Value = "";
                grivA[1, fila].Value = "";
                grivA[2, fila].Value = "";
                grivA[3, fila].Value = "";
                grivA[4, fila].Value = "";
                grivA[5, fila].Value = "";
            }
            else
            {
                grivA.Rows.RemoveAt(fila);
            }

            while (fila < (id-1))
            {
                tablaHash[fila] = tablaHash[fila + 1];
                tablaHash.Remove(fila + 1);
                fila++;
            }

        }

        public int ContarAlumnos()
        {
            return tablaHash.Count;
        }

        public void MostrarDatosTablaHash(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.RowCount = tablaHash.Count;

            int fila = 0;
            foreach (var alumno in tablaHash.Values)
            {
                alumno.mostrarDatos(dataGridView, fila);
                fila++;
            }
        }

        public void MostrarAlumnoSiguiente(DataGridView dataGridView, int fila)
        {
            if (fila >= 0 && fila < dataGridView.RowCount)
            {
                if (fila + 1 < dataGridView.RowCount)
                {
                    int id = ObtenerIdEnFila(dataGridView, fila + 1);
                    if (tablaHash.ContainsKey(id))
                    {
                        csAlumno alumnoSiguiente = tablaHash[id];
                        string mensaje = "Alumno siguiente: " + alumnoSiguiente.ToString();
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }

        private int ObtenerIdEnFila(DataGridView dataGridView, int fila)
        {
            if (dataGridView.Rows[fila].Cells[0].Value != null)
            {
                return Convert.ToInt32(dataGridView.Rows[fila].Cells[0].Value);
            }
            return -1;
        }
    }
}
