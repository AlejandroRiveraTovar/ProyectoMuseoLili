using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class PiezaExhibicion
    {
        private int idPieza_Exhibicion;
        private string UUIDPieza_PPE;
        private string UUIDExhibicion_EPE;

        public PiezaExhibicion() { }

        public PiezaExhibicion(int idPieza_Exhibicion)
        {
            this.idPieza_Exhibicion = idPieza_Exhibicion;
        }

        public int IdPiezaExhibicion { get => idPiezaExhibicion; set => idPiezaExhibicion = value; }
        public string UUIDPieza_PPE { get => UUIDPieza_PPE; set => UUIDPieza_PPE = value; }
        public string UUIDExhibicion_EPE { get => UUIDExhibicion_EPE; set => UUIDExhibicion_EPE = value; }
    }
}
