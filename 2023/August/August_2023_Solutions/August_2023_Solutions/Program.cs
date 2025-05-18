namespace zad25
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string data = Console.ReadLine();
                int number = int.Parse(data);

                for (int i = 0; i < data.Length / 2; i++)
                {
                    if (data[i] != data[data.Length - i - 1])
                    {
                        Console.WriteLine($"{data} is NOT a palindrome");
                        return;
                    }
                }
                Console.WriteLine($"{data} is a palindrome");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrectly entered number");
                return;
            }
        }
    }
}
