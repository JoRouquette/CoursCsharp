using System;
using System.Collections.Generic;
using System.Text;

namespace _7._2
{
    class Point
    {
        #region attribut 
        private double X { get; set; }
        private double Y { get; set; }
        #endregion

        #region Constructeurs
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double pX, double pY)
        {
            X = pX;
            Y = pY;
        }
        #endregion

        /*
            - Une fonction membre Deplace effectuant une translation définie par ses deux arguments dx et dy (double)
            - Une fonction membre Affiche se contentant d'afficher les coordonnées cartésiennes du point.
            - Une fonction membre Distance calculant la distance entre deux points.
            - Une fonction membre milieu donnant le Point au milieu d'un segment
        */
        #region Methodes
        public double Distance(Point pPointB) => Math.Round(Math.Sqrt(Math.Pow((pPointB.X - X), 2) + Math.Pow((pPointB.Y - Y), 2)), 3);

        public void Deplace(double pTranslate)
        {
            double tamponX = X;
            double tamponY = Y;
            X = tamponX + pTranslate;
            Y = tamponY + pTranslate;
        }
        public string Affiche
        {
            get { return $"P({X} ; {Y})"; }
        }
        

        public Point Milieu(Point pPointB)
        {
            Point milieuSegment;
            double pXmilieu = Math.Round((X + pPointB.X) / 2, 2);
            double pYmilieu = Math.Round((Y + pPointB.Y) / 2, 2);
            milieuSegment = new Point(pXmilieu, pYmilieu);
            return milieuSegment;
        }
        #endregion
    }
}
