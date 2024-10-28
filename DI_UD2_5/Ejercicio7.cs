using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{

    public class Estudiante
    {
        public string Nombre { get; set; }
        private List<double> Calificaciones { get; set; } = new List<double>();

        public Estudiante(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarCalificacion(double calificacion)
        {
            Calificaciones.Add(calificacion);
        }

        public double CalcularPromedio()
        {
            double suma = 0;
            foreach (var calificacion in Calificaciones)
                suma += calificacion;

            return Calificaciones.Count > 0 ? suma / Calificaciones.Count : 0;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Estudiante estudiante = new Estudiante("Carlos");
            estudiante.AgregarCalificacion(85);
            estudiante.AgregarCalificacion(90);
            estudiante.AgregarCalificacion(78);

            Console.WriteLine($"Promedio de {estudiante.Nombre}: {estudiante.CalcularPromedio()}");
        }
    }
}
