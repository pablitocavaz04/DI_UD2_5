using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{

    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public CuentaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($"Depósito de {cantidad} realizado. Saldo actual: {Saldo}");
            }
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Retiro de {cantidad} realizado. Saldo actual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            CuentaBancaria cuenta = new CuentaBancaria("Ana", 1000);
            cuenta.Depositar(200);
            cuenta.Retirar(150);
            cuenta.Retirar(1200); // Intento de retiro con fondos insuficientes
        }
    }

}
