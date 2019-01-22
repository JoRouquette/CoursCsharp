using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs;
            inputs = new List<int>();

            Console.WriteLine("On a besoin de 10 entiers pour la suite :");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Entier numéro " + i + " : " );
                inputs.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Le plus petit des entiers entré est : " + inputs.Min() + ".");

            Console.ReadKey();
        }
    }
}
