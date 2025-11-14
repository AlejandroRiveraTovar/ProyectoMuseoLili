using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class Rol
    {
        private int idRol;
        private string nombreRol;
        private string descripcionRol;

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

        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }
        public string DescripcionRol { get => descripcionRol; set => descripcionRol = value; }
    }
}
