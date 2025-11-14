using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMuseoLili.models;

namespace ProyectoMuseoLili.models
{
    class Usuario
    {
        private string UUIDUsuario;
        private string cedulaUsuario;
        private string nombre1Usuario;
        private string nombre2Usuario;
        private string apellido1Usuario;
        private string apellido2Usuario;
        private string emailUsuario;
        private string telefonoUsuario;
        private string passwordUsuario;
        private int idRol_RU;

        ConnectDB objConection = new ConnectDB();


        public Usuario()
        {
        }


        public Usuario(string UUIDUsuario, string cedulaUsuario, string nombre1Usuario, string nombre2Usuario, string apellido1Usuario, string apellido2Usuario, 
            string emailUsuario, string telefonoUsuario, string passwordUsuario, int idRol_RU)
        {
            this.UUIDUsuario = UUIDUsuario;
            this.cedulaUsuario = cedulaUsuario;
            this.nombre1Usuario = nombre1Usuario;
            this.nombre2Usuario = nombre2Usuario;
            this.apellido1Usuario = apellido1Usuario;
            this.apellido2Usuario = apellido2Usuario;
            this.emailUsuario = emailUsuario;
            this.telefonoUsuario = telefonoUsuario;
            this.passwordUsuario = passwordUsuario;
            this.idRol_RU = idRol_RU;
        }

<<<<<<< Updated upstream
        public string UUIDUsuario { get => UUIDUsuario; set => UUIDUsuario = value; }
=======
        // =================== Buscar Usuario ===================
        /*internal BindingSource BuscarUsuario(string sql)
        {
            
            BindingSource bindingSource = new BindingSource();
            try
            {
                
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                bindingSource.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR BuscarUsuario: " + ex.Message);
            }
            finally
            {
                objConection.ConnectClosed();
            }
            return bindingSource;
        }*/

        public Usuario BuscarUsuario(string sql)
        {
            Usuario usuario = null;
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
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
                objConection.ConnectClosed();
            }
            return usuario;
        }

        public string UUIDUsuario1 { get => UUIDUsuario; set => UUIDUsuario = value; }
>>>>>>> Stashed changes
        public string CedulaUsuario { get => cedulaUsuario; set => cedulaUsuario = value; }
        public string Nombre1Usuario { get => nombre1Usuario; set => nombre1Usuario = value; }
        public string Nombre2Usuario { get => nombre2Usuario; set => nombre2Usuario = value; }
        public string Apellido1Usuario { get => apellido1Usuario; set => apellido1Usuario = value; }
        public string Apellido2Usuario { get => apellido2Usuario; set => apellido2Usuario = value; }
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public string TelefonoUsuario { get => telefonoUsuario; set => telefonoUsuario = value; }
        public string PasswordUsuario { get => passwordUsuario; set => passwordUsuario = value; }
        public int IdRol_RU { get => idRol_RU; set => idRol_RU = value; }
    }
}
