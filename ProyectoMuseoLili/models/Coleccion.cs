using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class Coleccion
    {
        private string UUIDColeccion;
        private string nombreColeccion;
        private DateTime fechaCreacion;
        private string descripcionColeccion;

        public Coleccion() { }

        public Coleccion(string nombreColeccion, DateTime fechaCreacion, string descripcionColeccion)
        {
            this.nombreColeccion = nombreColeccion;
            this.fechaCreacion = fechaCreacion;
            this.descripcionColeccion = descripcionColeccion;
        }

        public Coleccion(string UUIDColeccion, string nombreColeccion, DateTime fechaCreacion, string descripcionColeccion)
        {
            this.UUIDColeccion = UUIDColeccion;
            this.nombreColeccion = nombreColeccion;
            this.fechaCreacion = fechaCreacion;
            this.descripcionColeccion = descripcionColeccion;
        }

        public string UUIDColeccion1 { get => UUIDColeccion; set => UUIDColeccion = value; }
        public string NombreColeccion { get => nombreColeccion; set => nombreColeccion = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string DescripcionColeccion { get => descripcionColeccion; set => descripcionColeccion = value; }
    }
}
