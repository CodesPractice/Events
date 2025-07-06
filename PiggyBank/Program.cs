using System;

namespace PiggyBank
{
    // Step 1: Define a delegate with a clear name
    public delegate void BalanceChangedHandler(int newBalance);

    // Step 2: Publisher class that raises the event
    class BankAccount
    {       
        private int balance = 0;

        // Step 3: Declare the event with a meaningful name
        public event BalanceChangedHandler OnBalanceChanged;

        // Property to update balance and raise the event
        public int Transaction
        {
            set
            {
                balance += value;
                // Fire the event when balance changes
                OnBalanceChanged?.Invoke(balance);
            }
        }
    }

    // Step 4: Main class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create account object
            BankAccount account = new BankAccount();

            // Subscribe to the balance changed event
            account.OnBalanceChanged += ShowUpdatedBalance;
            account.OnBalanceChanged += ShowGoalReachedMsg;

            string input;

            // Accept user input until "exit" is entered
            do
            {
                Console.Write("How much do you want to deposit? : ");
                input = Console.ReadLine();


                if (int.TryParse(input, out int amount))
                {
                    account.Transaction = amount;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }


            } while (input.ToLower() != "exit");
        }

        // Step 5: Event handler method
        static void ShowUpdatedBalance(int balance)
        {
            Console.WriteLine($"Current balance: {balance}");
        }

        static void ShowGoalReachedMsg(int balance)
        {
            if (balance > 500)
                Console.WriteLine($"You reached your saving goral! you have: {balance}");
        }
    }
}


