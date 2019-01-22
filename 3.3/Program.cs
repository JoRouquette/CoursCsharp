using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputsA;
            inputsA = new List<int>();

            List<int> inputsB;
            inputsB = new List<int>();

            List<int> inputsC;
            inputsC = new List<int>();

            Random rand = new Random();

            Console.WriteLine("On génère dix entier pour le tableau A :");
            for (int i = 1; i <= 10; i++)
            {
                int random = rand.Next(1, 50);
                Console.WriteLine("Entier numéro " + i + " : " + random);
                inputsA.Add(random);
            }

            Console.WriteLine();

            Console.WriteLine("On génère dix entier pour le tableau B :");
            for (int i = 1; i <= 10; i++)
            {
                int random = rand.Next(1, 50);
                Console.WriteLine("Entier numéro " + i + " : " + random);
                inputsB.Add(random);
            }

            foreach (var integer in inputsA)
            {
                inputsC.Add(integer);
            }
            foreach (var integer in inputsB)
            {
                inputsC.Add(integer);
            }

            Console.WriteLine();

            Console.WriteLine("On imprime maintenant le dernier tableau :");
            foreach (var integer in inputsC)
            {
                Console.WriteLine(integer);
            }

            Console.ReadKey();
        }
    }
}
