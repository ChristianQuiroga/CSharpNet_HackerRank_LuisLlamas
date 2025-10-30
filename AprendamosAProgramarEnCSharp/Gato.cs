using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    public class Gato : Animal
    {
        public Gato()
        {
        }
        public Gato(string nombre) : base(nombre)
        {
        }
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla.");
        }

        //Implementación método abstracto.
        public override void Dormir()
        {
            Console.WriteLine("El Gato está durmiendo.");
        }
    }

}
