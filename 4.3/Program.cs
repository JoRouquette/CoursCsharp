using System;
using System.Collections.Generic;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomInputs = new Random();
            Random randomLength = new Random();

            List<int> tableau = new List<int>();

            int length = randomLength.Next(10, 25);

            Console.WriteLine("******************** \n Création tableau : \n********************");
            for (int i = 0; i < length; i++)
            {
                int input = randomInputs.Next(100);
                tableau.Add(input);
                Console.WriteLine("#{0} : {1}", i, input);
            }

            Boolean retourFct = F(tableau, length);

            Console.WriteLine("Retour fonction F : {0}", retourFct);

            Console.ReadKey();
        }

        static Boolean F (List<int> t, int n)
        {
            Boolean retour = false;

            t.Sort();

            if (t[0] <= 10)
            {
                retour = true;
            }
            
            return retour;
        }
    }
}
