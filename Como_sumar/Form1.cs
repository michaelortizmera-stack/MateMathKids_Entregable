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


namespace Como_sumar
{
    public partial class FormAprender : Form
    {
        
        public FormAprender()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void  btn_contar_Click(object sender, EventArgs e)
        {
            int numero1 = 3;
            int numero2 = 2;

            int contador = 0;

            for (int i = 1; i <= numero1; i++)
            {
                contador++;
                text_resultado.Text = "Contando: " + contador;
                await Task.Delay(500);
            }

            for (int i = 1; i <= numero2; i++)
            {
                contador++;
                text_resultado.Text = "Contando: " + contador;
                await Task.Delay(500);
            }

            text_resultado.Text = "Resultado: " + contador;
        }

        private void btn_ejercicio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);

            Ejercicios.Form1 ejercicio = new Ejercicios.Form1(a, b);
            ejercicio.Show();
            this.Hide();
        }
    }
}
    

