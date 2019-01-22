using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs;
            inputs = new List<int>();

            int present;

            Console.WriteLine("On a besoin de 10 entiers pour la suite :");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Entier numéro " + i + " : ");
                inputs.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("On a besoin de 1 entiers supplémentaire :");
            present = Convert.ToInt32(Console.ReadLine());

            if (inputs.Contains(present))
            {
                Console.WriteLine(present + " est dans le tableau");
            }
            else
            {
                Console.WriteLine(present + " n'est pas dans le tableau");
            }

            Console.ReadKey();
        }
    }
}
