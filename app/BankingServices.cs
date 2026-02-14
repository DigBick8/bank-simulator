namespace ATMApp.Services
{
    public static class BankingServices
    {
                // Option 1: Pass-by-value
        public static double GetBalance(double balance)
        {
            Console.WriteLine("Current Balance" + balance);
            return balance;
        }

        // Option 2: ref (Deposit)
        public static bool Deposit(ref double balance, double amount)
        {
            return false; //placeholder return value, replace with actual implementation
            return balance;
        }

        public static void Deposit(ref double balance, double amount, out bool isSuccessful)
        {
        if(amount < 0){
            isSuccessful = false;
            return;
            }
        }

        // Option 3: ref + out (Withdraw)
        public static void Withdraw(ref double balance, double amount, out bool isSuccessful)
        {
                isSuccessful = false; //placeholder value, replace with actual implementation
            {
            if(amount > balance){
              isSuccessful = false; 
              Console.WriteLine("Withdrawal failed. Insufficient balance.");
              return;
            } 
            if(amount < 1){
               isSuccessful = false; 
              Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
              return;
            }
                 balance -= amount;
                 isSuccessful = true;
            }
        }
        
        //4
        public static void Display(double balance, double lastTransaction)
        {
            Console.WriteLine("--- Mini Statement ---");
            Console.WriteLine("Current Balance: P" + balance);
            Console.WriteLine("Last Transaction Amount: P" + lastTransaction);
        }
        
    }
}
