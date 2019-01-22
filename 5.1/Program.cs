using System;

namespace _5._1
{
    class Program
    {
        enum Race { Caniche, Bouledogue };

        struct Chien
        {
            public string Name { get; set; }
            public Race race { get; set; }
            void Aboyer()
            {
                // switch race : 
            }
        }

        struct Chenil
        {
            Chien[] chiens;
            //public object this[int index]
            //{
            //    //get { /* return the specified index here */ }
            //    //set { /* set the specified index to value here */ }
            //}
            void Add(Chien pChien)
            {
                //chiens = pChien;
            }
        }

        static void Main(string[] args)
        {
            //Struct Chenil { Chien[] chiens; prop indexer[]; void Add(Chien) }

        }
    }
}
