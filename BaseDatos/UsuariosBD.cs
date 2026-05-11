using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace BaseDatos
{
    public class UsuariosBD
    {
        private static List<Usuario> listaUsuarios = new List<Usuario>();
        public void GuardarNuevo(Usuario nuevoUsuario)
        {
            listaUsuarios.Add(nuevoUsuario);
        }
        public bool BuscarParaLogin(string correo, string password)
        {
           foreach (Usuario u in listaUsuarios)
            {
                if (u.Correo == correo && u.password == password)
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
