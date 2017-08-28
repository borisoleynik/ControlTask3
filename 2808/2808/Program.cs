using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2808
{
    class Program
    {
        class Book
        {
            public string Name;
            public int Year;
            public string Autor;
        }
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book {Name = "LINQ", Year = 1080, Autor = "dfg srsdr" },
                new Book {Name = "netoslovo", Year = 1889, Autor = "ioitr whjkw" },
                new Book {Name = "ertert", Year = 1989, Autor = "ipoigf sdjhf" },
                new Book {Name = "LINQ dva", Year = 2089, Autor = "iutoiur oiuw" }

            };

            //------------1
            foreach(var item in books.Where(f => f.Name.Contains("LINQ")).Where(k =>  DateTime.IsLeapYear(k.Year)))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("----------------------------------");
            //------------2
            string words = "dana poslrdovatelnost russkih slov Skolko bukv bilo ispolzovano";

            Console.WriteLine(words.Distinct().Count());
            Console.WriteLine("----------------------------------");
            //------------3

            int[] numbers = { 33, 12,20,23,32, 14};

            foreach(var item in numbers.OrderBy(f => f.ToString().First()).ThenByDescending(k => k.ToString().Last()))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------");

            //------------4

             ;

            foreach(var item in books.GroupBy(f => f.Autor).Select(item => item.Key + " " + item.Count()))
            {
                Console.WriteLine(item);
            }
                

            Console.WriteLine("-------------------------");

        }
    }
}
