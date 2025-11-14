using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoMuseoLili.models
{
    internal class PrestamoExterno
    {
        private string UUIDPrestamoExterno;
        private string institucion;
        private string direccionI;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private string descripcionPrestamoExterno;

        ConnectDB objConnection = new ConnectDB();
        public PrestamoExterno() { }

        public PrestamoExterno(string institucion, string direccionI, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            this.institucion = institucion;
            this.direccionI = direccionI;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
        }

        public PrestamoExterno(string UUIDPrestamoExterno, string institucion, string direccionI,
                               DateTime fechaPrestamo, DateTime fechaDevolucion, string descripcionPrestamoExterno)
        {
            this.UUIDPrestamoExterno = UUIDPrestamoExterno;
            this.institucion = institucion;
            this.direccionI = direccionI;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.descripcionPrestamoExterno = descripcionPrestamoExterno;
        }

<<<<<<< Updated upstream
        public string UUIDPrestamoExterno { get => UUIDPrestamoExterno; set => UUIDPrestamoExterno = value; }
=======


        // =================== Buscar Prestamo ===================
        public PrestamoExterno BuscarPrestamo(string sql)
        {
            PrestamoExterno prestamo = null;
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    prestamo = new PrestamoExterno
                    {
                        UUIDPrestamoExterno1 = reader["UUIDPrestamo_Externo"].ToString(),
                        Institucion = reader["institucion"].ToString(),
                        DireccionI = reader["direccionI"].ToString(),
                        FechaPrestamo = Convert.ToDateTime(reader["fechaPrestamo"]),
                        FechaDevolucion = Convert.ToDateTime(reader["fechaDevolucion"]),
                        DescripcionPrestamoExterno = reader["descripcionPrestamoExterno"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarPrestamo: " + ex.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return prestamo;
        }

        public string UUIDPrestamoExterno1 { get => UUIDPrestamoExterno; set => UUIDPrestamoExterno = value; }
>>>>>>> Stashed changes
        public string Institucion { get => institucion; set => institucion = value; }
        public string DireccionI { get => direccionI; set => direccionI = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public string DescripcionPrestamoExterno { get => descripcionPrestamoExterno; set => descripcionPrestamoExterno = value; }
    }
}
