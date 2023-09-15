using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar den första personen");
            string q = Console.ReadLine();
            double x = double.Parse(q);

            Console.WriteLine("Hur mycket tjänar den andra personen");
            string l = Console.ReadLine();
            double y = double.Parse(l);

            Console.WriteLine("Hur mycket tjänar den tredje personen");
            string c = Console.ReadLine();
            double v = double.Parse(c);

            double sum = v + y + x;

            Console.WriteLine("Medellönen för din person är " + sum / 2 + " kr");
            Console.ReadKey();
         



        }




    }



}
