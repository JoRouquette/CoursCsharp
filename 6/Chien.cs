using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    struct Chien
    {
        public string Name { get; set; }
        public Races Race { get; set; }

        public Chien(string pName, Races pRace)
        {
            Name = pName;
            Race = pRace;
        }

        public void Aboyer()
        {
            switch (Race)
            {
                case Races.Bouledogue:
                    break;

                case Races.Caniche:
                    break;
            }
        }
    }
}
