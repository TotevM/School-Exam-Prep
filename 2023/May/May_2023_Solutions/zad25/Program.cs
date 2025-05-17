namespace zad25
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine()!.TrimStart('-'); ;
                int number = int.Parse(input);

                for (int i = 0; i < input.Length; i++)
                {
                    int digit = int.Parse(input[i].ToString());

                    if (digit == 0 || number % digit != 0)
                    {
                        Console.Write("No");
                        return;
                    }
                }
                Console.Write("Yes");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }

        }
    }
}
