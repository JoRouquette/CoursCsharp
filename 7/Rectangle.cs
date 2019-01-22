using System;

namespace _7._1
{
    class Rectangle
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }

        public decimal Perimetter
        {
            get { return Math.Round((2 * (Width + Length)), 2); }
        }
        public decimal Area
        {
            get { return Math.Round((Width * Length), 2); }
        }

        public string Affichage
        {
            get
            {
                return $"Le rectangle Lx({Length}) et lx({Width}) à un périmètre de : {Perimetter}, et une aire de : {Area}.";
            }
        }

        public Rectangle(decimal pWidth, decimal pLength)
        {
            Length = pLength;
            Width = pWidth;
        }
    }
}
