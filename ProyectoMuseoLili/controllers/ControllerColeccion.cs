using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerColeccion
    {
        internal bool InsertNewColeccion(Coleccion objCol)
        {
            string sql = $"INSERT INTO colecciones VALUES ('{objCol.UUIDColeccion}','{objCol.NombreColeccion}','{objCol.DescripcionColeccion}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Coleccion BuscarColeccion(string UUIDColeccion)
        {
            string sql = $"SELECT * FROM colecciones WHERE UUIDColeccion='{UUIDColeccion}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarColeccion(sql);
        }
    }
}
