namespace zad25
{
    class zad25
    {
        static void Main()
        {
            try
            {
                string inputA = Console.ReadLine();
                string inputB = Console.ReadLine();

                if (!int.TryParse(inputA, out int a) || !int.TryParse(inputB, out int b))
                {
                    Console.WriteLine("Некоректно въведено число");
                    return;
                }

                if (a == 0)
                {
                    if (b > 0)
                    {
                        Console.WriteLine("Всички реални числа са решения");
                    }
                    else
                    {
                        Console.WriteLine("Няма реални решения");
                    }
                    return;
                }

                double D = (double)b / a;

                if (D < 0)
                {
                    Console.WriteLine("Няма реални решения");
                    return;
                }

                double sqrtD = Math.Sqrt(D);

                if (a > 0)
                {
                    Console.WriteLine($"Решенията са (-{sqrtD:F2}; {sqrtD:F2})");
                }
                else // a < 0
                {
                    Console.WriteLine($"Решенията са (-inf; -{sqrtD:F2}) U ({sqrtD:F2}; +inf)");
                }
            }
            catch
            {
                Console.WriteLine("Некоректно въведено число");
            }
        }
    }
}
