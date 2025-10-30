using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    public class MyBook : Book
    {
        public int Price { get; set; }
        
        
        //constructorES
        //public MyBook(String t, String a) : base(t, a)
        //{
        //    this.title = t;
        //    this.author = a;
        //}
        public MyBook(String tParametro, String a, int Price) : base(tParametro, a)
        {
            this.Price = Price; //Scope o Ámbito de la variable Price no es igual al campo public int Price{}. tiene otro color. por eso usamos el this.
        }

        //Método Abstracto implementado.
        public override void display()
        {
            Console.WriteLine($"Title: {Title} + \nAuthor: {Author}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
