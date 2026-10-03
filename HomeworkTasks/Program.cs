using System;

enum AlcoholCategory
{
    A, // По условию: студент алкоголик.
    B, // Любитель выпить.
    C, // Пьёт по праздникам.
    D  // Не пьёт алкоголь.
}

struct Drink
{
    public string Name;
    public double AlcoholPercent;
}

struct Student
{
    public string LastName;
    public string FirstName;
    public int Id;
    public DateTime BirthDate;
    public AlcoholCategory Category;
    public Drink Drink;
    public double VolumeLiters;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 1. Диапазоны встроенных типов данных. Ввод не требуется.");
        Console.WriteLine("Тип данных — максимальное значение — минимальное значение");
        Console.WriteLine($"sbyte — {sbyte.MaxValue} — {sbyte.MinValue}");
        Console.WriteLine($"byte — {byte.MaxValue} — {byte.MinValue}");
        Console.WriteLine($"short — {short.MaxValue} — {short.MinValue}");
        Console.WriteLine($"ushort — {ushort.MaxValue} — {ushort.MinValue}");
        Console.WriteLine($"int — {int.MaxValue} — {int.MinValue}");
        Console.WriteLine($"uint — {uint.MaxValue} — {uint.MinValue}");
        Console.WriteLine($"long — {long.MaxValue} — {long.MinValue}");
        Console.WriteLine($"ulong — {ulong.MaxValue} — {ulong.MinValue}");
        Console.WriteLine($"nint — {nint.MaxValue} — {nint.MinValue}");
        Console.WriteLine($"nuint — {nuint.MaxValue} — {nuint.MinValue}");
        Console.WriteLine($"float — {float.MaxValue} — {float.MinValue}");
        Console.WriteLine($"double — {double.MaxValue} — {double.MinValue}");
        Console.WriteLine($"decimal — {decimal.MaxValue} — {decimal.MinValue}");
        // Крайние символы могут не отображаться, поэтому выводим их числовые коды.
        Console.WriteLine($"char (код UTF-16) — {(int)char.MaxValue} — {(int)char.MinValue}");
        Console.WriteLine("bool — числовых границ нет; значения: true и false");
        Console.WriteLine("string — числовых границ нет; хранит текст");
        Console.WriteLine("object — числовых границ нет; может хранить значение любого типа");
        Console.WriteLine("Для float и double указаны конечные границы; также есть бесконечности и NaN.");

        Console.WriteLine("\nЗадача 2. Данные пользователя. Введите имя, город, возраст и учебный PIN-код.");
        Console.Write("Имя: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Город: ");
        string city = Console.ReadLine() ?? "";
        Console.Write("Возраст (целое неотрицательное число): ");
        int age;
        if (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Некорректный возраст. Запустите программу заново.");
            return;
        }
        Console.Write("PIN-код (например, 0042): ");
        string pin = Console.ReadLine() ?? "";
        Console.WriteLine($"Имя: {name}; город: {city}; возраст: {age}; PIN-код: {pin}");

        Console.WriteLine("\nЗадача 3. Замена регистра букв. Введите строку:");
        string text = Console.ReadLine() ?? "";
        string changedText = "";
        for (int i = 0; i < text.Length; i++)
        {
            char symbol = text[i];
            if (char.IsLower(symbol))
            {
                changedText += char.ToUpper(symbol);
            }
            else if (char.IsUpper(symbol))
            {
                changedText += char.ToLower(symbol);
            }
            else
            {
                changedText += symbol;
            }
        }
        Console.WriteLine($"Результат: {changedText}");

