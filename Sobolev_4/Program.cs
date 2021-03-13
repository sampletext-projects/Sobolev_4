using System;

namespace Sobolev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("z=");
            double z = double.Parse(Console.ReadLine());

            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());

            double S = 0;
            int key = 0;

            for (int i = 1; i <= n; i++)
            {

                S += (Math.Cos(Math.Pow(z, 2 * i)) + a) / Math.Sqrt(Math.Tan(Math.Pow(z, i)) + Math.Cos(Math.Pow(z, key)));
                key--;
            }
            Console.WriteLine("Result=" + S);
        }
    }
}
