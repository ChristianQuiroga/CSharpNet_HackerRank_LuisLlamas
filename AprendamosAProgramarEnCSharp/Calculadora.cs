using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal class Calculadora
    {
        // Campo estático
        public static int TotalOperaciones = 0;

        // Método estático
        public static int Sumar(int a, int b)
        {
            TotalOperaciones++;
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            TotalOperaciones++;
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            TotalOperaciones++;
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            TotalOperaciones++;
            return a / b;
        }
    }
}
