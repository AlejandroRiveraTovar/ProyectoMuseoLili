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

        internal Usuario BuscarUsuarioPorCedula(string cedula)
        {
            string sql = $"SELECT * FROM usuarios WHERE cedulaUsuario='{cedula}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarUsuario(sql);
        }
    }
}
