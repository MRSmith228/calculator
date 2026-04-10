using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите выражение: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            bool c = double.TryParse(parts[0], out double a);
            string deistvie = parts[1];
            bool d = double.TryParse(parts[2], out double b);
            if (!c || !d)
            {
                Console.WriteLine("Значение для выражения должно иметь только циферные значение.");
                continue;
            }
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
                Console.WriteLine(Math.Pow(a, b));
            }
            Console.ReadKey();
        }
    }
}
