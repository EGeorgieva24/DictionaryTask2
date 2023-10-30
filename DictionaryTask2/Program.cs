class Program
{
    static void Main()
    {
        // Create dictionaries representing courses and their credit hours
        Dictionary<string, int> courseCredits = new Dictionary<string, int>();


        courseCredits.Add("Physics", 6);
        courseCredits.Add("Math", 8);
        courseCredits.Add("Informatics", 5);
        courseCredits.Add("English", 3);

        Dictionary<string, List<string>> studentCourses = new Dictionary<string, List<string>>();

        studentCourses.Add("Stan", new List<string> { "Math", "English" });
        studentCourses.Add("Eli", new List<string> { "Math", "Physics" });
        studentCourses.Add("Tori", new List<string> { "Informatics", "English" });

        Dictionary<string, int> totalCreds = new Dictionary<string, int>();

        foreach (var s in studentCourses.Keys)
        {

            int count = 0;
            foreach (var c in studentCourses[s])
            {
                if (courseCredits.ContainsKey(c))
                {
                    count += courseCredits[c];
                }
            }
            totalCreds[s] = count;
        }

        foreach (var s in totalCreds)
        {
            Console.WriteLine($"{s.Key}, {s.Value} credit hours");
        }
    }
}
