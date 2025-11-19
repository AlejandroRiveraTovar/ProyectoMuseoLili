using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoMuseoLili.models
{
    internal class Categoria
    {
        private int idCategoria;
        private string nombreCategoria;
        private string descripcionCategoria;

        public Categoria() { }

        public Categoria(int idCategoria, string nombreCategoria, string descripcionCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;
        }

        public Categoria(string nombreCategoria)
        {
            this.nombreCategoria = nombreCategoria;
        }


        // =================== Buscar Categoria ===================
        public Categoria BuscarCategoria(string sql)
        {
            ConnectDB objConnection = new ConnectDB();
            Categoria categoria = null;
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoria = new Categoria
                    {
                        IdCategoria = Convert.ToInt32(reader["idCategoria"]),
                        NombreCategoria = reader["nombreCategoria"].ToString(),
                        DescripcionCategoria = reader["descripcionCategoria"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarCategoria: " + ex.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return categoria;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }
    }
}
