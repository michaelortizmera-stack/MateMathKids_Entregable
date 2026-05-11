using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Logica;
using Interfaz_Niveles;

namespace Interfaz_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario nuevoUser = new Usuario();

            nuevoUser.Nombre = txtNombreRegistro.Text;
            nuevoUser.Correo = txtCorreoRegistro.Text;
            nuevoUser.password = txtPasswordRegistro.Text;

            ValidacionUsuarios validador = new ValidacionUsuarios();
            string mensaje = validador.ValidarYRegistrar(nuevoUser);

            // 3. Mostramos la respuesta
            MessageBox.Show(mensaje);
        }

        private void btnEntrarAJugar_Click(object sender, EventArgs e)
        {

            // 1. Recogemos lo que escribieron en las cajitas del Login
            // (Asegúrate de que estos nombres coincidan con los de tus TextBox en Propiedades)
            string correo = txtCorreoLogin.Text;
            string password = txtPasswordLogin.Text;

            // 2. Llamamos a la Capa Lógica (nuestro cerebro) para que pregunte si existe
            ValidacionUsuarios validador = new ValidacionUsuarios();
            bool puedeEntrar = validador.ValidarLogin(correo, password);

            // 3. Tomamos una decisión basada en la respuesta del cerebro
            if (puedeEntrar == true)
            {
                // ¡Las credenciales son correctas!

                // Creamos la nueva pantalla del Menú (Cambia "FrmMenuPrincipal" por el nombre real de tu formulario de los 4 niveles)
                FrmMenuPrincipal menu = new FrmMenuPrincipal();

                // Mostramos el menú hermoso
                menu.Show();

                // Ocultamos la ventana actual (el Login) para que no estorbe
                this.Hide();
            }
            else
            {
                // El correo o contraseña no coinciden
                MessageBox.Show("Ups... Correo o contraseña incorrectos. ¡Intenta de nuevo!");
            }
        }
    }
}
    

