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
            string sql = $"INSERT INTO usuarios VALUES ('{objU.UUIDUsuario1}','{objU.CedulaUsuario}','{objU.Nombre1Usuario}','{objU.Nombre2Usuario}','{objU.Apellido1Usuario}','{objU.Apellido2Usuario}','{objU.EmailUsuario}','{objU.TelefonoUsuario}','{objU.PasswordUsuario}',{objU.IdRol_RU});";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal bool ActualizarContrasena(Usuario objU)
        {
            string sql = $"UPDATE usuarios SET passwordUsuario = '{objU.PasswordUsuario}' WHERE emailUsuario = '{objU.EmailUsuario}';";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }


        internal Usuario BuscarUsuarioPorCedula(string cedula)
        {
            string sql = $"SELECT * FROM usuarios WHERE cedulaUsuario='{cedula}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarUsuario(sql);
        }

        internal Usuario LoginUsuario(string correo, string contrasena)
        {
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}' AND passwordUsuario='{contrasena}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarUsuario(sql);
        }

        internal Usuario BuscarUsuarioPorCorreo(string correo)
        {
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarUsuario(sql);
        }
    }
}
