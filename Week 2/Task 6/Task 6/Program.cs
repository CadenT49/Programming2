namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> temperatures = new List<double> { 24.5, 23.8, 25.3, 22.6, 26.1, 27.5, 21.9 };

            var average = temperatures .Average();

            Console.WriteLine($"{average:f2}");

            var max = temperatures .Max();

            Console.WriteLine(max);

            List<double> over25 = temperatures
                .Where (temp => temp > 25)
                .ToList();

            foreach (var temp in over25)
            {
                Console.WriteLine(temp);
            }

            Console.ReadLine();
        }
    }
}
