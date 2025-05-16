namespace zad26
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Dictionary<int, int> digitCounts = new Dictionary<int, int>();

            for (int i = 0; i <= 9; i++)
            {
                digitCounts[i] = 0;
            }

            for (int i = a; i <= b; i++)
            {
                int number = i;
                while (number > 0)
                {
                    int digit = number % 10;
                    digitCounts[digit]++;
                    number /= 10;
                }
            }

            int maxDigit = 0;
            int maxCount = 0;

            foreach (var pair in digitCounts)
            {
                if (pair.Value > maxCount || (pair.Value == maxCount && pair.Key < maxDigit))
                {
                    maxDigit = pair.Key;
                    maxCount = pair.Value;
                }
            }

            Console.WriteLine($"Digit {maxDigit} - {maxCount} times");
        }
    }
}

