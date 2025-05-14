namespace zad28
{
    public class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    List<ClubMember> members = new List<ClubMember>();

            //    foreach (var line in File.ReadAllLines("input.txt"))
            //    {
            //        var tokens = line.Split(';');
            //        string type = tokens[0];

            //        if (type == "Coach")
            //        {
            //            var coach = new Coach(
            //                double.Parse(tokens[3]),
            //                int.Parse(tokens[4]),
            //                tokens[1],
            //                tokens[2],
            //                tokens[5],
            //                int.Parse(tokens[6])
            //            );
            //            members.Add(coach);
            //        }
            //        else if (type == "FootballPlayer")
            //        {
            //            var player = new FootballPlayer(
            //                tokens[1],
            //                tokens[2],
            //                double.Parse(tokens[3]),
            //                int.Parse(tokens[4]),
            //                tokens[5],
            //                int.Parse(tokens[6]),
            //                int.Parse(tokens[7]),
            //                int.Parse(tokens[8]),
            //                int.Parse(tokens[9])
            //            );
            //            members.Add(player);
            //        }
            //        else if (type == "Director")
            //        {
            //            var director = new Director(
            //                tokens[5],
            //                double.Parse(tokens[3]),
            //                int.Parse(tokens[4]),
            //                tokens[2],
            //                tokens[1]
            //            );
            //            members.Add(director);
            //        }
            //    }

            //    var sorted = members.OrderBy(m => m.Age).ToList();

            //    foreach (var member in sorted)
            //    {
            //        member.Info();
            //        Console.WriteLine(new string('*', 20));
            //    }

            //    var topSalary = members.OrderByDescending(m => m.Salary).First();
            //    Console.WriteLine($"The person with the highest salary in the club is {topSalary.FirstName} {topSalary.LastName} with {topSalary.Salary:F2} lv salary.");

            //    var topScorer = members
            //        .OfType<FootballPlayer>()
            //        .OrderByDescending(p => p.Goals)
            //        .FirstOrDefault();

            //    if (topScorer != null)
            //    {
            //        Console.WriteLine($"The team's top scorer is {topScorer.FirstName} {topScorer.LastName} with {topScorer.Goals} goals.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            var clubMembers = new List<ClubMember>();
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string input;
                while ((input = reader.ReadLine()) != null)
                {
                    string[] line = input.Split(' ');
                    int len = line.Length;
                    switch (len)
                    {
                        case 9:
                            try
                            {
                                FootballPlayer newPlayer = new
                               FootballPlayer(line[0], line[1],
                               double.Parse(line[3]),
                                int.Parse(line[2]),
                               line[4],
                               int.Parse(line[5]),
                               int.Parse(line[6]),
                               int.Parse(line[7]),
                               int.Parse(line[8]));
                                clubMembers.Add(newPlayer);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 6:
                            try
                            {
                                Coach coach = new Coach(double.Parse(line[3]),
                               int.Parse(line[2]),
                                line[0], line[1], line[4],
                               int.Parse(line[5]));
                                clubMembers.Add(coach);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 5:
                            try
                            {
                                Director dirctor = new Director(line[0], double.Parse(line[3]),
                                    int.Parse(line[2]),
                               line[1], line[4]);
                                clubMembers.Add(dirctor);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                    }
                }
            }
            clubMembers.Sort((x, y) => x.Age.CompareTo(y.Age));
            foreach (ClubMember member in clubMembers)
            {
                member.Info();
                Console.WriteLine("********************");
            }
            double maxSalary = clubMembers.Max(cm => cm.Salary);
            ClubMember memberMaxSalery = clubMembers.FirstOrDefault(cm =>
           cm.Salary == maxSalary); ;
            Console.WriteLine($"The person with the highest salary in the club is {memberMaxSalery.FirstName}");
            Console.WriteLine($"{memberMaxSalery.LastName} with {memberMaxSalery.Salary:f2} lv salary.");

            FootballPlayer goalMaster = clubMembers
            .Where(x => x.GetType() == typeof(FootballPlayer))
            .Select(x => x as FootballPlayer)
            .OrderByDescending(x => x.Goals)
            .FirstOrDefault();
            Console.WriteLine($"The team's top scorer is {goalMaster.FirstName}" + $"{goalMaster.LastName} with {goalMaster.Goals} goals.");
        }
    }

}


