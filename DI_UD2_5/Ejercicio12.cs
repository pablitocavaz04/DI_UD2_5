using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{

    public class Archivo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Tamano { get; set; } // En MB

        public Archivo(string nombre, string tipo, double tamano)
        {
            Nombre = nombre;
            Tipo = tipo;
            Tamano = tamano;
        }
    }

    public class NubeAlmacenamiento
    {
        private List<Archivo> archivos = new List<Archivo>();
        private const double LimiteEspacio = 500.0; // 500 MB

        public void SubirArchivo(Archivo archivo)
        {
            if (CalcularEspacioDisponible() >= archivo.Tamano)
            {
                archivos.Add(archivo);
                Console.WriteLine("Archivo subido correctamente.");
            }
            else
            {
                Console.WriteLine("No hay suficiente espacio para subir el archivo.");
            }
        }

        public void EliminarArchivo(string nombre)
        {
            archivos.RemoveAll(a => a.Nombre == nombre);
            Console.WriteLine("Archivo eliminado.");
        }

        public void ListarArchivos()
        {
            foreach (var archivo in archivos)
            {
                Console.WriteLine($"Nombre: {archivo.Nombre}, Tipo: {archivo.Tipo}, Tamaño: {archivo.Tamano} MB");
            }
        }

        public double CalcularEspacioDisponible()
        {
            double espacioOcupado = 0;
            foreach (var archivo in archivos)
                espacioOcupado += archivo.Tamano;
            return LimiteEspacio - espacioOcupado;
        }
    }

    public class Program
    {
        public static void Main()
        {
            NubeAlmacenamiento nube = new NubeAlmacenamiento();

            Archivo archivo1 = new Archivo("documento1", "documento", 50);
            Archivo archivo2 = new Archivo("imagen1", "imagen", 200);

            nube.SubirArchivo(archivo1);
            nube.SubirArchivo(archivo2);

            Console.WriteLine("\nLista de archivos:");
            nube.ListarArchivos();

            Console.WriteLine("\nEspacio disponible: " + nube.CalcularEspacioDisponible() + " MB");
        }
    }
}
