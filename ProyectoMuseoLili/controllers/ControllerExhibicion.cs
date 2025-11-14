using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerExhibicion
    {
        internal bool InsertNewExhibicion(Exhibicion objE)
        {
            string sql = $"INSERT INTO exhibiciones VALUES ('{objE.UUIDExhibicion}','{objE.NombreExhibicion}','{objE.DescripcionExhibicion}','{objE.FechaInicio}','{objE.FechaFin}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Exhibicion BuscarExhibicion(string UUIDExhibicion)
        {
            string sql = $"SELECT * FROM exhibiciones WHERE UUIDExhibicion='{UUIDExhibicion}';";
            Exhibicion objE = new Exhibicion();
            return objE.BuscarExhibicion(sql);
        }
    }
}
