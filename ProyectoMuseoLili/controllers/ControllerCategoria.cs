using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.controllers
{
    public class ControllerCategoria
    {
        internal bool InsertNewCategoria(Categoria objC)
        {
            string sql = $"INSERT INTO categorias VALUES ({objC.IdCategoria},'{objC.NombreCategoria}');";
            ConnectDB objConexion = new ConnectDB();
            return objConexion.ExecuteQuery(sql);
        }

        internal Categoria BuscarCategoria(int idCategoria)
        {
            string sql = $"SELECT * FROM categorias WHERE idCategoria={idCategoria};";
            ConnectDB objCDB = new ConnectDB();
            return objCDB.BuscarCategoria(sql);
        }
    }
}
