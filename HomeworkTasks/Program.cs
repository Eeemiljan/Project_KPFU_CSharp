using System;

enum AlcoholCategory
{
    A,
    B,
    C,
    D
}

struct Drink
{
    public string Name;
    public double AlcoholPercent;
}

struct Student
{
    public string Surname;
    public string Name;
    public int Id;
    public DateTime BirthDate;
    public AlcoholCategory Category;
    public double Volume;
    public Drink Drink;
}

class Program
{
    static void Main()
    {
        // Задача 1
        Console.WriteLine("Задача 1");
        Console.WriteLine("Тип данных - максимальное значение - минимальное значение");

        Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
        Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
        Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
        Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
        Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
        Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
        Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
        Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
        Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
        Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
        Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");

        Console.WriteLine();


        // Задача 2
        Console.WriteLine("Задача 2");
        Console.WriteLine("Введите данные пользователя");

        Console.Write("Введите имя: ");
        string name = Console.ReadLine()!;

        Console.Write("Введите город: ");
        string city = Console.ReadLine()!;

        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Введите PIN-код: ");
        string pinCode = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Город: {city}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"PIN-код: {pinCode}");

        Console.WriteLine();


        // Задача 3
        Console.WriteLine("Задача 3");
        Console.WriteLine("Замена строчных букв на заглавные и наоборот");

        Console.Write("Введите строку: ");
        string input = Console.ReadLine()!;

        string changedString = "";

        foreach (char symbol in input)
        {
            if (char.IsLower(symbol))
            {
                changedString += char.ToUpper(symbol);
            }
            else if (char.IsUpper(symbol))
            {
                changedString += char.ToLower(symbol);
            }
            else
            {
                changedString += symbol;
            }
        }

        Console.WriteLine($"Результат: {changedString}");

        Console.WriteLine();


        // Задача 4
        Console.WriteLine("Задача 4");
        Console.WriteLine("Подсчет количества вхождений подстроки");

        Console.Write("Введите строку: ");
        string text = Console.ReadLine()!;

        Console.Write("Введите подстроку: ");
        string substring = Console.ReadLine()!;

        int count = 0;
        int index = 0;

        if (substring.Length == 0)
        {
            Console.WriteLine("Подстрока не должна быть пустой");
        }
        else
        {
            while ((index = text.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            Console.WriteLine($"Количество вхождений: {count}");
        }

        Console.WriteLine();


        // Задача 5
        Console.WriteLine("Задача 5");
        Console.WriteLine("Расчет количества бутылок Duty Free");

        Console.Write("Введите обычную цену бутылки: ");
        int normPrice = int.Parse(Console.ReadLine()!);

        Console.Write("Введите скидку в процентах: ");
        int salePrice = int.Parse(Console.ReadLine()!);

        Console.Write("Введите стоимость отпуска: ");
        int holidayPrice = int.Parse(Console.ReadLine()!);

        double savingPerBottle = normPrice * salePrice / 100.0;

        if (savingPerBottle > 0)
        {
            int bottles = (int)(holidayPrice / savingPerBottle);

            Console.WriteLine($"Необходимо купить бутылок: {bottles}");
        }
        else
        {
            Console.WriteLine("Скидка должна быть больше нуля");
        }

        Console.WriteLine();


        // Задача 6
        Console.WriteLine("Задача 6");
        Console.WriteLine("Студенты и количество выпитого");

        Drink beer = new Drink();
        beer.Name = "Пиво";
        beer.AlcoholPercent = 5;

        Drink wine = new Drink();
        wine.Name = "Вино";
        wine.AlcoholPercent = 12;

        Drink vodka = new Drink();
        vodka.Name = "Водка";
        vodka.AlcoholPercent = 40;

        Drink champagne = new Drink();
        champagne.Name = "Шампанское";
        champagne.AlcoholPercent = 11;

        Drink water = new Drink();
        water.Name = "Вода";
        water.AlcoholPercent = 0;


        Student student1 = new Student();
        student1.Surname = "Иванов";
        student1.Name = "Иван";
        student1.Id = 1;
        student1.BirthDate = new DateTime(2007, 1, 15);
        student1.Category = AlcoholCategory.A;
        student1.Volume = 1500;
        student1.Drink = beer;


        Student student2 = new Student();
        student2.Surname = "Петров";
        student2.Name = "Петр";
        student2.Id = 2;
        student2.BirthDate = new DateTime(2006, 5, 20);
        student2.Category = AlcoholCategory.B;
        student2.Volume = 700;
        student2.Drink = wine;


        Student student3 = new Student();
        student3.Surname = "Сидоров";
        student3.Name = "Алексей";
        student3.Id = 3;
        student3.BirthDate = new DateTime(2007, 3, 10);
        student3.Category = AlcoholCategory.C;
        student3.Volume = 300;
        student3.Drink = vodka;


        Student student4 = new Student();
        student4.Surname = "Смирнов";
        student4.Name = "Максим";
        student4.Id = 4;
        student4.BirthDate = new DateTime(2006, 8, 25);
        student4.Category = AlcoholCategory.C;
        student4.Volume = 500;
        student4.Drink = champagne;


        Student student5 = new Student();
        student5.Surname = "Кузнецов";
        student5.Name = "Олег";
        student5.Id = 5;
        student5.BirthDate = new DateTime(2007, 11, 5);
        student5.Category = AlcoholCategory.D;
        student5.Volume = 1000;
        student5.Drink = water;


        Student[] students =
        {
            student1,
            student2,
            student3,
            student4,
            student5
        };


        double totalLiquid = 0;
        double totalAlcohol = 0;

        foreach (Student student in students)
        {
            totalLiquid += student.Volume;

            double alcoholVolume =
                student.Volume * student.Drink.AlcoholPercent / 100.0;

            totalAlcohol += alcoholVolume;
        }


        Console.WriteLine($"Общий объем жидкости: {totalLiquid} мл");
        Console.WriteLine($"Общий объем чистого алкоголя: {totalAlcohol} мл");
        Console.WriteLine();


        foreach (Student student in students)
        {
            double liquidPercent =
                student.Volume / totalLiquid * 100;

            double alcoholVolume =
                student.Volume * student.Drink.AlcoholPercent / 100.0;

            double alcoholPercent = 0;

            if (totalAlcohol > 0)
            {
                alcoholPercent =
                    alcoholVolume / totalAlcohol * 100;
            }

            Console.WriteLine($"{student.Surname} {student.Name}");
            Console.WriteLine($"Напиток: {student.Drink.Name}");
            Console.WriteLine($"Выпито: {student.Volume} мл");
            Console.WriteLine($"Доля всей жидкости: {liquidPercent:F2}%");
            Console.WriteLine($"Доля всего алкоголя: {alcoholPercent:F2}%");
            Console.WriteLine();
        }
    }
}