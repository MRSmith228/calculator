using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите выражение: ");
            char[] deistvie = { '+', '-', '*', '^', '/' };
            string input = Console.ReadLine().Replace(" ", "");
            input.IndexOfAny(deistvie);
            var x = input.IndexOfAny(deistvie);
            if (x == -1)
            {
                Console.WriteLine("Что-то не так");
                continue;
            }
            string[] parts = input.Split(deistvie);
            char xui = input[x];
            if (double.TryParse(parts[0], out double a) & double.TryParse(parts[1], out double b))
            {
                if (xui == '+')
                {
                    Console.WriteLine(a + b);
                }
                if (xui == '-')
                {
                    Console.WriteLine(a - b);
                }
                if (xui == '*')
                {
                    Console.WriteLine(a * b);
                }
                if (xui == '/' )
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Нельзя делить на ноль!");
                        continue;
                    }
                    Console.WriteLine(a / b);
                }
                if (xui == '^')
                {
                    Console.WriteLine(Math.Pow(a, b));
                }
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
                continue;
            }
        }
    }
}