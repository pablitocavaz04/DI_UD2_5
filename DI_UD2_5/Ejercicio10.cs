using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{


    public class Asiento
    {
        public int Fila { get; }
        public int Columna { get; }
        public bool Reservado { get; set; }

        public Asiento(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Reservado = false;
        }
    }

    public class SalaCine
    {
        private Asiento[,] asientos = new Asiento[5, 8];

        public SalaCine()
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    asientos[i, j] = new Asiento(i, j);
        }

        public void ReservarAsiento(int fila, int columna)
        {
            if (asientos[fila, columna].Reservado)
                Console.WriteLine("Asiento ya reservado.");
            else
            {
                asientos[fila, columna].Reservado = true;
                Console.WriteLine("Asiento reservado correctamente.");
            }
        }

        public void CancelarReserva(int fila, int columna)
        {
            if (!asientos[fila, columna].Reservado)
                Console.WriteLine("Asiento no estaba reservado.");
            else
            {
                asientos[fila, columna].Reservado = false;
                Console.WriteLine("Reserva cancelada.");
            }
        }

        public void MostrarAsientos()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(asientos[i, j].Reservado ? "[X]" : "[ ]");
                Console.WriteLine();
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            SalaCine sala = new SalaCine();
            sala.MostrarAsientos();

            sala.ReservarAsiento(2, 3);
            Console.WriteLine("\nAsientos después de reservar el asiento (2,3):");
            sala.MostrarAsientos();

            sala.CancelarReserva(2, 3);
            Console.WriteLine("\nAsientos después de cancelar la reserva del asiento (2,3):");
            sala.MostrarAsientos();
        }
    }
}
