using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Donnez moi l'entier A : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Donnez moi l'entier B : ");
            b = int.Parse(Console.ReadLine());

            Swap(ref a, ref b);

            Console.WriteLine();

            Console.WriteLine("Voilà a : {0} et b : {1} ; ont échangé leur valeur.", a, b);

            Console.ReadKey();
        }

        static void Swap(ref int pA, ref int pB)
        {
            int tampon;
            tampon = pA;
            pA = pB;
            pB = tampon;
        }
    }
}
