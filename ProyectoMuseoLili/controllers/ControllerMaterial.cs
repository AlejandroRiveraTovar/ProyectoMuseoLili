using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerMaterial
    {
        internal bool InsertNewMaterial(Material objM)
        {
            string sql = $"INSERT INTO materiales VALUES ({objM.UUIDMaterial},'{objM.NombreMaterial}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Material BuscarMaterial(int UUIDMaterial)
        {
            string sql = $"SELECT * FROM materiales WHERE UUIDMaterial={UUIDMaterial};";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarMaterial(sql);
        }
    }
}