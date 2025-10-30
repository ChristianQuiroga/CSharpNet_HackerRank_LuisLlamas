using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    internal class Student:Person
    {
        private int[] testScores;

        // Constructors
        public Student() { }
        public Student(string firstNameStu, string lastNameStu, int identificationStu, int[] testScores)
        {
            this.firstName = firstNameStu;
            this.lastName = lastNameStu;
            this.id = identificationStu;
            this.testScores = testScores;
        }

        // Method
        public char Calculate()
        {
            int cantNotes = testScores.Length;
            int average = testScores.Sum()/cantNotes;
            char leeter;

            switch (average)
            {
                case int n when (n < 40):
                    //Console.WriteLine('T');
                    leeter = 'T';
                    break;
                case int n when (n >= 40 && n < 55):
                    //Console.WriteLine('D');
                    leeter = 'D';
                    break;
                case int n when (n >= 55 && n <70):
                    //Console.WriteLine('P');
                    leeter = 'P';
                    break;
                case int n when (n >= 70 && n < 80):
                    //Console.WriteLine('A');
                    leeter = 'A';
                    break;
                case int n when (n >= 80 && n < 90):
                    //Console.WriteLine('E');
                    leeter = 'E';
                    break;
                case int n when (n >= 90 && n < 100):
                    //Console.WriteLine('O');
                    leeter = 'O';
                    break;
                default:
                    return '\0';
            }
            return leeter;
        }

    }
}
