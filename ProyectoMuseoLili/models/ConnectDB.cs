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
