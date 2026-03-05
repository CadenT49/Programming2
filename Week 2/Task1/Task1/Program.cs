namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> progLangsOne = new List<string> { "C#", "JavaScript", "Kotlin", "Python" };
            List<string> progLangsTwo = new List<string> { "C++", "Go", "Swift", "TypeScript" };

            List<string> allProgLangs = new List<string>();

            allProgLangs.AddRange(progLangsOne);
            allProgLangs.AddRange(progLangsTwo);

            allProgLangs.Add("Rust");
            allProgLangs.Remove("Swift");

            foreach (string s in allProgLangs)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
