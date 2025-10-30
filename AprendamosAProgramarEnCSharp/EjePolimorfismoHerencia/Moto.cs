using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp.EjePolimorfismoHerencia
{
    public class Moto : Auto
    {
        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine($"Conduciendo Moto! Override {Marca} {Modelo}");
        }
        public void HacerCaballito()
        {
            Console.WriteLine($"{Marca} {Modelo} Hacer la gran Willy (caballito)");
        }
    }
}
