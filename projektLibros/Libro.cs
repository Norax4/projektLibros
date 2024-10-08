using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektLibros
{
    internal class Libro
    {
        private static int countID = 1;

        public int ID { get; private set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }

        public Libro() { }

        public Libro(string titulo, string autor, int anioPublicacion)
        {
            ID = countID++;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Autor: {Autor}, Año de Publicación: {AnioPublicacion}. (ID: {ID})";
        }
    }
}
