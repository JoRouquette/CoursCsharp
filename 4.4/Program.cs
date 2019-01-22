using System;

namespace _4._4
{
    // la fonction factorielle est le produit des nombres entiers strictement positifs inférieurs ou égaux à n

    class Program
    {
        delegate long F(long n);

        static void Main(string[] args)
        {
            // One-liner utilisant les lambda expression (fonction annonyme)
            long f(long x) => x > 1 ? x * f(x - 1) : 1;

            Console.WriteLine("Liste des 16 premiers factoriels entiers :");

            for (int I = 0; I <= 15; I++)
            {
                Console.WriteLine(I + "! est " + f(I));
            }

            Console.ReadKey();
        }
    }
}
