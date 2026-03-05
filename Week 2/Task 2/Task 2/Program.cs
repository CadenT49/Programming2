namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 65, 35, 79, 101, 35 };

            nums.Insert(1, 25);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            bool hasNumber35 = nums.Contains(35);
            Console.WriteLine(hasNumber35);

            int firstNumberGreaterThan30 = nums.Find(i => i > 30);

            Console.WriteLine(firstNumberGreaterThan30);

            nums.Sort();

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
