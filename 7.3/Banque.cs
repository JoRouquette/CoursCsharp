using System;
using System.Collections.Generic;
using System.Text;

namespace _7._3
{
    sealed class Banque
    {
        #region Class properties
        public static readonly decimal TAUX = 3;

        static Banque instance = null;
        #endregion

        #region Class methods
        public static Banque GetInstance()
        {
            if (instance == null)
            {
                instance = new Banque();
            }
            return instance;

        }
        //create an indexer on the account list
        public Compte this[string tit] => Comptes.Find(x=> x.Titulaire == tit);
        #endregion

        #region Properties
        public List<Compte> Comptes { get; }
        #endregion

        #region Constructor
        private Banque()
        {
            Comptes = new List<Compte>();
        }
        #endregion

        #region Methods
        public void Add(Compte pCompte)
        {
            Comptes.Add(pCompte);
        }
        #endregion        
    }
}
