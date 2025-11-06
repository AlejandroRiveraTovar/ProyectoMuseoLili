using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class Usuario
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

        public Usuario()
        {
        }

        public Usuario(string cedulaUsuario, string nombre1Usuario, string apellido1Usuario, string emailUsuario)
        {
            this.cedulaUsuario = cedulaUsuario;
            this.nombre1Usuario = nombre1Usuario;
            this.apellido1Usuario = apellido1Usuario;
            this.emailUsuario = emailUsuario;
        }

        public Usuario(string UUIDUsuario, string cedulaUsuario, string nombre1Usuario, string apellido1Usuario,
                       string emailUsuario, string telefonoUsuario, string passwordUsuario)
        {
            this.UUIDUsuario = UUIDUsuario;
            this.cedulaUsuario = cedulaUsuario;
            this.nombre1Usuario = nombre1Usuario;
            this.apellido1Usuario = apellido1Usuario;
            this.emailUsuario = emailUsuario;
            this.telefonoUsuario = telefonoUsuario;
            this.passwordUsuario = passwordUsuario;
        }

        public Usuario(string emailUsuario, string passwordUsuario)
        {
            this.emailUsuario = emailUsuario;
            this.passwordUsuario = passwordUsuario;
        }

        public Usuario(string emailUsuario)
        {
            this.emailUsuario = emailUsuario;
        }

        public string UUIDUsuario1 { get => UUIDUsuario; set => UUIDUsuario = value; }
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
