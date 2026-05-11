using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSumas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            CargarPregunta();
        }
        int num1;
        int num2;
        int respuestaCorrecta;

        int preguntaActual = 0;
        int totalPreguntas = 10;
        int puntaje = 0;

        Random rnd = new Random();
        public void CargarPregunta()
        {
            if (preguntaActual >= totalPreguntas)
            {
                MostrarResultados();
                return;
            }

            preguntaActual++;

            num1 = rnd.Next(1, 6);
            num2 = rnd.Next(1, 6);

            respuestaCorrecta = num1 + num2;

            label_pregunta.Text = $"¿Cuánto es {num1} + {num2}?";
            label_progreso.Text = $"Pregunta {preguntaActual} de {totalPreguntas}";
            label_puntaje.Text = $"Puntaje: {puntaje}";

            GenerarOpciones();
        }
        public void GenerarOpciones()
        {
            int correcta = respuestaCorrecta;
            int falsa1, falsa2;

            do
            {
                falsa1 = correcta + rnd.Next(1, 4);
            } while (falsa1 == correcta);

            do
            {
                falsa2 = correcta - rnd.Next(1, 3);
            } while (falsa2 == correcta || falsa2 == falsa1);

            int[] opciones = { correcta, falsa1, falsa2 };

            for (int i = 0; i < opciones.Length; i++)
            {
                int j = rnd.Next(opciones.Length);
                int temp = opciones[i];
                opciones[i] = opciones[j];
                opciones[j] = temp;
            }

            button1.Text = opciones[0].ToString();
            button2.Text = opciones[1].ToString();
            button3.Text = opciones[2].ToString();
        }
        public void VerificarRespuesta(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int valor = int.Parse(btn.Text);

            if (valor == respuestaCorrecta)
            {
                puntaje++;
                MessageBox.Show("¡Correcto! 🎉");
            }
            else
            {
                MessageBox.Show("Incorrecto 😢");
            }

            CargarPregunta();
        }
        void MostrarResultados()
        {
            MessageBox.Show($"Juego terminado 🎯\nPuntaje final: {puntaje} de {totalPreguntas}");

            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
