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
            string sql = $"INSERT INTO piezas VALUES ('{objP.UUIDPieza}','{objP.NombrePieza}','{objP.DescripcionPieza}','{objP.FechaIngresoPieza}','{objP.FechaAproxCP}',{objP.AltoP},{objP.AnchoP},{objP.ProfundidadP},'{objP.UbicacionP}','{objP.EstadoConservacion}','{objP.UUIDUsuario_UP}','{objP.UUIDColeccion_CP}',{objP.IdCategoria_CP});";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Pieza BuscarPieza(string UUIDPieza)
        {
            string sql = $"SELECT * FROM piezas WHERE uuidPieza='{UUIDPieza}';";
            Pieza objP = new Pieza();
            return objP.BuscarPieza(sql);
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
