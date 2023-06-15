namespace Net.M.A006.Exercise3
{
    internal class Program
    {
        // Function to return gcd of a and b
        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }

        // Recursive Implementation
        public static int FindGCD(int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result = GCD(result, nums[i]);
            }
            return result;
        }

        private static void Main(string[] args)
        {
            int[] nums = { 12, 18, 24 };
            int gcd = FindGCD(nums);
            Console.Write("Greatest common divisor of [");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ",");
            }
            Console.Write("] is:" + gcd);
            Console.WriteLine();
        }
    }
}