namespace zad28
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                KinderGarden kinderGarden = new KinderGarden();
                string cmd;
                while ((cmd = reader.ReadLine()) != "END")
                {
                    string[] cmdArgs = cmd.Split();
                    Kid kid;
                    switch (cmdArgs[0])
                    {
                        case "enrollment":
                            try
                            {
                                kid = new Kid(cmdArgs[1], cmdArgs[2],
                               cmdArgs[3], int.Parse(cmdArgs[4]), cmdArgs[5], cmdArgs[6]);
                                kinderGarden.EnrollKid(kid);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "unsubscribe":
                            kinderGarden.ReleaseKid(cmdArgs[1]);
                            break;
                        case "information":
                            kinderGarden.GroupInfo(cmdArgs[1]);
                            break;
                        default:
                            Console.WriteLine($"{cmdArgs[0]} - invalid command");
                            break;
                    }
                }
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}

