namespace _19._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomi = new List<string> { "Mike", "Bob", "Charlie", "Luck", "Emily", "Frank" };
            int n;
            do
            {
                Console.WriteLine("inserici il numero della posizione (non deve essere < 0 || > 6)");


            }
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 6);

            Console.WriteLine(nomi[n - 1]);
        }
    }
}
