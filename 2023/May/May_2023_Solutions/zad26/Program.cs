namespace zad26
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Add":
                        foreach (var item in commands.Skip(1))
                        {
                            list.Add(item);
                        }
                        break;

                    case "Remove":
                        int index;
                        if (int.TryParse(commands[1], out index) && index >= 0 && index < list.Count)
                        {
                            list.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Search":
                        if (list.Contains(commands[1]))
                        {
                            Console.WriteLine(commands[1]);
                        }
                        else
                        {
                            Console.WriteLine("Not contained.");
                        }
                        break;

                    case "Update":
                        for (int i = 0; i < list.Count; i++)
                        {
                            var word = list[i];
                            if (char.IsLetter(word[0]))
                            {
                                list[i] = char.ToUpper(word[0]) + word.Substring(1);
                            }
                        }
                        break;

                    case "Length":
                        if (int.TryParse(commands[1], out int length))
                        {
                            var result = list.Where(x => x.Length == length).ToList();
                            if (result.Any())
                            {
                                Console.WriteLine(string.Join('-', result));
                            }
                            else
                            {
                                Console.WriteLine("Not contained.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid length value");
                        }
                        break;

                    case "Insert":
                        try
                        {
                            int pos = int.Parse(commands[1]);
                            string word = commands[2];
                            list.Insert(pos, word);
                        }
                        catch
                        {
                            Console.WriteLine("There are not enough items in the list.");
                        }
                        break;

                    case "Print":
                        Console.WriteLine(string.Join("; ", list));
                        break;

                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}
