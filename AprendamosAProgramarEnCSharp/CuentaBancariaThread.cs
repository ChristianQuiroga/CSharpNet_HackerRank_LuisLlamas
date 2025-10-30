using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal class CuentaBancariaThread
    {
        private decimal saldo = 0;
        private object bloqueo = new object();

        public void Depositar(decimal cantidad)
        {
            lock (bloqueo)
            {
                saldo += cantidad;
                Console.WriteLine($"Depósito de {cantidad}. Saldo actual: {saldo}");
            }
        }
    }
}
