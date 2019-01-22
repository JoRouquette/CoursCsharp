using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs;
            inputs = new List<int>();

            int counter = 0;

            Console.WriteLine("On a besoin de 10 entiers pour la suite :");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Entier numéro " + i + " : ");
                inputs.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var integer in inputs)
            {
                if (integer <= 10)
                {
                    counter++;
                }
            }

            Console.WriteLine("Il y a : " + counter + " entiers supérieur ou égale à 10.");

            Console.ReadKey();
        }
    }
}
