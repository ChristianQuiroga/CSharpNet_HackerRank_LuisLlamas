using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    internal class Loro:Animal
    {
        public new void HacerSonido()
        {
            Console.WriteLine("El loro imita sonidos");
        }
        public override void Dormir()
        {
            throw new NotImplementedException();
        }
    }
}
