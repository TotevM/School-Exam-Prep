namespace zad28
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<Furniture> furnitures = new List<Furniture>();
                var input = Console.ReadLine().Split(' ').ToList();
                while (input[0] != "END")
                {
                    if (input[0] == "table")
                    {
                        Table table = new Table(input[0],
                        double.Parse(input[1]));
                        furnitures.Add(table);
                    }
                    if (input[0] == "cabinet")
                    {
                        Cabinet cabinet = new Cabinet(input[0],
                        double.Parse(input[1]), int.Parse(input[2]));
                        furnitures.Add(cabinet);
                    }
                    input = Console.ReadLine().Split(' ').ToList();
                }
                Console.WriteLine("All tables:");
                foreach (Furniture furniture in furnitures)
                {
                    if (furniture is Table)
                        Console.WriteLine(furniture.ToString());
                }
                Console.WriteLine("All cabinets:");
                foreach (Furniture furniture in furnitures)
                {
                    if (furniture is Cabinet)
                        Console.WriteLine(furniture.ToString());
                }
            }
        }
    }
}
