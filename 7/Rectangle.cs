using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
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
