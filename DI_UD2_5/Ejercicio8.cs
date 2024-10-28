using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{
    public class Coche
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public bool Estado { get; set; } // true = reparado, false = no reparado

        public Coche(string matricula, string marca)
        {
            Matricula = matricula;
            Marca = marca;
            Estado = false; // Por defecto, no reparado
        }
    }

    public class Taller
    {
        private List<Coche> coches = new List<Coche>();

        public void AgregarCoche(Coche coche) => coches.Add(coche);

        public void EliminarCoche(string matricula)
        {
            coches.RemoveAll(c => c.Matricula == matricula);
        }

        public void RepararCoche(string matricula)
        {
            Coche coche = coches.Find(c => c.Matricula == matricula);
            if (coche != null) coche.Estado = true;
        }

        public void ListarCoches()
        {
            foreach (var coche in coches)
            {
                Console.WriteLine($"Matrícula: {coche.Matricula}, Marca: {coche.Marca}, Reparado: {coche.Estado}");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Taller taller = new Taller();
            taller.AgregarCoche(new Coche("1234ABC", "Toyota"));
            taller.AgregarCoche(new Coche("5678DEF", "Honda"));

            Console.WriteLine("Lista de coches antes de reparación:");
            taller.ListarCoches();

            taller.RepararCoche("1234ABC");
            Console.WriteLine("\nLista de coches después de reparar el coche con matrícula 1234ABC:");
            taller.ListarCoches();
        }
    }
}
