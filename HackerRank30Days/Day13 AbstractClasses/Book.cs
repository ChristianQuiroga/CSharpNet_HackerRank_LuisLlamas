using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    public abstract class Book
    {
        //convención PascalCase, primera lestra Mayuscula...
        protected String Title;
        protected String Author;

        //constructor
        public Book(String t, String a)
        {
            Title= t;
            Author= a;
        }

        //método abastracto
        public abstract void display();
    }
}
