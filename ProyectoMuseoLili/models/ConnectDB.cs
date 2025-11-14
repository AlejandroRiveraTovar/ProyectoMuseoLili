using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoMuseoLili.models
{
    internal class ConnectDB
    {
        public MySqlConnection connManager = new MySqlConnection();
        string server = "127.0.0.1;";
        //string database = "sakila;";
        string database = "museolili;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database} Uid={user} password={pass}");
            return connManager;
        }

        public void ConnectOpened()
        {
            //DataSource();
            connManager.Open();
        }

        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }

        // Ejecutar INSERT, UPDATE o DELETE → retorna true/false
        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR ExecuteQuery: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }

        // Ejecutar consultas que retornan un solo valor (ej: COUNT, MAX, nombre único, etc.)
        public string ExecuteScalar(string sql)
        {
            string result = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                object obj = cmd.ExecuteScalar();
                if (obj != null) result = obj.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR ExecuteScalar: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }

        // Ejecutar consultas que retornan varias filas y columnas → devuelve en string (para imprimir en consola)
        public string ExecuteReader(string sql)
        {
            string result = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result += reader[i].ToString() + "\t";
                    }
                    result += "\n";
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR ExecuteReader: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }

        // Ejecutar consulta y devolver lista de objetos PIEZA (usado en filtros/reportes)
        public List<Pieza> BuscarListaPiezas(string sql)
        {
            List<Pieza> lista = new List<Pieza>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pieza objP = new Pieza();
                    objP.UUIDPieza1 = reader["UUIDPieza"].ToString();
                    objP.NombrePieza = reader["nombrePieza"].ToString();
                    objP.DescripcionPieza = reader["descripcionPieza"].ToString();
                    objP.FechaIngreso = Convert.ToDateTime(reader["fechaIngresoPieza"]);
                    objP.FechaAproxC = Convert.ToDateTime(reader["fechaAproxCP"]);
                    objP.AltoP = (float)Convert.ToDecimal(reader["AltoP"]);
                    objP.AnchoP = (float)Convert.ToDecimal(reader["AnchoP"]);
                    objP.ProfundidadP = (float)Convert.ToDecimal(reader["ProfundidadP"]);
                    objP.UbicacionP = reader["ubicacionP"].ToString();
                    objP.EstadoConservacion = reader["estadoConservacion"].ToString();

                    lista.Add(objP);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR BuscarListaPiezas: " + e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return lista;
        }

        // =================== Buscar Usuario ===================
        public Usuario BuscarUsuario(string sql)
        {
            Usuario usuario = null;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        UUIDUsuario1 = reader["UUIDUsuario"].ToString(),
                        CedulaUsuario = reader["cedulaUsuario"].ToString(),
                        Nombre1Usuario = reader["nombre1Usuario"].ToString(),
                        Nombre2Usuario = reader["nombre2Usuario"].ToString(),
                        Apellido1Usuario = reader["apellido1Usuario"].ToString(),
                        Apellido2Usuario = reader["apellido2Usuario"].ToString(),
                        EmailUsuario = reader["emailUsuario"].ToString(),
                        TelefonoUsuario = reader["telefonoUsuario"].ToString(),
                        PasswordUsuario = reader["passwordUsuario"].ToString(),
                        IdRol_RU = Convert.ToInt32(reader["idRol_RU"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarUsuario: " + ex.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return usuario;
        }

        // =================== Buscar Rol ===================
        public Rol BuscarRol(string sql)
        {
            Rol rol = null;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
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
                ConnectClosed();
            }
            return rol;
        }

        // =================== Buscar Pieza ===================
        public Pieza BuscarPieza(string sql)
        {
            Pieza pieza = null;
            try
            {
               
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
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
                ConnectClosed();
            }
            return pieza;
        }

        // =================== Buscar Categoria ===================
        public Categoria BuscarCategoria(string sql)
        {
            Categoria categoria = null;
            try
            {
               
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
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
                ConnectClosed();
            }
            return categoria;
        }

        // =================== Buscar Exhibicion ===================
        public Exhibicion BuscarExhibicion(string sql)
        {
            Exhibicion exhibicion = null;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
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
                ConnectClosed();
            }
            return exhibicion;
        }

        // =================== Buscar Prestamo ===================
        public PrestamoExterno BuscarPrestamo(string sql)
        {
            PrestamoExterno prestamo = null;
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
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
                ConnectClosed();
            }
            return prestamo;
        }

        internal Material BuscarMaterial(string sql)
        {
            throw new NotImplementedException();
        }

        internal FotoPieza BuscarFoto(string sql)
        {
            throw new NotImplementedException();
        }

        internal Coleccion BuscarColeccion(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
