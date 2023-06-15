namespace Net.M.A006.Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new int[6] { 5, 8, 12, -10, 6, 4 };
            int i, max, min, n;
            //// size of the array
            n = 6;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum is: {0}", max);

            Console.Write("Minimum is: {0} ", min);
        }
    }
}