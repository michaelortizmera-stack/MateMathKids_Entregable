using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios;



namespace Ejercicios
{
    public partial class Form1 : Form
    {
        int contador = 0;

        int num1;
        int num2;
        int respuestaCorrecta;
        Random rnd = new Random();
        int contadorEjercicios = 0;
        int maxEjercicios = 10;
        public Form1(int a, int b)
        {
            InitializeComponent();

            num1 = a;
            num2 = b;

            CargarEjercicio();

        }


        public void CargarEjercicio()
        {
            if (contadorEjercicios >= maxEjercicios)
            {
                MessageBox.Show("¡Terminaste los 10 ejercicios!");
                // cierra el form
                return;
            }

            contadorEjercicios++;

            respuestaCorrecta = num1 + num2;

            operacion.Text = $"Ejercicio {contadorEjercicios}: ¿Cuánto es {num1} + {num2}=";

            GenerarOpciones();
        }

        // 🔹 Generar opciones
        void GenerarOpciones()
        {
            opcion_1.Text = respuestaCorrecta.ToString();
            opcion_2.Text = (respuestaCorrecta + rnd.Next(1, 4)).ToString();
            opcion_3.Text = (respuestaCorrecta - rnd.Next(1, 3)).ToString();

            MezclarBotones();
        }

        // 🔹 Mezclar botones
        void MezclarBotones()
        {
            string[] valores = {
                opcion_1.Text,
                opcion_2.Text,
                opcion_3.Text
            };

            for (int i = 0; i < valores.Length; i++)
            {
                int j = rnd.Next(valores.Length);
                string temp = valores[i];
                valores[i] = valores[j];
                valores[j] = temp;
            }

            opcion_1.Text = valores[0];
            opcion_2.Text = valores[1];
            opcion_3.Text = valores[2];
        }

        // 🔹 Verificar respuesta
        private void VerificarRespuesta(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int valor = int.Parse(btn.Text);

            if (valor == respuestaCorrecta)
            {
                MessageBox.Show("¡Correcto!");
            }
            else
            {
                MessageBox.Show("Intenta de nuevo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void opcion_1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }

        private void opcion_2_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }

        private void opcion_3_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }

        private void next_Click(object sender, EventArgs e)
        {

            contador++;

            if (contador >= maxEjercicios)
            {
                MessageBox.Show("¡Terminaste los ejercicios!");

                FormQuiz quiz = new FormQuiz();
                quiz.Show();

                this.Hide();
            }
            else
            {
                num1 = rnd.Next(1, 10);
                num2 = rnd.Next(1, 10);

                CargarEjercicio();
            }
        }
    }
}
    
    
        

    
    
