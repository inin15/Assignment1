namespace Net.M.A004
{
    internal class Program
    {
        private int x = 1;

        private static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine($"x = {a.x}");
            Console.WriteLine($"y = {a.Calculate()}");
        }

        public int Calculate()
        {
            return (2 * x * x * x - 6 * x * x + 2 * x - 1);
        }
    }
}