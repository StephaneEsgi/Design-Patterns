using System;

namespace State 
{
    public class Account
    {
        private State _state;
        private string _owner;

        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        public double Balance => _state.Balance;

        public State State
        {
            get => _state;
            set { _state = value; }
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Depot de {0:C} --- ", amount);
            Console.WriteLine(" Solde = {0:C}", this.Balance);
            Console.WriteLine(" Statut = {0}",
            this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Retrait {0:C} --- ", amount);
            Console.WriteLine(" Solde = {0:C}", this.Balance);
            Console.WriteLine(" Statut = {0}\n",
            this.State.GetType().Name);
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine("Paiement d'intérêts --- ");
            Console.WriteLine(" Solde = {0:C}", this.Balance);
            Console.WriteLine(" Statut = {0}\n",
            this.State.GetType().Name);
        }
    }
}
