using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class Pieza
    {
        private string UUIDPieza;
        private string nombrePieza;
        private string descripcionPieza;
        private DateTime fechaIngreso;
        private DateTime fechaAproxC;
        private float altoP;
        private float anchoP;
        private float profundidadP;
        private string ubicacionP;
        private string estadoConservacion;
        private string UUIDUsuario_UP;
        private string UUIDColeccion_CP;
        private int idCategoria_CP;

        ConnectDB objConnection = new ConnectDB();

        public Pieza()
        {
        }

        public Pieza(string nombrePieza, string descripcionPieza, DateTime fechaIngreso)
        {
            this.nombrePieza = nombrePieza;
            this.descripcionPieza = descripcionPieza;
            this.fechaIngreso = fechaIngreso;
        }

        public Pieza(string UUIDPieza, string nombrePieza, string descripcionPieza, DateTime fechaIngreso,
                     float altoP, float anchoP, float profundidadP, string ubicacionP, string estadoConservacion)
        {
            this.UUIDPieza = UUIDPieza;
            this.nombrePieza = nombrePieza;
            this.descripcionPieza = descripcionPieza;
            this.fechaIngreso = fechaIngreso;
            this.altoP = AltoP;
            this.anchoP = AnchoP;
            this.profundidadP = ProfundidadP;
            this.ubicacionP = ubicacionP;
            this.estadoConservacion = estadoConservacion;
        }

        // =================== Buscar Pieza ===================
        public Pieza BuscarPieza(string sql)
        {
            Pieza pieza = null;
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    pieza = new Pieza
                    {
                        UUIDPieza1 = reader["UUIDPieza"].ToString(),
                        NombrePieza = reader["nombrePieza"].ToString(),
                        DescripcionPieza = reader["descripcionPieza"].ToString(),
                        FechaIngreso = Convert.ToDateTime(reader["fechaIngresoPieza"]),
                        FechaAproxC = Convert.ToDateTime(reader["fechaAproxCP"]),
                        AltoP = float.Parse(reader["AltoP"].ToString()),
                        AnchoP = float.Parse(reader["AnchoP"].ToString()),
                        ProfundidadP = float.Parse(reader["ProfundidadP"].ToString()),
                        UbicacionP = reader["ubicacionP"].ToString(),
                        EstadoConservacion = reader["estadoConservacion"].ToString(),
                        UUIDUsuario_UP1 = reader["UUIDUsuario_UP"].ToString(),
                        UUIDColeccion_CP1 = reader["UUIDColeccion_CP"].ToString(),
                        IdCategoria_CP = Convert.ToInt32(reader["idCategoria_CP"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarPieza: " + ex.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return pieza;
        }

        public BindingSource BuscarListaPiezas(string sql)
        {
            BindingSource listaP = new BindingSource();
            try
            {
                

                MySqlCommand cmd = new MySqlCommand(sql, objConnection.DataSource());
                objConnection.ConnectOpened();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listaP.DataSource = dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR BuscarListaPiezas: " + e.Message);
            }
            finally
            {
                objConnection.ConnectClosed();
            }
            return listaP;

        }

        public string UUIDPieza1 { get => UUIDPieza; set => UUIDPieza = value; }
        public string NombrePieza { get => nombrePieza; set => nombrePieza = value; }
        public string DescripcionPieza { get => descripcionPieza; set => descripcionPieza = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaAproxC { get => fechaAproxC; set => fechaAproxC = value; }
        public float AltoP { get => altoP; set => altoP = value; }
        public float AnchoP { get => anchoP; set => anchoP = value; }
        public float ProfundidadP { get => profundidadP; set => profundidadP = value; }
        public string UbicacionP { get => ubicacionP; set => ubicacionP = value; }
        public string EstadoConservacion { get => estadoConservacion; set => estadoConservacion = value; }
        public string UUIDUsuario_UP1 { get => UUIDUsuario_UP; set => UUIDUsuario_UP = value; }
        public string UUIDColeccion_CP1 { get => UUIDColeccion_CP; set => UUIDColeccion_CP = value; }
        public int IdCategoria_CP { get => idCategoria_CP; set => idCategoria_CP = value; }
    }
}
