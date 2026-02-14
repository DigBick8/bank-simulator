using ATMApp.Services;

namespace ATMApp.View
{
    public static class BankingView
    {
        public static void Run()
    {
    char operation = ' ';
    double acoountBalance = 1000.00;
    double lastTransaction;
    
    Console.WriteLine("PIOL, Rey Angelo R.");
    Console.WriteLine("=== Simple ATM System ===");
    Console.WriteLine("Initial Balance" + balance);
        
        while (operation != '5')
            {
                Console.Write("\n");
  
                Console.WriteLine("Services: ");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit Money");
                Console.WriteLine("3.Withdraw Money");
                Console.WriteLine("4.Print Mini Statement");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Choose Service: ");
                operation = Convert.ToChar(Console.ReadLine());
            
                switch (operation)
                {
                case '1': //Check
                   BankingServices.GetBalance(accountBalance);
                    break;

                case '2': // Deposit
                   Console.WriteLine("Input amount to deposit: ");
                    bool isSuccessful1;
                        
                    double amount1 = Int32.Parse(Console.ReadLine());
                    lastTransaction = accountBalance;
                        
                    BankingServices.Deposit(ref accountBalance, amount1, out isSuccessful1);
                    Console.WriteLine((isSuccessful1 ? "Deposit successful." : "Invalid deposit amount. Please enter a positive value."));
                    break;
                    
                case '3': // Withdraw
                   Console.WriteLine("Input amount to withdraw: ");
                    double amount2 = Int32.Parse(Console.ReadLine());
                    bool isSuccessful2;
                          
                    lastTransaction = accountBalance;
                    
                    BankingServices.Withdraw(ref accountBalance, amount2, out isSuccessful2);
                    Console.WriteLine((isSuccessful2 ? "Withdraw successful." : ""));
                    break;
                    
                case '4': // Print
                     BankingServices.PrintMiniStatement(accountBalance, lastTransaction);
                        break;
                    
                case '5': // Exit
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                        return;
                
                default:
                    Console.WriteLine("Incorrect Operation Used, Please try again.");
                    continue;
                
                }
            }
    }
    }
}
