namespace zad25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                string nInput = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(nInput))
                {
                    throw new ArgumentNullException();
                }
                int n = int.Parse(nInput);

                if (n <= 0)
                {
                    throw new ArgumentException("Въведи положително цяло число");
                }

                for (int i = 0; i < n; i++)
                {
                    string input = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentNullException();
                    }
                    int num = int.Parse(input);
                    if (num <= 0)
                    {
                        throw new ArgumentException("Въведи положително цяло число");
                    }

                    if (dictionary.ContainsKey(num))
                    {
                        dictionary[num]++;
                    }
                    else
                    {
                        dictionary[num] = 1;
                    }
                }

                foreach (var pair in dictionary)
                {
                    Console.WriteLine($"Число: {pair.Key}, брой: {pair.Value}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Моля, въведете валидно цяло число.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Моля, въведете валидно цяло число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Грешка: " + ex.Message);
            }
        }
    }
}
