using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseDatos
{
    public class EjerciciosRestaBD
    {
        // Método que nos devuelve la lista completa de ejercicios
        public List<EjercicioResta> ObtenerEjercicios()

        {
            List<EjercicioResta> lista = new List<EjercicioResta>();

            // --- Pregunta 1 ---
            EjercicioResta ej1 = new EjercicioResta();
            ej1.Pregunta = "¿Cuánto es 8 - 3?";
            ej1.RespuestaCorrecta = 5;
            ej1.OpcionMala1 = 4;
            ej1.OpcionMala2 = 6;
            lista.Add(ej1);

            // --- Pregunta 2 ---
            EjercicioResta ej2 = new EjercicioResta();
            ej2.Pregunta = "¿Cuánto es 10 - 4?";
            ej2.RespuestaCorrecta = 6;
            ej2.OpcionMala1 = 5;
            ej2.OpcionMala2 = 7;
            lista.Add(ej2);

            // --- Pregunta 3 ---
            EjercicioResta ej3 = new EjercicioResta();
            ej3.Pregunta = "¿Cuánto es 5 - 2?";
            ej3.RespuestaCorrecta = 3;
            ej3.OpcionMala1 = 2;
            ej3.OpcionMala2 = 4;
            lista.Add(ej3);

            // --- Pregunta 4 ---
            EjercicioResta ej4 = new EjercicioResta();
            ej4.Pregunta = "¿Cuánto es 7 - 2?";
            ej4.RespuestaCorrecta = 5;
            ej4.OpcionMala1 = 2;
            ej4.OpcionMala2 = 4;
            lista.Add(ej4);

            // --- Pregunta 5 ---
            EjercicioResta ej5 = new EjercicioResta();
            ej5.Pregunta = "¿Cuánto es 11 - 5?";
            ej5.RespuestaCorrecta = 6;
            ej5.OpcionMala1 = 7;
            ej5.OpcionMala2 = 3;
            lista.Add(ej5);

            // --- Pregunta 6 ---
            EjercicioResta ej6 = new EjercicioResta();
            ej6.Pregunta = "¿Cuánto es 12 - 8?";
            ej6.RespuestaCorrecta = 4;
            ej6.OpcionMala1 = 5;
            ej6.OpcionMala2 = 10;
            lista.Add(ej6);

            // --- Pregunta 7 ---
            EjercicioResta ej7 = new EjercicioResta();
            ej7.Pregunta = "¿Cuánto es 5 - 4?";
            ej7.RespuestaCorrecta = 1;
            ej7.OpcionMala1 = 2;
            ej7.OpcionMala2 = 3;
            lista.Add(ej7);

            // --- Pregunta 8 ---
            EjercicioResta ej8 = new EjercicioResta();
            ej8.Pregunta = "¿Cuánto es 1 - 0?";
            ej8.RespuestaCorrecta = 1;
            ej8.OpcionMala1 = 0;
            ej8.OpcionMala2 = 2;
            lista.Add(ej8);

            // --- Pregunta 9 ---
            EjercicioResta ej9 = new EjercicioResta();
            ej9.Pregunta = "¿Cuánto es 29 - 9?";
            ej9.RespuestaCorrecta = 20;
            ej9.OpcionMala1 = 10;
            ej9.OpcionMala2 = 22;
            lista.Add(ej9);


            return lista;
        }
        // Método exclusivo para el Quiz final
        // Método para el mini-quiz final (3 preguntas)
        public List<EjercicioResta> ObtenerPreguntasQuiz()
        {
            List<EjercicioResta> listaQuiz = new List<EjercicioResta>();

            // --- Pregunta Quiz 1 ---
            EjercicioResta q1 = new EjercicioResta();
            q1.Pregunta = "15 - 7 = ?";
            q1.RespuestaCorrecta = 8;
            listaQuiz.Add(q1);

            // --- Pregunta Quiz 2 ---
            EjercicioResta q2 = new EjercicioResta();
            q2.Pregunta = "20 - 9 = ?";
            q2.RespuestaCorrecta = 11;
            listaQuiz.Add(q2);

            // --- Pregunta Quiz 3 ---
            EjercicioResta q3 = new EjercicioResta();
            q3.Pregunta = "18 - 12 = ?";
            q3.RespuestaCorrecta = 6;
            listaQuiz.Add(q3);

            return listaQuiz;
        }
    }
    }
