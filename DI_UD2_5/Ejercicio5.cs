using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{

    public class Rectangulo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea() => Largo * Ancho;

        public double CalcularPerimetro() => 2 * (Largo + Ancho);
    }

    public class Program
    {
        public static void Main()
        {
            Rectangulo rectangulo = new Rectangulo(5, 3);
            Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + rectangulo.CalcularPerimetro());
        }
    }


}
