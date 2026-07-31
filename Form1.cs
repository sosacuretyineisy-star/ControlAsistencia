using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlAsistencia
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar el alumno y si vino o no (true/false)
        private Dictionary<string, bool> asistencia = new Dictionary<string, bool>();

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Al cargar la ventana, se llena la lista de estudiantes
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] alumnos = { "Carlos Gómez", "Ana Martínez", "Luis Rodríguez", "María López", "Juan Pérez" };

            foreach (string alumno in alumnos)
            {
                lstEstudiantes.Items.Add(alumno);
                asistencia[alumno] = false; // Inician como ausentes
            }
        }

        // 2. Al seleccionar un alumno de la lista, el CheckBox muestra su estado guardado
        private void lstEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem != null)
            {
                string alumnoSeleccionado = lstEstudiantes.SelectedItem.ToString();
                chkPresente.Checked = asistencia[alumnoSeleccionado];
            }
        }

        // 3. Botón Guardar: actualiza el estado del alumno en el diccionario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem != null)
            {
                string alumnoSeleccionado = lstEstudiantes.SelectedItem.ToString();
                asistencia[alumnoSeleccionado] = chkPresente.Checked;

                MessageBox.Show("Asistencia registrada para " + alumnoSeleccionado,
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alumno de la lista.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 4. Botón Resumen: muestra un mensaje con la cantidad y nombres de asistentes
        private void btnResumen_Click(object sender, EventArgs e)
        {
            string listaAsistentes = "";
            int totalAsistentes = 0;

            foreach (KeyValuePair<string, bool> registro in asistencia)
            {
                if (registro.Value) // Si es true
                {
                    listaAsistentes += "• " + registro.Key + "\n";
                    totalAsistentes++;
                }
            }

            if (totalAsistentes > 0)
            {
                MessageBox.Show("Total de asistentes: " + totalAsistentes + "\n\n" + listaAsistentes,
                                "Resumen de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha registrado ningún asistente aún.",
                                "Resumen de Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}