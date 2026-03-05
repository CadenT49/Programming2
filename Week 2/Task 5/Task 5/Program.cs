namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>
            {
                "Argentina", "Australia", "Brazil", "Canada", "Egypt",
                "France", "India", "Italy", "Mexico", "Netherlands",
                "South Africa", "United States"
            };

            var startsWithI = countries.Where(country => country.StartsWith("I", StringComparison.OrdinalIgnoreCase));

            foreach (var country in startsWithI)
            {
                Console.WriteLine(country);
            }

            Console.ReadLine();
        }
    }
}
