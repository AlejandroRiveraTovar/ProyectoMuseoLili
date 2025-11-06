using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class MaterialPieza
    {
        private int idMP;
        private string UUIDPieza_PMP;
        private int UUIDMaterial_MMP;

        public MaterialPieza() { }

        public MaterialPieza(int idMP)
        {
            this.idMP = idMP;
        }

        public int IdMP { get => idMP; set => idMP = value; }
        public string UUIDPieza_PMP1 { get => UUIDPieza_PMP; set => UUIDPieza_PMP = value; }
        public int UUIDMaterial_MMP1 { get => UUIDMaterial_MMP; set => UUIDMaterial_MMP = value; }
    }
}
