using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{
    public class Libro
    {1
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; } = true;

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }

    public class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro) => libros.Add(libro);

        public void EliminarLibro(string titulo) => libros.RemoveAll(l => l.Titulo == titulo);

        public void ListarLibrosDisponibles()
        {
            foreach (var libro in libros)
                if (libro.Disponible)
                    Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}");
        }

        public void PrestarLibro(string titulo)
        {
            var libro = libros.Find(l => l.Titulo == titulo);
            if (libro != null && libro.Disponible)
            {
                libro.Disponible = false;
                Console.WriteLine($"El libro '{titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no está disponible.");
            }
        }

        public void DevolverLibro(string titulo)
        {
            var libro = libros.Find(l => l.Titulo == titulo);
            if (libro != null && !libro.Disponible)
            {
                libro.Disponible = true;
                Console.WriteLine($"El libro '{titulo}' ha sido devuelto.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarLibro(new Libro("Cien años de soledad", "Gabriel García Márquez"));
            biblioteca.ListarLibrosDisponibles();

            biblioteca.PrestarLibro("Cien años de soledad");
            biblioteca.ListarLibrosDisponibles();

            biblioteca.DevolverLibro("Cien años de soledad");
            biblioteca.ListarLibrosDisponibles();
        }
    }

}
