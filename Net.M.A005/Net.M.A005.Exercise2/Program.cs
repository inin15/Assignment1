﻿namespace Net.M.A005.Exercise2
{
    internal class Program
    {
        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
        public static void Main()
        {
            Console.Write("\n\nFunction : To display the n number Fibonacci series :\n");
            Console.Write("------------------------------------------------------------\n");
            Console.Write("Input number of Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Fibonacci series of " + n + " numbers is :");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Fibo(i) + "  ");
            }
            Console.WriteLine();
        }
    }
}