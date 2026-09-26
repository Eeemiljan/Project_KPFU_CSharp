using System;
enum BankAccountType
    
    {
        Current,
        Savings
    }
class Program
{
    static void Main()
    {
        
     BankAccountType accountType = BankAccountType.Current;
    
    Console.WriteLine(accountType);
     }
}