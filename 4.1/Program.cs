using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double distance;

            Double xA, xB, yA, yB;

            Console.WriteLine("Coordonée de A :");
            Console.Write("Coordonée de x de A : ");
            xA = Double.Parse(Console.ReadLine().Replace('.', ','));
            Console.Write("Coordonée de y de A : ");
            yA = Double.Parse(Console.ReadLine().Replace('.', ','));

            Console.WriteLine();

            Console.WriteLine("Coordonée de B :");
            Console.Write("Coordonée de x de B : ");
            xB = Double.Parse(Console.ReadLine().Replace('.',','));
            Console.Write("Coordonée de y de B : ");
            yB = Double.Parse(Console.ReadLine().Replace('.', ','));

            Console.WriteLine();

            distance = Distance(xA, yA, xB, yB);

            Console.WriteLine();

            Console.WriteLine("On a calculer la distance entre les deux points : {0}", distance);

            Console.ReadKey();
        }

        static Double Distance(Double pXa, Double pYa, Double pXb, Double pYb)
        {
            Double distance = 0;

            distance = Math.Round(Math.Sqrt(Math.Pow((pXb - pXa), 2) + Math.Pow((pYb - pYa), 2)), 3);

            return distance;
        }
    }
}
