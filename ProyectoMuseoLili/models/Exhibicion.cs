using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string UUIDExhibicion1 { get => UUIDExhibicion; set => UUIDExhibicion = value; }
        public string NombreExhibicion { get => nombreExhibicion; set => nombreExhibicion = value; }
        public string DescripcionExhibicion { get => descripcionExhibicion; set => descripcionExhibicion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
