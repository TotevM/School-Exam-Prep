namespace zad28
{
    class KinderGarden
    {
        private List<Kid> kidList;
        public KinderGarden()
        {
            kidList = new List<Kid>();
        }
        public void EnrollKid(Kid kid)
        {
            kidList.Add(kid);
            Console.WriteLine($"The child {kid.FirstName} {kid.LastName} is enrolled.");
        }
        public void ReleaseKid(string id)
        {
            Kid kid = kidList.Find(k => k.ID == id);
            if (kid != null)
            {
                kidList.Remove(kid);
                Console.WriteLine($"The child {kid.FirstName} {kid.LastName} has been unsubscribed.");
            }
            else Console.WriteLine($"Unsubscribe failed - invalid identifier {id}.");
        }
        public void GroupInfo(string group)
        {
            int count = kidList.Count(k => k.Group == group);
            Console.WriteLine($"{group} group - {count} children");
            foreach (var kid in kidList.OrderBy(k => k.FirstName).ThenBy(k =>
           k.LastName))
            {
                if (kid.Group == group)
                {
                    Console.WriteLine(kid);
                }
            }
        }
    }
}
