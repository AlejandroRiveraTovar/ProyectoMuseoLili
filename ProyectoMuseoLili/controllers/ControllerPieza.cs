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
            Pieza objP = new Pieza();
            return objP.BuscarPieza(sql);
        }

        internal BindingSource BuscarPiezasPorCategoria(int idCategoria)
        {
            string sql = $"SELECT * FROM pieza WHERE idCategoria_CP = {idCategoria}";
            Pieza objP = new Pieza();
            BindingSource lista = objP.BuscarListaPiezas(sql);
            return lista;
        }

        internal BindingSource BuscarPiezasPorFecha(DateTime inicio, DateTime fin)
        {
            string sql = $"SELECT * FROM pieza WHERE fechaIngresoPieza BETWEEN '{inicio:yyyy-MM-dd}' AND '{fin:yyyy-MM-dd}'";
            Pieza objP = new Pieza();
            BindingSource lista = objP.BuscarListaPiezas(sql);
            return lista;
        }

        internal BindingSource BuscarPiezasPorEstado(string estado)
        {
            string sql = $"SELECT * FROM pieza WHERE estadoConservacion = '{estado}'";
            Pieza objP = new Pieza();
            BindingSource lista = objP.BuscarListaPiezas(sql);
            return lista;
        }
    }
}
