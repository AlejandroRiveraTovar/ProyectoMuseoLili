using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerUsuario
    {
        internal bool InsertNewUsuario(Usuario objU)
        {
            string sql = $"INSERT INTO usuarios VALUES ('{objU.UUIDUsuario}','{objU.CedulaUsuario}','{objU.Nombre1Usuario}','{objU.Nombre2Usuario}','{objU.Apellido1Usuario}','{objU.Apellido2Usuario}','{objU.EmailUsuario}','{objU.TelefonoUsuario}','{objU.PasswordUsuario}',{objU.IdRol_RU});";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

<<<<<<< Updated upstream
=======

        internal bool ActualizarContrasena(string correo, string contra)
        {
            string sql = $"UPDATE usuarios SET passwordUsuario = '{contra}' WHERE emailUsuario = '{correo}';";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }


>>>>>>> Stashed changes
        internal Usuario BuscarUsuarioPorCedula(string cedula)
        {
            string sql = $"SELECT * FROM usuarios WHERE cedulaUsuario='{cedula}';";
            Usuario objUsuario = new Usuario();
            return objUsuario.BuscarUsuario(sql);
        }
<<<<<<< Updated upstream
=======

        internal Usuario LoginUsuario(string correo, string contrasena)
        {
            
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}' AND passwordUsuario='{contrasena}';";
            Usuario objUsuario = new Usuario();
            return objUsuario.BuscarUsuario(sql);
         
            
        }

        internal Usuario BuscarUsuarioPorCorreo(string correo)
        {
            BindingSource bs = new BindingSource();
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}';";
            Usuario ObjUsuario = new Usuario();
            return ObjUsuario.BuscarUsuario(sql);
            

        }
>>>>>>> Stashed changes
    }
}
