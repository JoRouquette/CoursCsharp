using System;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rentré la longueur du rectangle : ");
            decimal length = decimal.Parse(Console.ReadLine().Replace('.', ','));

            Console.Write("Rentré la largeur du rectangle : ");
            decimal width = decimal.Parse(Console.ReadLine().Replace('.', ','));

            Rectangle rectangle = new Rectangle(width, length);

            Console.WriteLine(rectangle.Affichage);

            Console.ReadKey();
        }
    }
}
