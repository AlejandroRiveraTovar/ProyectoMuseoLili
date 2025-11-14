using ProyectoMuseoLili.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerPieza
    {
        internal bool InsertNewPieza(Pieza objP)
        {
            string sql = $"INSERT INTO piezas VALUES ('{objP.UUIDPieza1}','{objP.NombrePieza}','{objP.DescripcionPieza}','{objP.FechaIngreso}','{objP.FechaAproxC}',{objP.AltoP},{objP.AnchoP},{objP.ProfundidadP},'{objP.UbicacionP}','{objP.EstadoConservacion}','{objP.UUIDUsuario_UP1}','{objP.UUIDColeccion_CP1}',{objP.IdCategoria_CP});";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Pieza BuscarPieza(string UUIDPieza)
        {
            string sql = $"SELECT * FROM piezas WHERE uuidPieza='{UUIDPieza}';";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarPieza(sql);
        }

        internal List<Pieza> BuscarPiezasPorCategoria(int idCategoria)
        {
            string sql = $"SELECT * FROM pieza WHERE idCategoria_CP = {idCategoria}";
            ConnectDB objCDB = new ConnectDB();
            List<Pieza> lista = objCDB.BuscarListaPiezas(sql);
            return lista;
        }

        internal List<Pieza> BuscarPiezasPorFecha(DateTime inicio, DateTime fin)
        {
            string sql = $"SELECT * FROM pieza WHERE fechaIngresoPieza BETWEEN '{inicio:yyyy-MM-dd}' AND '{fin:yyyy-MM-dd}'";
            ConnectDB objCDB = new ConnectDB();
            List<Pieza> lista = objCDB.BuscarListaPiezas(sql);
            return lista;
        }

        internal List<Pieza> BuscarPiezasPorEstado(string estado)
        {
            string sql = $"SELECT * FROM pieza WHERE estadoConservacion = '{estado}'";
            ConnectDB objCDB = new ConnectDB();
            List<Pieza> lista = objCDB.BuscarListaPiezas(sql);
            return lista;
        }
    }
}
