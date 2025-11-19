using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerPrestamoExterno
    {
        internal bool InsertNewPrestamo(PrestamoExterno objPE)
        {
            string sql = $"INSERT INTO prestamosExternos VALUES ('{objPE.UUIDPrestamoExterno1}','{objPE.Institucion}',,'{objPE.DireccionI}','{objPE.FechaPrestamo}','{objPE.FechaDevolucion}','{objPE.DescripcionPrestamoExterno}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal PrestamoExterno BuscarPrestamo(string UUIDPrestamo)
        {
            string sql = $"SELECT * FROM prestamosExternos WHERE UUIDPrestamoExterno='{UUIDPrestamo}';";
            PrestamoExterno objPE = new PrestamoExterno();
            return objPE.BuscarPrestamo(sql);
        }
    }
}
