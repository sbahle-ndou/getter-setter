using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter___setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            movie1 movie2 = new movie1("Unreleased", "Evans", "PG");

            Console.WriteLine(movie1.Rating);
            Console.ReadLine();
        }
    }
}
