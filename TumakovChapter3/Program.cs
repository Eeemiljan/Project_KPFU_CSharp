using System;

enum BankAccountType
{
    Current,
    Savings
}

struct BankAccount
{
    public string Number;
    public BankAccountType Type;
    public decimal Balance;
}

enum University
{
    KGU,
    KAI,
    KHTI
}

struct Worker
{
    public string Name;
    public University University;
}

class Program
{
    static void Main()
    {
        // Упражнение 3.1
        Console.WriteLine("Упражнение 3.1");

        BankAccountType accountType = BankAccountType.Current;

        Console.WriteLine($"Тип банковского счета: {accountType}");
        Console.WriteLine();


        // Упражнение 3.2
        Console.WriteLine("Упражнение 3.2");

        BankAccount account = new BankAccount();

        account.Number = "123456789";
        account.Type = BankAccountType.Savings;
        account.Balance = 15000.50m;

        Console.WriteLine($"Номер счета: {account.Number}");
        Console.WriteLine($"Тип счета: {account.Type}");
        Console.WriteLine($"Баланс: {account.Balance}");
        Console.WriteLine();


        // Домашнее задание 3.1
        Console.WriteLine("Домашнее задание 3.1");

        Worker worker = new Worker();

        worker.Name = "Иван";
        worker.University = University.KGU;

        Console.WriteLine($"Имя работника: {worker.Name}");
        Console.WriteLine($"ВУЗ: {worker.University}");
    }
}