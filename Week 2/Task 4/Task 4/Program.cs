namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 7, 8, 11, 12, 15, 16, 19, 20 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            int total = evenNumbers.Sum();
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
