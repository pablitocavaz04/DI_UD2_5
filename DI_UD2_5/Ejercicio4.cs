using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Persona persona = new Persona("Juan", 25);
            persona.Saludar();
        }
    }

}
