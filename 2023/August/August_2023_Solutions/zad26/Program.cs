using System.Globalization;

namespace zad26
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> validPoints = ReadPoints();

            Console.WriteLine($"valid works - {validPoints.Count}");
            Console.WriteLine($"minimal difference - {MinDpoints(validPoints):F3} p.");
            Console.WriteLine($"laureates - {Laureates(validPoints)}");
        }

        static List<double> ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            List<double> result = new List<double>();

            for (int i = 0; i < n; i++)
            {
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                {
                    if (value > 0)
                    {
                        result.Add(value);
                    }
                }
            }

            return result;
        }

        static double MinDpoints(List<double> points)
        {
            var distinct = points.Distinct().OrderBy(x => x).ToList();
            double minDiff = double.MaxValue;

            for (int i = 1; i < distinct.Count; i++)
            {
                double diff = distinct[i] - distinct[i - 1];
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            return minDiff;
        }

        static int Laureates(List<double> points)
        {
            var topThreeThreshold = points
                .OrderByDescending(x => x)
                .Distinct()
                .Take(3)
                .Min();

            return points.Count(x => x >= topThreeThreshold);
        }
    }
}


