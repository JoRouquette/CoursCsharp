using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int somme = 0;

            Console.WriteLine("We need 5 integers:");
            somme = somme + Convert.ToInt16(Console.ReadLine());
            somme = somme + Convert.ToInt16(Console.ReadLine());
            somme = somme + Convert.ToInt16(Console.ReadLine());
            somme = somme + Convert.ToInt16(Console.ReadLine());
            somme = somme + Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("We can now calculate the average:");
            int average = Convert.ToInt16(somme / 5);
            Console.WriteLine("Average is: " + average);

            Console.ReadKey();
        }
    }
}
