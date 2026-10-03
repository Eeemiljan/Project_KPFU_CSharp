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
    КГУ,
    КАИ,
    КХТИ
}

struct Employee
{
    public string Name;
    public University University;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.1. Виды банковского счёта. Ввод не требуется.");
        // Решение упражнения 3.1, написанное пользователем.
        BankAccountType accountType = BankAccountType.Current;
        Console.WriteLine(accountType);

        Console.WriteLine("\nУпражнение 3.2. Информация о банковском счёте. Ввод не требуется.");
        BankAccount account;
        // Номер — строка: с ним не считают, а начальные нули важны.
        account.Number = "00123456789012345678";
        account.Type = BankAccountType.Savings;
        account.Balance = 12500.50m;
        Console.WriteLine($"Номер: {account.Number}");
        Console.WriteLine($"Тип: {account.Type}");
        Console.WriteLine($"Баланс: {account.Balance:F2}");

        Console.WriteLine("\nДомашнее задание 3.1. Работник и его ВУЗ. Ввод не требуется.");
        Employee employee;
        employee.Name = "Эмиль";
        employee.University = University.КГУ;
        Console.WriteLine($"Имя: {employee.Name}");
        Console.WriteLine($"ВУЗ: {employee.University}");
    }
}
