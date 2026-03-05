namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int> { 78, 89, 92, 65, 70, 85, 92, 78, 93, 80 };

            var max = scores.Max();

            Console.WriteLine(max);


           Console.ReadLine();
        }
    }
}
