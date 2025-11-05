using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMuseoLili.models
{
    internal class Categoria
    {
        private int idCategoria;
        private string nombreCategoria;
        private string descripcionCategoria;

        public Categoria() { }

        public Categoria(int idCategoria, string nombreCategoria, string descripcionCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;
        }

        public Categoria(string nombreCategoria)
        {
            this.nombreCategoria = nombreCategoria;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }
    }
}
