using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerRol
    {
        internal bool InsertNewRol(Rol objR)
        {
            string sql = $"INSERT INTO roles VALUES ({objR.IdRol},'{objR.NombreRol}','{objR.DescripcionRol}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Rol BuscarRol(int idRol)
        {
            string sql = $"SELECT * FROM roles WHERE idRol={idRol};";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarRol(sql);
        }
    }
}
