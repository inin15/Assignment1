namespace Net.M.A006.Exercise2
{
    internal class Program
    {
        // Function to return findgcd of x and y
        public static int FindGCD(int x, int y)
        {
            if (y == 0)
                return x;
            return FindGCD(y, x % y);
        }

        private static void Main(string[] args)
        {
            Console.Write("x=");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write("y=");
            int.TryParse(Console.ReadLine(), out int y);
            Console.WriteLine("Greatest common divisor of " + x + " and " + y + " is: " + FindGCD(x, y));
        }
    }
}