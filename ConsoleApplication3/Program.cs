using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите выражение: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        if (parts.Length < 3)
        {
            Console.WriteLine("Ошибка: введите выражение через пробелы.");
            return;
        }
        double a = double.Parse(parts[0]);
        string deistvie = parts[1];
        double b = double.Parse(parts[2]);
        if (deistvie == "+")
        {
            Console.WriteLine(a + b);
        }
        if (deistvie == "-")
        {
            Console.WriteLine(a - b);
        }
        if (deistvie == "*")
        {
            Console.WriteLine(a * b);
        }
        if (deistvie == "/")
        {
            if (b == 0)
            {
                Console.WriteLine("Нельзя делить на ноль!");
                return;
            }
            Console.WriteLine(a * b);
        }

        if (deistvie == "^")
        {
            Console.WriteLine(Math.Pow(a,b));
        }
        Console.ReadKey();
    }
}