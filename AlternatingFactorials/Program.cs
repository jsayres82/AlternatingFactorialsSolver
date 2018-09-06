using System;

namespace AlternatingFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 

                Console.WriteLine();
                Console.WriteLine("Enter a number to calculate alternating factorial for:  ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Alternating Factorial for {0} = {1}", n, AlternatingFactorialsSolver(n));
            }
        }

        public static int AlternatingFactorialsSolver(int n)
        {
            int sum = 0;
            int negTracker;

            if (n % 2 == 1)
                negTracker = -1;
            else
                negTracker = 1;

            for (int i = 1; i <= n; i++)
            {
                negTracker *= -1;
                sum += RecursiveFactorialSolver(i) * negTracker;
            }

            return sum;
        }

        public static int RecursiveFactorialSolver(int n)
        {
            if (n > 1)
                return n * RecursiveFactorialSolver(n - 1);
            else
                return 1;
        }

    }
}
