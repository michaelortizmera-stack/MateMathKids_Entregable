using Como_sumar;
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


namespace Interfaz_Niveles
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuResta_Click(object sender, EventArgs e)
        {
            // 1. Creamos la pantalla del nivel de resta
            FrmNivelResta pantallaResta = new FrmNivelResta();

            // 2. Mostramos la pantalla al niño
            pantallaResta.Show();

            // 3. Ocultamos este menú principal para que no estorbe atrás
            this.Hide();
        }

        private void btnMenuSuma_Click(object sender, EventArgs e)
        {
             Como_sumar.FormAprender ventanaAprender = new Como_sumar.FormAprender();
            ventanaAprender.Show();
        }

        private void btnMenuDivision_Click(object sender, EventArgs e)
        {
            // 1. Creamos en memoria la ventana del Nivel de División
            FrmNivelDivision ventanaDivision = new FrmNivelDivision();

            // 2. La mostramos en la pantalla
            ventanaDivision.Show();

            // 3. Ocultamos el menú principal para que el niño juegue sin distracciones
            this.Hide();
        }

        private void btnMenuMultiplicacion_Click(object sender, EventArgs e)
        {
            // 1. Creamos una instancia de tu nuevo formulario de multiplicación
            FrmNivelMultiplicacion nivelMultiplicacion = new FrmNivelMultiplicacion();

            // 2. Lo mostramos en pantalla
            nivelMultiplicacion.Show();

            // 3. Ocultamos el menú principal para que la pantalla quede limpia
            this.Hide();
        }
    }
}
