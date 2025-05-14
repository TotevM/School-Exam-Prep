namespace zad26
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] profits = new int[n];

            for (int i = 0; i < n; i++)
            {
                profits[i] = int.Parse(input[i]);
            }

            int maxLen = 1;
            int currentLen = 1;

            for (int i = 1; i < n; i++)
            {
                if (profits[i] >= profits[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                    }
                }
                else
                {
                    currentLen = 1;
                }
            }

            int minIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (profits[i] < profits[minIndex])
                {
                    minIndex = i;
                }
            }

            int compareIndex = (minIndex == n - 1) ? minIndex - 1 : minIndex + 1;
            double percentDiff = ((double)(profits[compareIndex] - profits[minIndex]) / profits[compareIndex]) * 100;

            Console.WriteLine($"Longest period with bigger profit is {maxLen} months.");
            Console.WriteLine($"Smaller with {percentDiff:F2}%");
        }
    }
}
