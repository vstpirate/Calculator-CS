using System;

namespace CalculatorCS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Calculator-CS ===");
            while (true)
            {
                Console.Write("Primul numar: ");
                string? text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text)) break;
                if (!double.TryParse(text, out double a)) { Console.WriteLine("Numar invalid!\n"); continue; }

                Console.Write("Operatia (+, -, *, /): ");
                string? op = Console.ReadLine()?.Trim();

                Console.Write("Al doilea numar: ");
                if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Numar invalid!\n"); continue; }

                double r;
                switch (op)
                {
                    case "+": r = a + b; break;
                    case "-": r = a - b; break;
                    default: Console.WriteLine("Operatie necunoscuta!\n"); continue;
                }
                Console.WriteLine($"Rezultat: {a} {op} {b} = {r}\n");
            }
        }
    }
}
