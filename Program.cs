using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            if (args.Length == 3)
            {
                if ((int.TryParse(args[0], out int value1)) && (int.TryParse(args[2], out int value2)))
                {
                    switch (args[1])
                    {
                        case "+":
                            result = value1 + value2;
                            break;

                        case "-":
                            result = value1 - value2;
                            break;

                        case "/":
                            result = value1 / value2;
                            break;

                        case "*":
                            result = value1 * value2;
                            break;

                        default:
                            Console.WriteLine("Вы указали некорректный знак, попробуйте ещё раз.");
                            break;
                    }
                    Console.WriteLine($"Результат = {result}");
                }
            }
            else
            {
                Console.WriteLine("Введите число, знак (+ или - или / или *) и ещё одно число.");
            }

        }
    }
}
