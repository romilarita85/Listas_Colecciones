using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPersonas06_11
{
    internal class Disco
    {

        string titulo;
        double duracion;
        string genero;


        public Disco(string titulo, double duracion, string genero)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.genero = genero;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public string Genero { get => genero; set => genero = value; }
    }

}
}
