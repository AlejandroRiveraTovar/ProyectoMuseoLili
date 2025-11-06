using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class DetallePE
    {
        private int idDP;
        private string UUIDPieza_PDP;
        private string UUIDPrestamo_Externo_PEDP;

        public DetallePE() { }

        public DetallePE(int idDP)
        {
            this.idDP = idDP;
        }

        public int IdDP { get => idDP; set => idDP = value; }
        public string UUIDPieza_PDP1 { get => UUIDPieza_PDP; set => UUIDPieza_PDP = value; }
        public string UUIDPrestamo_Externo_PEDP1 { get => UUIDPrestamo_Externo_PEDP; set => UUIDPrestamo_Externo_PEDP = value; }
    }
}
