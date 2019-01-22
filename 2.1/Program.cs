using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int paris;
            string message;

            Console.WriteLine("Placez votre paris :");
            paris = Convert.ToInt16(Console.ReadLine());

            if (56 <= paris && paris <= 78)
            {
                message = "GAGNER";
            }
            else
            {
                message = "PERDU";
            }
            Console.WriteLine("Votre paris était : " + paris + " et vous avez :");
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
