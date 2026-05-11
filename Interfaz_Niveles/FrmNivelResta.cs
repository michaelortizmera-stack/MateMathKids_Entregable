using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDatos;
using Modelos;


namespace Interfaz_Niveles
{
    public partial class FrmNivelResta : Form
    {

        // Variable para guardar todas las preguntas que nos mande la BD
        List<EjercicioResta> listaDeEjercicios;

        // Variable para saber en qué número de pregunta vamos (0 es la primera)
        int indicePregunta = 0;

        int respuestaCorrectaDelQuiz = 0;
        // Variables para controlar el Quiz
        List<EjercicioResta> listaQuiz;
        int indiceQuiz = 0;
        private void MostrarPregunta()
        {
            // 1. Sacamos la pregunta de turno de nuestra lista
            EjercicioResta preguntaActual = listaDeEjercicios[indicePregunta];

            // 2. Cambiamos el texto del hueco blanco grande
            lblPreguntaResta.Text = preguntaActual.Pregunta;

            // 3. Cambiamos los textos de tus cuadritos de colores
            // (Por ahora los ponemos en orden, luego haremos que se revuelvan para que la respuesta correcta no esté siempre en el botón amarillo)
            lblOpcion1R.Text = preguntaActual.RespuestaCorrecta.ToString(); // El botón amarillo
            lblOpcion2R.Text = preguntaActual.OpcionMala1.ToString();       // El botón verde
            lblOpcion3R.Text = preguntaActual.OpcionMala2.ToString();       // El botón naranja
        }
        public FrmNivelResta()
        {
            InitializeComponent();
            // Obligamos a la pantalla a empezar SIEMPRE por la teoría
            pnlTeoria.Visible = true;
            pnlTeoria.BringToFront(); // <--- ¡Esta línea lo trae al frente de todo!

            pnlEjercicios.Visible = false;
            pnlQuiz.Visible = false;
        }

        private void lblAjugarResta_Click(object sender, EventArgs e)
        {
            // Ocultamos el panel de la explicación
            pnlTeoria.Visible = false;

            // Mostramos el panel donde están los ejercicios
            pnlEjercicios.Visible = true;

            // Llamamos a la base de datos para que nos traiga los ejercicios
            EjerciciosRestaBD bd = new EjerciciosRestaBD();
            listaDeEjercicios = bd.ObtenerEjercicios();

            // Mostramos la primera pregunta en los botones
            MostrarPregunta();
        }
        private void ComprobarRespuesta(string textoDelBoton)
        {
            // 1. Convertimos el texto que tiene el botón a número
            int numeroElegido = int.Parse(textoDelBoton);

            // 2. Buscamos cuál era la respuesta correcta en nuestra lista
            int correcta = listaDeEjercicios[indicePregunta].RespuestaCorrecta;

            // 3. ¡El momento de la verdad! Comparamos
            if (numeroElegido == correcta)
            {
                MessageBox.Show("¡Correcto! Muy bien hecho.");

                // Sumamos 1 para avanzar a la siguiente pregunta
                indicePregunta = indicePregunta + 1;

                // Revisamos si aún quedan más preguntas en la lista
                if (indicePregunta < listaDeEjercicios.Count)
                {
                    MostrarPregunta(); // Recargamos la pantalla con la nueva pregunta
                }
                else
                {
                    // ¡Se acabaron los ejercicios! Pasamos al "Jefe Final"
                    MessageBox.Show("¡Increíble! Terminaste los ejercicios. ¡Prepárate para el Quiz!");
                    pnlEjercicios.Visible = false;
                    pnlQuiz.Visible = true;

                    // 1. Llamamos a la base de datos para traer la lista de 3 preguntas
                    EjerciciosRestaBD bd = new EjerciciosRestaBD();
                    listaQuiz = bd.ObtenerPreguntasQuiz();

                    // 2. Mostramos la primera de esas 3 preguntas
                    MostrarPreguntaQuiz();
                }
            }
            else
            {
                MessageBox.Show("Ups, esa no es. ¡Intenta de nuevo!");
            }
        }
        private void lblOpcion1R_Click(object sender, EventArgs e)
        {
            ComprobarRespuesta(lblOpcion1R.Text);
        }

        private void lblOpcion2R_Click(object sender, EventArgs e)
        {
            ComprobarRespuesta(lblOpcion2R.Text);
        }

        private void lblOpcion3R_Click(object sender, EventArgs e)
        {
            ComprobarRespuesta(lblOpcion3R.Text);

        }

        private void lblEvaluarQuizR_Click(object sender, EventArgs e)
        {
            string respuestaDelNino = txtRespuestaQuizR.Text.Trim();

            if (respuestaDelNino == respuestaCorrectaDelQuiz.ToString())
            {
                MessageBox.Show("¡Correcto! ¡Golpe crítico al Jefe!");

                // Sumamos 1 para avanzar
                indiceQuiz = indiceQuiz + 1;

                // Revisamos si quedan más preguntas del quiz
                if (indiceQuiz < listaQuiz.Count)
                {
                    MostrarPreguntaQuiz(); // Cargamos la siguiente
                }
                else
                {
                    // Ya pasó las 3 preguntas del Quiz
                    MessageBox.Show("¡FELICIDADES! ¡Derrotaste al Jefe y superaste el Nivel 2!");
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("¡Oh no! Esa no es la respuesta correcta. ¡Intenta de nuevo!");
                txtRespuestaQuizR.Text = "";
                txtRespuestaQuizR.Focus();
            }
        }
            private void MostrarPreguntaQuiz()
        {
            // 1. Sacamos la pregunta actual del quiz
            EjercicioResta preguntaActualQuiz = listaQuiz[indiceQuiz];

            // 2. La mostramos en la pantalla
            lblPreguntaQuizR.Text = preguntaActualQuiz.Pregunta;
            respuestaCorrectaDelQuiz = preguntaActualQuiz.RespuestaCorrecta;

            // 3. Limpiamos la caja y ponemos el cursor ahí
            txtRespuestaQuizR.Text = "";
            txtRespuestaQuizR.Focus();
        }
    }
    }

