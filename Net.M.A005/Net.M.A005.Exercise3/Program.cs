namespace Net.M.A005.Exercise3
{
    internal class Program
    {
        public static bool CheckPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Main(string[] args)
        {
            Console.Write("n=");
            int.TryParse(Console.ReadLine(), out int n);
            if (CheckPrimeNumber(n))
            {
                Console.WriteLine($"{n} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine($"{n} is not a Prime Number", n);
            }
        }
    }
}