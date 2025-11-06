using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string UUIDPrestamoExterno1 { get => UUIDPrestamoExterno; set => UUIDPrestamoExterno = value; }
        public string Institucion { get => institucion; set => institucion = value; }
        public string DireccionI { get => direccionI; set => direccionI = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public string DescripcionPrestamoExterno { get => descripcionPrestamoExterno; set => descripcionPrestamoExterno = value; }
    }
}
