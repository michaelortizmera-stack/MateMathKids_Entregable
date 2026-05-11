using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Interfaz_Niveles
{
    public partial class FrmNivelDivision : Form
    {
        // =====================================================
        // 1. VARIABLES GLOBALES
        // =====================================================
        int dividendo;
        int divisor;
        int respuestaCorrecta;
        Random rnd = new Random();

        // Candado para obligar a responder en la práctica
        bool respondidoPractica = false;

        // Contadores de Práctica
        int contadorEjercicios = 0;
        int maxEjercicios = 10;

        // Contadores del Quiz Final
        int preguntaActualQuiz = 0;
        int puntajeFinalQuiz = 0;
        int totalPreguntasQuiz = 5;

        public FrmNivelDivision()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        // Asegura que al abrir la ventana solo se vea la teoría
        private void ConfiguracionInicial()
        {
            pnlAprenderDivision.Visible = true;
            pnlEjerciciosDivision.Visible = false;
            pnlQuizD.Visible = false;

            pnlAprenderDivision.BringToFront();
        }

        // =====================================================
        // 2. FASE A: DE LA TEORÍA A LA PRÁCTICA
        // =====================================================
        private void lblVamosAJugar_Click(object sender, EventArgs e)
        {
            pnlAprenderDivision.Visible = false;
            pnlEjerciciosDivision.Visible = true;
            pnlEjerciciosDivision.BringToFront();

            contadorEjercicios = 0;
            CargarEjercicio();
        }

        // =====================================================
        // 3. FASE B: PRÁCTICA (10 EJERCICIOS)
        // =====================================================
        public void CargarEjercicio()
        {
            contadorEjercicios++;

            // Ponemos el candado: no ha respondido este nuevo ejercicio
            respondidoPractica = false;

            divisor = rnd.Next(2, 6);
            respuestaCorrecta = rnd.Next(1, 7);
            dividendo = divisor * respuestaCorrecta;

            lblOperacion.Text = $"Ejercicio {contadorEjercicios}: ¿Cuánto es {dividendo} ÷ {divisor}?";

            GenerarGraficosDivision(dividendo, divisor);
            GenerarOpciones();
        }

        public void GenerarGraficosDivision(int dividendo, int divisor)
        {
            int cociente = dividendo / divisor;
            PNLejercicios_Division.Controls.Clear();

            for (int i = 0; i < divisor; i++)
            {
                FlowLayoutPanel panelGrupo = new FlowLayoutPanel();
                panelGrupo.Size = new Size(110, 110);
                panelGrupo.BorderStyle = BorderStyle.FixedSingle;
                panelGrupo.BackColor = Color.AliceBlue;
                panelGrupo.Padding = new Padding(5);

                for (int j = 0; j < cociente; j++)
                {
                    PictureBox picCirculo = new PictureBox();
                    picCirculo.Size = new Size(20, 20);
                    picCirculo.BackColor = Color.OrangeRed;

                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, picCirculo.Width, picCirculo.Height);
                    picCirculo.Region = new Region(path);

                    panelGrupo.Controls.Add(picCirculo);
                }
                PNLejercicios_Division.Controls.Add(panelGrupo);
            }
        }

        void GenerarOpciones()
        {
            int opFalsa1 = respuestaCorrecta + rnd.Next(1, 3);
            int opFalsa2 = Math.Max(1, respuestaCorrecta - rnd.Next(1, 3));
            if (opFalsa1 == opFalsa2) opFalsa1++;

            string[] valores = { respuestaCorrecta.ToString(), opFalsa1.ToString(), opFalsa2.ToString() };

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
            // Quitamos el candado porque ya eligió una opción
            respondidoPractica = true;

            if (int.Parse(btn.Text) == respuestaCorrecta)
            {
                MessageBox.Show("¡Correcto! Muy bien hecho.", "¡Excelente!");
            }
            else
            {
                MessageBox.Show("Ups, intenta de nuevo.", "Sigue practicando");
            }
        }

        private void btnOpcion1_Click(object sender, EventArgs e) { VerificarRespuesta(btnOpcion1); }
        private void btnOpcion2_Click(object sender, EventArgs e) { VerificarRespuesta(btnOpcion2); }
        private void btnOpcion3_Click(object sender, EventArgs e) { VerificarRespuesta(btnOpcion3); }

        // BOTÓN SIGUIENTE (CON VALIDACIÓN)
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Si el candado sigue cerrado, detenemos al usuario aquí mismo
            if (!respondidoPractica)
            {
                MessageBox.Show("¡Debes seleccionar una respuesta antes de pasar al siguiente ejercicio!", "Atención");
                return; // Evita que el código siga avanzando
            }

            if (contadorEjercicios >= maxEjercicios)
            {
                MessageBox.Show("¡Felicidades! Terminaste la práctica. ¡Vamos al Quiz Final!", "¡Muy bien!");
                IrAlQuiz();
            }
            else
            {
                CargarEjercicio();
            }
        }

        // =====================================================
        // 4. FASE C: QUIZ FINAL (CON VALIDACIÓN DE CAJA VACÍA)
        // =====================================================
        private void IrAlQuiz()
        {
            pnlEjerciciosDivision.Visible = false;

            pnlQuizD.Visible = true;
            pnlQuizD.BringToFront();

            preguntaActualQuiz = 0;
            puntajeFinalQuiz = 0;
            SiguientePreguntaQuiz();
        }

        private void SiguientePreguntaQuiz()
        {
            if (preguntaActualQuiz < totalPreguntasQuiz)
            {
                preguntaActualQuiz++;

                int d_divisor = rnd.Next(2, 6);
                int d_respuesta = rnd.Next(1, 10);
                int d_dividendo = d_divisor * d_respuesta;

                respuestaCorrecta = d_respuesta;

                lblPreguntaQuiz.Text = $"Pregunta {preguntaActualQuiz}: ¿Cuánto es {d_dividendo} ÷ {d_divisor}?";

                txtRespuestaQuiz.Clear();
                txtRespuestaQuiz.Focus();
            }
            else
            {
                FinalizarQuiz();
            }
        }

        // BOTÓN VERIFICAR QUIZ (CON VALIDACIÓN Y PUNTAJE)
        private void btnVerificarQuiz_Click(object sender, EventArgs e)
        {
            // 1. Validamos estrictamente que la caja NO esté en blanco
            if (string.IsNullOrWhiteSpace(txtRespuestaQuiz.Text))
            {
                MessageBox.Show("¡No dejes la caja vacía! Escribe un número para poder avanzar.", "Atención");
                txtRespuestaQuiz.Focus();
                return; // Detiene la ejecución
            }

            // 2. Validamos que lo que escribió sea un número válido
            if (int.TryParse(txtRespuestaQuiz.Text, out int respuestaNino))
            {
                if (respuestaNino == respuestaCorrecta)
                {
                    puntajeFinalQuiz += 10; // Sumamos 10 puntos por acierto
                    MessageBox.Show("¡Correcto! Excelente.", "¡Bien!");
                }
                else
                {
                    MessageBox.Show($"Ups, la respuesta correcta era {respuestaCorrecta}.", "¡A practicar!");
                }

                // TRUCO VISUAL: Si tienes un Label en tu diseño para ver los puntos en vivo,
                // descomenta (quítale las //) a la línea de abajo y ponle el nombre de tu Label:
                // lblPuntajeEnVivo.Text = $"Puntaje: {puntajeFinalQuiz}";

                SiguientePreguntaQuiz();
            }
            else
            {
                MessageBox.Show("Por favor, escribe solo números en el cuadro blanco.", "Atención");
                txtRespuestaQuiz.Clear();
                txtRespuestaQuiz.Focus();
            }
        }

        private void FinalizarQuiz()
        {
            // Mostramos el puntaje final total acumulado en el Quiz
            MessageBox.Show($"¡Felicidades! Terminaste tu examen.\nLograste un total de: {puntajeFinalQuiz} puntos.", "Fin del Nivel");

            // AQUÍ CONECTARÁS TU LÓGICA PARA GUARDAR EN LA BASE DE DATOS MYSQL
            // ej: logicaBD.ActualizarPuntos(usuarioActual, puntajeFinalQuiz);

            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}