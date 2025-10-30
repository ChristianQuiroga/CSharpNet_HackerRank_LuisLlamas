using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendamosAProgramarEnCSharp
{
    public class Perro : Animal
    {
        public string Raza {  get; set; }

        //Constructor
        public Perro()
        {
        }
        public Perro(string nombre) : base(nombre) 
        {      
        }
        public Perro(string nombre, string raza) : base(nombre)
        {
            Raza = raza;
        }

        //Métodos
        public void Ladrar() //Propio método 
        {
            Console.WriteLine("El perro está ladrando.");
        }
        public override void HacerSonido() //método heredado override
        {
            base.HacerSonido(); // Invoca el método de la clase base
            Console.WriteLine("El perro ladra.");
        }

        public override void Dormir() //método heredado override ABSTRACTO
        {
            Console.WriteLine("El perro está durmiendo.");
        }
    }
}
