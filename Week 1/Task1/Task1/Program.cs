namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0, average = 0;
            int count = 6;
            double[] numbers = {45.3, 67.5, -45.6, 20.34, -33.0, 45.6 };
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            average = total / count;
            Console.WriteLine($"the average is {average:F2}");

            Console.ReadLine();
        }
    }
}
