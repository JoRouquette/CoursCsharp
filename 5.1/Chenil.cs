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

        public Chenil(List<Chien> pChiens)
        {
            Chiens = pChiens;
        }

        public void Liste()
        {
            foreach (Chien pChien in Chiens)
            {
                Console.WriteLine($"{pChien.Name}");
            }
        }
    }
}
