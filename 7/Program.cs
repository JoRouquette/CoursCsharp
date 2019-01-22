using System;

namespace _7
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

    class Rectangle
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }

        public decimal Perimetter
        {
            get { return (2 * (Width + Length)); }
        }
        public decimal Area
        {
            get { return (Width * Length); }
        }

        public string Affichage
        {
            get
            {
                return $"Le rectangle Lx {Length} lx {Width} à un périmètre de : {Perimetter}, et une aire de : {Area}.";
            }
        }

        public Rectangle(decimal pWidth, decimal pLength)
        {
            Length = pLength;
            Width = pWidth;
        }
    }
}
