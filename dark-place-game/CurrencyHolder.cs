using System;
namespace dark_place_game
{
    [System.Serializable]
    /// Une Exeption Custom
    public class NotEnoughtSpaceInCurrencyHolderExeption : System.Exception { }
    public class CurrencyHolder
    {
        public static readonly string CURRENCY_DEFAULT_NAME = "Unnamed";
        /// Le nom de la monnaie
        public string CurrencyName
        {
            get { return currencyName; }
            private set
            {
                currencyName = value;
            }
        }
        // Le champs interne de la property
        private string currencyName = CURRENCY_DEFAULT_NAME;
        /// Le montant actuel
        public int CurrentAmount
        {
            get { return currentAmount; }
            private set
            {
                currentAmount = value;
            }
        }
        // Le champs interne de la property
        private int currentAmount = 0;
        /// La contenance maximum du conteneur
        /// La contenance maximum du conteneur
        public int Capacity
        {
            get { return capacity; }
            private set
            {
                capacity = value;
            }
        }
        // Le champs interne de la property
        private int capacity = 0;
        public CurrencyHolder(string name, int capacity, int amount)
        {
            if (!string.IsNullOrEmpty(name) && amount >= 0)
            {
                Capacity = capacity;
                CurrencyName = name;
                CurrentAmount = amount;
            }
            else
            {
                throw new ArgumentException();
            }

        }
        public bool IsEmpty()
        {
            return true;
        }
        public bool IsFull()
        {
            return true;
        }
        public void Store(int amount)
        {
        }
        public void Withdraw(int amount)
        {
        }
    }
}
