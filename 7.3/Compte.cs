using System;
using System.Collections.Generic;
using System.Text;

namespace _7._3
{
    public class Compte : IComparable
    {
        #region Properties 
        public string Titulaire { get; private set; }
        private decimal Balance { get; set; }
        #endregion

        #region Methods
        #region Constructeurs 
        public Compte(string pTitulaire, decimal pBalance)
        {
            Titulaire = pTitulaire;
            Balance = pBalance;
        }
        #endregion

        public void Debiter(decimal pDebit)
        {
            if (pDebit <= 0)
            {
                ArgumentException exception = new ArgumentException("Le débit doit être positif");
                throw exception;
            }
            else
            {
                Balance = Balance - pDebit;
            }
        }

        public void Crediter(decimal pCredit)
        {
            if (pCredit <= 0)
            {
                ArgumentException exception = new ArgumentException("Le crédit doit être positif");
                throw exception;
            }
            else
            {
                Balance = Balance - pCredit;
            }
        }

        public string Affiche
        {
            get
            {
                return $"***************************************\n" +
                       $"   - Titulaire : {Titulaire}\n" +
                       $"   - Balance   : {Balance}\n" +
                       $"   - Taux      : {Banque.TAUX}\n" +
                       $"***************************************";
            }
        }

        public decimal InteretCumules
        {
            get
            {
                return Balance * Banque.TAUX;
            }
        }
        #endregion

        #region interface methods
        public int CompareTo(object other)
        {
            if (other == null)
                return 1;

            if (!(other is Compte))
                throw new ArgumentException();

            return Titulaire.CompareTo((other as Compte).Titulaire);
        }
        #endregion
    }
}
