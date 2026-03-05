namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bookTitles = new List<string> { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Brave New World" };

            int totalBooks = bookTitles.Count;
            
            Console.WriteLine(totalBooks);

            bool hasBraveNewWorldId = bookTitles.Contains("Brave New World");

            Console.WriteLine(hasBraveNewWorldId);

            int index1984 = bookTitles.IndexOf("1984");
            
            Console.WriteLine(index1984);

            bookTitles.Clear();

            totalBooks = bookTitles.Count;

            Console.WriteLine(totalBooks);

            Console.ReadLine();
        }
    }
}
