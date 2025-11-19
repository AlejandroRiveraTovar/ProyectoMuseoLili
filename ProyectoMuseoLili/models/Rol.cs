using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoMuseoLili.models
{
    internal class Rol
    {
        private int idRol;
        private string nombreRol;
        private string descripcionRol;

        ConnectDB objConnection = new ConnectDB();

        public Rol()
        {
        }

        public Rol(int idRol, string nombreRol, string descripcionRol)
        {
            this.idRol = idRol;
            this.nombreRol = nombreRol;
            this.descripcionRol = descripcionRol;
        }

        public Rol(string nombreRol)
        {
            this.nombreRol = nombreRol;
        }

        // =================== Buscar Rol ===================
        public Rol BuscarRol(string sql)
        {
            Rol rol = null;
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    rol = new Rol
                    {
                        IdRol = Convert.ToInt32(reader["idRol"]),
                        NombreRol = reader["nombreRol"].ToString(),
                        DescripcionRol = reader["descripcionRol"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarRol: " + ex.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return rol;
        }

        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public string DescripcionRol { get => descripcionRol; set => descripcionRol = value; }
    }
}
