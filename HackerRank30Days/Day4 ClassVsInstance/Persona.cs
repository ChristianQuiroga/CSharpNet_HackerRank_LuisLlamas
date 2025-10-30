using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days  
{
    internal class Persona
    {
        public int age;
        public Persona(int initialAge)
        {// Add some more code to run some checks on initialAge
            age = initialAge;
            //string mensaje = age < 0 ? "Age is not valid" : age.ToString();
            if (age < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid setting age to 0.");
            }
        }
        public void amIOld()
        {// Do some computations in here and print out the correct statement to the console 
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }
        public void yearPasses()
        {// Increment the age of the person in here
            age ++; 
        }
        
    }
}
