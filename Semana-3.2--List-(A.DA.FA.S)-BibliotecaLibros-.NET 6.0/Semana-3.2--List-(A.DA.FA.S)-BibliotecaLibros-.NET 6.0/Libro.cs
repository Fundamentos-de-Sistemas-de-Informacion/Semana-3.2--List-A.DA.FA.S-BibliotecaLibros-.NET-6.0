using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3._2__List__A.DA.FA.S__BibliotecaLibros_.NET_6._0
{
    internal class Libro
    {
        public Libro() { }

        public String Codigo { get; set; }

        public String Autor { get; set; }

        public String Titulo { get; set; }

        public String Genero { get; set; }

        public int Stock { get; set; }

        public String FechaPublicacion { get; set; }
    }
}
