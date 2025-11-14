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
            string nombre2 = string.IsNullOrWhiteSpace(objU.Nombre2Usuario) ? "NULL" : $"'{objU.Nombre2Usuario}'";
            string apellido2 = string.IsNullOrWhiteSpace(objU.Apellido2Usuario) ? "NULL" : $"'{objU.Apellido2Usuario}'";

            string sql = $"INSERT INTO usuarios VALUES (" +
                $"'{objU.UUIDUsuario1}'," +
                $"'{objU.CedulaUsuario}'," +
                $"'{objU.Nombre1Usuario}'," +
                $"{nombre2}," +                 
                $"'{objU.Apellido1Usuario}'," +
                $"{apellido2}," +               
                $"'{objU.EmailUsuario}'," +
                $"'{objU.TelefonoUsuario}'," +
                $"'{objU.PasswordUsuario}'," +
                $"{objU.IdRol_RU}" +
            $");";

            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

<<<<<<< Updated upstream

        internal bool ActualizarContrasena(Usuario objU)
        {
            string sql = $"UPDATE usuarios SET passwordUsuario = '{objU.PasswordUsuario}' WHERE emailUsuario = '{objU.EmailUsuario}';";
=======
<<<<<<< Updated upstream
=======

        internal bool ActualizarContrasena(string correo, string contra)
        {
            string sql = $"UPDATE usuarios SET passwordUsuario = '{contra}' WHERE emailUsuario = '{correo}';";
>>>>>>> Stashed changes
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }


<<<<<<< Updated upstream
=======
>>>>>>> Stashed changes
>>>>>>> Stashed changes
        internal Usuario BuscarUsuarioPorCedula(string cedula)
        {
            string sql = $"SELECT * FROM usuarios WHERE cedulaUsuario='{cedula}';";
            Usuario objUsuario = new Usuario();
            return objUsuario.BuscarUsuario(sql);
        }
<<<<<<< Updated upstream

        internal Usuario LoginUsuario(string correo, string contrasena)
        {
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}' AND passwordUsuario='{contrasena}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarUsuario(sql);
=======
<<<<<<< Updated upstream
=======

        internal Usuario LoginUsuario(string correo, string contrasena)
        {
            
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}' AND passwordUsuario='{contrasena}';";
            Usuario objUsuario = new Usuario();
            return objUsuario.BuscarUsuario(sql);
         
            
>>>>>>> Stashed changes
        }

        internal Usuario BuscarUsuarioPorCorreo(string correo)
        {
<<<<<<< Updated upstream
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarUsuario(sql);
        }
=======
            BindingSource bs = new BindingSource();
            string sql = $"SELECT * FROM usuarios WHERE emailUsuario='{correo}';";
            Usuario ObjUsuario = new Usuario();
            return ObjUsuario.BuscarUsuario(sql);
            

        }
>>>>>>> Stashed changes
>>>>>>> Stashed changes
    }
}
