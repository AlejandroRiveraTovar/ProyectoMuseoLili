using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class Material
    {
        private string UUIDMaterial;
        private string nombreMaterial;

        public Material() { }

        public Material(string nombreMaterial)
        {
            this.nombreMaterial = nombreMaterial;
        }

        public Material(string UUIDMaterial, string nombreMaterial)
        {
            this.UUIDMaterial = UUIDMaterial;
            this.nombreMaterial = nombreMaterial;
        }

        public string UUIDMaterial1 { get => UUIDMaterial; set => UUIDMaterial = value; }
        public string NombreMaterial { get => nombreMaterial; set => nombreMaterial = value; }
    }
}
