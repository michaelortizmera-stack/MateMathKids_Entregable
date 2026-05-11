using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using BaseDatos;

namespace Logica
{
    public class ValidacionUsuarios
    {
        UsuariosBD baseDeDatos = new UsuariosBD();
        public string ValidarYRegistrar(Usuario u)
        {
            if(u.Nombre =="" || u.Correo == "" || u.password == "")
            {
                return "Todos los campos son obligatorios.";
            }
            baseDeDatos.GuardarNuevo(u);
            return "Registro en MateMathKids exitoso.";

        }
        public bool ValidarLogin(string correo, string password)
        {
            if (correo == "" || password == "")
            {
                return false; 
            }
            return baseDeDatos.BuscarParaLogin(correo, password);
        }
    }
}
