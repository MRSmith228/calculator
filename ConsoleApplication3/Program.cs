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
            char xui = input[x];
            string c = input.Substring(0,x);
            string d = input.Substring(x + 1, input.Length - x - 1);
            if (double.TryParse(c, out double a) & double.TryParse(d, out double b))
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
