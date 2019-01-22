using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbe;
            string verbeTrim;
            List<string> pronoms = new List<string>();

            Console.WriteLine("Veuillez rentrer un verbe du premier groupe :");
            verbe = Console.ReadLine();

            List<string> terminaison = new List<string>()
            {
                "e",
                "es",
                "e",
                "ons",
                "ez",
                "ent"
            };


            verbeTrim = verbe.TrimEnd('r', 'e');

            if (verbe.StartsWith("a") || verbe.StartsWith("e") || verbe.StartsWith("é"))
            {
                pronoms.Add("J'");
                pronoms.Add("Tu");
                pronoms.Add("Il");
                pronoms.Add("Nous");
                pronoms.Add("Vous");
                pronoms.Add("Ils");
            }
            else
            {
                pronoms.Add("Je");
                pronoms.Add("Tu");
                pronoms.Add("Il");
                pronoms.Add("Nous");
                pronoms.Add("Vous");
                pronoms.Add("Ils");
            }

            for (int i = 0; i < pronoms.Count; i++)
            {
                Console.WriteLine(pronoms[i] + " " + verbeTrim + terminaison[i]);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
