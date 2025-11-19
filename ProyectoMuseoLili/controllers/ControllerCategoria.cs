using ProyectoMuseoLili.models;
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
            Categoria objC = new Categoria();
            return objC.BuscarCategoria(sql);
        }

        internal List<Categoria> BuscarTodasCategorias()
        {
            string sql = "SELECT * FROM categorias;";
            List<Categoria> listaCategorias = new List<Categoria>();
            Categoria objC = new Categoria();
            listaCategorias = objC.BuscarCategoria(sql);
            return 
        }
    }
}
