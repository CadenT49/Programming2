namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 16; num += 2)
            {
                string result = FizzBuzz(num);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
        
        public static string FizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return string.Empty;
            }

        }
        
    }
}
