using System;
using System.Collections.Generic;
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
        private float AltoP;
        private float AnchoP;
        private float ProfundidadP;
        private string ubicacionP;
        private string estadoConservacion;
        private string UUIDUsuario_UP;
        private string UUIDColeccion_CP;
        private int idCategoria_CP;

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
                     float AltoP, float AnchoP, float ProfundidadP, string ubicacionP, string estadoConservacion)
        {
            this.UUIDPieza = UUIDPieza;
            this.nombrePieza = nombrePieza;
            this.descripcionPieza = descripcionPieza;
            this.fechaIngreso = fechaIngreso;
            this.AltoP = AltoP;
            this.AnchoP = AnchoP;
            this.ProfundidadP = ProfundidadP;
            this.ubicacionP = ubicacionP;
            this.estadoConservacion = estadoConservacion;
        }

        public string UUIDPieza { get => UUIDPieza; set => UUIDPieza = value; }
        public string NombrePieza { get => nombrePieza; set => nombrePieza = value; }
        public string DescripcionPieza { get => descripcionPieza; set => descripcionPieza = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaAproxC { get => fechaAproxC; set => fechaAproxC = value; }
        public float AltoP { get => AltoP; set => AltoP = value; }
        public float AnchoP { get => AnchoP; set => AnchoP = value; }
        public float ProfundidadP { get => ProfundidadP; set => ProfundidadP = value; }
        public string UbicacionP { get => ubicacionP; set => ubicacionP = value; }
        public string EstadoConservacion { get => estadoConservacion; set => estadoConservacion = value; }
        public string UUIDUsuario_UP { get => UUIDUsuario_UP; set => UUIDUsuario_UP = value; }
        public string UUIDColeccion_CP { get => UUIDColeccion_CP; set => UUIDColeccion_CP = value; }
        public int IdCategoria_CP { get => idCategoria_CP; set => idCategoria_CP = value; }
    }
}
