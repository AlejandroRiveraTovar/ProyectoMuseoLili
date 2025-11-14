using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class FotoPieza
    {
        private string UUIDFotoP;
        private string nombreFotoP;
        private string archivoFotoP;
        private string UUIDPieza_PFP;

        public FotoPieza() { }

        public FotoPieza(string nombreFotoP, string archivoFotoP)
        {
            this.nombreFotoP = nombreFotoP;
            this.archivoFotoP = archivoFotoP;
        }

        public FotoPieza(string UUIDFotoP, string nombreFotoP, string archivoFotoP)
        {
            this.UUIDFotoP = UUIDFotoP;
            this.nombreFotoP = nombreFotoP;
            this.archivoFotoP = archivoFotoP;
        }

        public string UUIDFotoP1 { get => UUIDFotoP; set => UUIDFotoP = value; }
        public string NombreFotoP { get => nombreFotoP; set => nombreFotoP = value; }
        public string ArchivoFotoP { get => archivoFotoP; set => archivoFotoP = value; }
        public string UUIDPieza_PFP1 { get => UUIDPieza_PFP; set => UUIDPieza_PFP = value; }
    }
}
