namespace zad26
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Human> lstHuman = new List<Human>();
            string firstName, lastname;
            int age;
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                Console.Write("First name: ");
                firstName = Console.ReadLine()!;
                Console.Write("Last name: ");
                lastname = Console.ReadLine()!;
                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Your choice[s - student] , [w - worker]: ");
                string choice = Console.ReadLine()!;
                if (choice == "s")
                {
                    Console.Write("Grade: ");
                    double mark = double.Parse(Console.ReadLine());
                    lstHuman.Add(new Student(firstName, lastname, age, mark));
                }
                else if (choice == "w")
                {
                    Console.Write("Wage: ");
                    double wage = double.Parse(Console.ReadLine()!);
                    Console.Write("Hours worked: ");
                    double workHours = double.Parse(Console.ReadLine()!);
                    lstHuman.Add(new Worker(firstName, lastname, age, wage, workHours));
                }
            }
            for (int i = lstHuman.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(lstHuman[i]);
            }
        }
    }
}
