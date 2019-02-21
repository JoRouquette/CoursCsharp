using System;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Créer un tableau de 3 comptes.
                Remplir les deux premiers éléments du tableau avec des comptes différents.
                Appeler Array.Sort sur votre tableau.
                Constater qu’une erreur survient.
                Faire implémenter l’interface IComparable par la classe Compte
                Réexécuter le main et constater que le tableau se trie sans erreur.

             */
            Compte compteDupont = new Compte("Dupont", 1000);
            Compte compteDurand = new Compte("Durand", 2000);
            Compte comptePersonne = new Compte("Personne", -256);

            Compte[] comptes = { compteDupont, compteDurand, comptePersonne };

            Array.Sort(comptes);

            Banque banque = Banque.GetInstance();

            banque.Add(compteDupont);
            banque.Add(compteDurand);

            foreach (Compte compte in banque.Comptes)
            {
                Console.WriteLine(compte.Affiche);
            }

            Console.ReadKey();
        }

        public void Swap(ref object pOne, ref object pTwo)
        {
            if (pTwo.GetType() == pOne.GetType())
            {
                object tamp = pOne;

                pOne = pTwo;

                pTwo = tamp;
            }
            else
            {
                ArgumentException exception = new ArgumentException("Les deux paramètres d'entrés doivent être de même type.");
                throw exception;
            }
        }
    }
}
