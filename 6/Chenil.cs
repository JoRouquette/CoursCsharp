using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    struct Chenil
    {
        public List<Chien> Chiens;

        public void Add(Chien pChien)
        {
            Chiens.Add(pChien);
        }

        public Chenil(int taille)
        {
            Chiens = new List<Chien>(taille);
        }

        public void Liste()
        {
            foreach (Chien pChien in Chiens)
            {
                Console.WriteLine($"{pChien.Name}, de race {pChien.Race}");
            }
        }

        public void ListeRace()
        {
            foreach (Chien pChien in Chiens)
            {
                Console.WriteLine($"Race {pChien.Race}");
            }
        }           
    }
}
