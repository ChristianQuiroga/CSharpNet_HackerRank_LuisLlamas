using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp.EjePolimorfismoHerencia
{
    public class Auto : Vehiculo
    {
        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine($"{Marca} {Modelo} Conduciendo AUTO! Override");
        }
        public void EncenderRadio()
        {
            Console.WriteLine($"{Marca} {Modelo} Prender Radio!");
        }
    }
}