        Console.WriteLine("\nЗадача 4. Количество вхождений подстроки (с учётом регистра и перекрытий).");
        Console.Write("Строка: ");
        string source = Console.ReadLine() ?? "";
        Console.Write("Подстрока: ");
        string substring = Console.ReadLine() ?? "";
        int count = 0;
        if (substring.Length == 0)
        {
            Console.WriteLine("Пустую подстроку не считаем: введите непустую подстроку при следующем запуске.");
        }
        else
        {
            for (int i = 0; i <= source.Length - substring.Length; i++)
            {
                if (source.Substring(i, substring.Length) == substring)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество вхождений: {count}");
        }

        Console.WriteLine("\nЗадача 5. Экономия в Duty Free. Введите три целых числа.");
        Console.Write("Обычная цена бутылки (больше 0): ");
        int normPrice;
        bool validPrice = int.TryParse(Console.ReadLine(), out normPrice);
        Console.Write("Скидка в процентах (от 1 до 100): ");
        int salePrice;
        bool validSale = int.TryParse(Console.ReadLine(), out salePrice);
        Console.Write("Стоимость отпуска (не меньше 0): ");
        int holidayPrice;
        bool validHoliday = int.TryParse(Console.ReadLine(), out holidayPrice);
        if (!validPrice || !validSale || !validHoliday ||
            normPrice <= 0 || salePrice <= 0 || salePrice > 100 || holidayPrice < 0)
        {
            Console.WriteLine("Некорректные данные: проверьте целые числа и указанные диапазоны.");
        }
        else
        {
            // 100m задаёт decimal: дробная экономия не теряется при делении.
            decimal savingPerBottle = (decimal)normPrice * salePrice / 100m;
            // По условию округляем вниз, хотя для полного покрытия расходов нужен потолок.
            long bottles = (long)(holidayPrice / savingPerBottle);
            Console.WriteLine($"Количество бутылок (округление вниз): {bottles}");
        }

        Console.WriteLine("\nЗадача 6. Студенты и напитки. Данные заданы в программе; ввод не требуется.");
        Console.WriteLine("Категории по условию: a — алкоголик, b — любитель, c — по праздникам, d — не пьёт.");
        Drink beer;
        beer.Name = "Пиво";
        beer.AlcoholPercent = 5;
        Drink wine;
        wine.Name = "Вино";
        wine.AlcoholPercent = 12;
        Drink cider;
        cider.Name = "Сидр";
        cider.AlcoholPercent = 4.5;
        Drink juice;
        juice.Name = "Сок";
        juice.AlcoholPercent = 0;

        // Массив хранит ровно пять студентов. Поля заполняем явно.
        Student[] students = new Student[5];
        students[0].LastName = "Иванов";
        students[0].FirstName = "Иван";
        students[0].Id = 1;
        students[0].BirthDate = new DateTime(2005, 1, 15);
        students[0].Category = AlcoholCategory.A;
        students[0].Drink = beer;
        students[0].VolumeLiters = 2;

        students[1].LastName = "Петрова";
        students[1].FirstName = "Анна";
        students[1].Id = 2;
        students[1].BirthDate = new DateTime(2004, 6, 10);
        students[1].Category = AlcoholCategory.B;
        students[1].Drink = wine;
        students[1].VolumeLiters = 0.5;

        students[2].LastName = "Сидоров";
        students[2].FirstName = "Павел";
        students[2].Id = 3;
        students[2].BirthDate = new DateTime(2005, 3, 21);
        students[2].Category = AlcoholCategory.C;
        students[2].Drink = cider;
        students[2].VolumeLiters = 0.5;

        students[3].LastName = "Смирнова";
        students[3].FirstName = "Мария";
        students[3].Id = 4;
        students[3].BirthDate = new DateTime(2004, 11, 4);
        students[3].Category = AlcoholCategory.D;
        students[3].Drink = juice;
        students[3].VolumeLiters = 1;

        students[4].LastName = "Орлов";
        students[4].FirstName = "Алексей";
        students[4].Id = 5;
        students[4].BirthDate = new DateTime(2005, 8, 30);
        students[4].Category = AlcoholCategory.B;
        students[4].Drink = beer;
        students[4].VolumeLiters = 1;

        double totalVolume = 0;
        double totalAlcohol = 0;
        for (int i = 0; i < students.Length; i++)
        {
            totalVolume += students[i].VolumeLiters;
            totalAlcohol += students[i].VolumeLiters * students[i].Drink.AlcoholPercent / 100;
        }

        double averageAlcoholPercent = 0;
        if (totalVolume > 0)
        {
            averageAlcoholPercent = totalAlcohol / totalVolume * 100;
        }
        Console.WriteLine($"Общий объём жидкости: {totalVolume:F3} л");
        Console.WriteLine($"Общий объём чистого спирта: {totalAlcohol:F4} л");
        Console.WriteLine($"Доля спирта в общем объёме: {averageAlcoholPercent:F2}%");

        for (int i = 0; i < students.Length; i++)
        {
            Student student = students[i];
            double alcoholVolume = student.VolumeLiters * student.Drink.AlcoholPercent / 100;
            double volumeShare = 0;
            double alcoholShare = 0;
            if (totalVolume > 0)
            {
                volumeShare = student.VolumeLiters / totalVolume * 100;
            }
            if (totalAlcohol > 0)
            {
                alcoholShare = alcoholVolume / totalAlcohol * 100;
            }
            Console.WriteLine($"\n{student.LastName} {student.FirstName}, ID: {student.Id}");
            Console.WriteLine($"Дата рождения: {student.BirthDate:dd.MM.yyyy}; категория: {student.Category.ToString().ToLower()}");
            Console.WriteLine($"Напиток: {student.Drink.Name}; крепость: {student.Drink.AlcoholPercent}%");
            Console.WriteLine($"Выпито: {student.VolumeLiters:F3} л; чистого спирта: {alcoholVolume:F4} л");
            Console.WriteLine($"Доля всей жидкости: {volumeShare:F2}%; доля всего спирта: {alcoholShare:F2}%");
        }
    }
}
