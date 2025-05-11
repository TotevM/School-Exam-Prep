using System;
using System.Globalization;

namespace zad26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemList itemList = new ItemList();

            Console.Write("Въведете брой стоки: ");
            int n;

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        throw new ArgumentNullException("Броят не може да бъде празен.");

                    n = int.Parse(input);
                    if (n <= 0)
                        throw new ArgumentException("Броят трябва да бъде положително число.");

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Грешка: " + ex.Message);
                    Console.Write("Опитайте отново: ");
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВъведете информация за стока {i + 1}:");

                while (true)
                {
                    try
                    {
                        Console.Write("Описание: ");
                        string description = Console.ReadLine();

                        Console.Write("Цена: ");
                        string priceInput = Console.ReadLine();
                        double price = double.Parse(priceInput, CultureInfo.InvariantCulture);

                        Item item = new Item(price, description);
                        itemList.Add(item);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Грешка: Невалиден формат за цена. Опитайте отново.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Грешка: " + ex.Message);
                    }
                }
            }

            Console.WriteLine("\nСъдържание на списъка със стоки:");
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine(itemList.Get(i));
            }
        }
    }
}
