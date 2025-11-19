using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoMuseoLili.models
{
    internal class Exhibicion
    {
        private string UUIDExhibicion;
        private string nombreExhibicion;
        private string descripcionExhibicion;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public Exhibicion() { }

        public Exhibicion(string nombreExhibicion, DateTime fechaInicio, DateTime fechaFin)
        {
            this.nombreExhibicion = nombreExhibicion;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public Exhibicion(string UUIDExhibicion, string nombreExhibicion, string descripcionExhibicion,
                          DateTime fechaInicio, DateTime fechaFin)
        {
            this.UUIDExhibicion = UUIDExhibicion;
            this.nombreExhibicion = nombreExhibicion;
            this.descripcionExhibicion = descripcionExhibicion;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        // =================== Buscar Exhibicion ===================
        public Exhibicion BuscarExhibicion(string sql)
        {   
            ConnectDB objConnection = new ConnectDB();
            Exhibicion exhibicion = null;
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    exhibicion = new Exhibicion
                    {
                        UUIDExhibicion1 = reader["UUIDExhibicion"].ToString(),
                        NombreExhibicion = reader["nombreExhibicion"].ToString(),
                        DescripcionExhibicion = reader["descripcionExhibicion"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["fechaInicio"]),
                        FechaFin = Convert.ToDateTime(reader["fechaFin"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarExhibicion: " + ex.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return exhibicion;
        }

        public string UUIDExhibicion1 { get => UUIDExhibicion; set => UUIDExhibicion = value; }
        public string NombreExhibicion { get => nombreExhibicion; set => nombreExhibicion = value; }
        public string DescripcionExhibicion { get => descripcionExhibicion; set => descripcionExhibicion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
