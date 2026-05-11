using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Interfaz_Niveles
{
    public partial class FrmNivelMultiplicacion : Form
    {
        // =====================================================
        // 1. VARIABLES GLOBALES
        // =====================================================
        int factor1;
        int factor2;
        int respuestaCorrecta;
        Random rnd = new Random();

        // Candado de seguridad para no saltar preguntas
        bool ejercicioRespondido = false;

        // Contadores de Práctica
        int contadorEjercicios = 0;
        int maxEjercicios = 10;

        // Contadores del Quiz Final
        int preguntaActualQuiz = 0;
        int puntajeFinalQuiz = 0;
        int totalPreguntasQuiz = 5;

        public FrmNivelMultiplicacion()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        // Muestra únicamente la teoría al arrancar
        private void ConfiguracionInicial()
        {
            pnlAprenderMultiplicacion.Visible = true;
            pnlEjerciciosMultiplicacion.Visible = false;
            pnlQuizM.Visible = false;

            pnlAprenderMultiplicacion.BringToFront();
        }

        // =====================================================
        // 2. FASE A: INICIO ("¡VAMOS A JUGAR!")
        // =====================================================
        private void lblVamosAJugar_Click(object sender, EventArgs e)
        {
            pnlAprenderMultiplicacion.Visible = false;
            pnlEjerciciosMultiplicacion.Visible = true;
            pnlEjerciciosMultiplicacion.BringToFront();

            contadorEjercicios = 0;
            CargarEjercicio();
        }

        // =====================================================
        // 3. FASE B: PRÁCTICA (10 EJERCICIOS)
        // =====================================================
        public void CargarEjercicio()
        {
            ejercicioRespondido = false; // Cerramos el candado
            contadorEjercicios++;

            // Multiplicaciones visuales (ej. de 2 a 5 grupos con 1 a 6 elementos)
            factor1 = rnd.Next(2, 6); // Cantidad de cajas
            factor2 = rnd.Next(1, 7); // Círculos por caja
            respuestaCorrecta = factor1 * factor2;

            lblOperacion.Text = $"Ejercicio {contadorEjercicios}: ¿Cuánto es {factor1} × {factor2}?";

            GenerarGraficosMultiplicacion(factor1, factor2);
            GenerarOpciones();
        }

        // Dibuja las cajas y los círculos automáticamente
        public void GenerarGraficosMultiplicacion(int grupos, int elementosPorGrupo)
        {
            PNLejercicios_Multiplicacion.Controls.Clear();

            for (int i = 0; i < grupos; i++)
            {
                FlowLayoutPanel panelGrupo = new FlowLayoutPanel();
                panelGrupo.Size = new Size(110, 110);
                panelGrupo.BorderStyle = BorderStyle.FixedSingle;
                panelGrupo.BackColor = Color.AliceBlue;
                panelGrupo.Padding = new Padding(5);

                for (int j = 0; j < elementosPorGrupo; j++)
                {
                    PictureBox picCirculo = new PictureBox();
                    picCirculo.Size = new Size(20, 20);
                    picCirculo.BackColor = Color.OrangeRed;

                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, picCirculo.Width, picCirculo.Height);
                    picCirculo.Region = new Region(path);

                    panelGrupo.Controls.Add(picCirculo);
                }
                PNLejercicios_Multiplicacion.Controls.Add(panelGrupo);
            }
        }

        void GenerarOpciones()
        {
            int opFalsa1 = respuestaCorrecta + rnd.Next(1, 4);
            int opFalsa2 = Math.Max(1, respuestaCorrecta - rnd.Next(1, 4));

            if (opFalsa1 == opFalsa2) opFalsa1++;
            if (opFalsa1 == respuestaCorrecta) opFalsa1 += 2;
            if (opFalsa2 == respuestaCorrecta) opFalsa2 -= 1;

            string[] valores = { respuestaCorrecta.ToString(), opFalsa1.ToString(), opFalsa2.ToString() };

            // Mezclar opciones
            for (int i = 0; i < valores.Length; i++)
            {
                int j = rnd.Next(valores.Length);
                string temp = valores[i];
                valores[i] = valores[j];
                valores[j] = temp;
            }

            btnOpcion1.Text = valores[0];
            btnOpcion2.Text = valores[1];
            btnOpcion3.Text = valores[2];
        }

        private void VerificarRespuesta(Button btn)
        {
            ejercicioRespondido = true; // Abrimos el candado

            if (int.Parse(btn.Text) == respuestaCorrecta)
            {
                MessageBox.Show("¡Correcto! Muy bien hecho.");
            }
            else
            {
                MessageBox.Show("Ups, intenta de nuevo.");
            }
        }

        private void btnOpcion1_Click(object sender, EventArgs e) { VerificarRespuesta(btnOpcion1); }
        private void btnOpcion2_Click(object sender, EventArgs e) { VerificarRespuesta(btnOpcion2); }
        private void btnOpcion3_Click(object sender, EventArgs e) { VerificarRespuesta(btnOpcion3); }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Validamos el candado
            if (ejercicioRespondido == false)
            {
                MessageBox.Show("¡Espera! Primero debes elegir una respuesta.", "Atención");
                return;
            }

            if (contadorEjercicios >= maxEjercicios)
            {
                MessageBox.Show("¡Felicidades! Terminaste la práctica. ¡Vamos al Quiz Final!");
                IrAlQuiz();
            }
            else
            {
                CargarEjercicio();
            }
        }

        // =====================================================
        // 4. FASE C: QUIZ FINAL (ESCRIBIR RESPUESTA)
        // =====================================================
        private void IrAlQuiz()
        {
            pnlEjerciciosMultiplicacion.Visible = false;

            pnlQuizM.Visible = true;
            pnlQuizM.BringToFront();

            preguntaActualQuiz = 0;
            puntajeFinalQuiz = 0;
            SiguientePreguntaQuiz();
        }

        private void SiguientePreguntaQuiz()
        {
            if (preguntaActualQuiz < totalPreguntasQuiz)
            {
                preguntaActualQuiz++;

                // Reto final: Tablas del 2 al 9
                int f1 = rnd.Next(2, 10);
                int f2 = rnd.Next(2, 10);
                respuestaCorrecta = f1 * f2;

                lblPreguntaQuiz.Text = $"Pregunta {preguntaActualQuiz}: ¿Cuánto es {f1} × {f2}?";

                txtRespuestaQuiz.Clear();
                txtRespuestaQuiz.Focus();
            }
            else
            {
                FinalizarQuiz();
            }
        }

        private void btnVerificarQuiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRespuestaQuiz.Text, out int respuestaNino))
            {
                if (respuestaNino == respuestaCorrecta)
                {
                    puntajeFinalQuiz += 10;
                    MessageBox.Show("¡Correcto! Excelente.", "¡Bien!");
                }
                else
                {
                    MessageBox.Show($"Ups, la respuesta correcta era {respuestaCorrecta}.", "¡A practicar!");
                }

                SiguientePreguntaQuiz();
            }
            else
            {
                MessageBox.Show("Por favor, escribe un número en el cuadro blanco.", "Atención");
                txtRespuestaQuiz.Focus();
            }
        }

        private void FinalizarQuiz()
        {
            MessageBox.Show($"¡Felicidades! Terminaste tu examen.\nLograste un total de: {puntajeFinalQuiz} puntos.", "Fin del Nivel");

            // CONEXIÓN A BASE DE DATOS (AQUÍ GUARDAS EL PUNTAJE)
            // BD.ActualizarPuntaje(usuarioActual, puntajeFinalQuiz);

            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
