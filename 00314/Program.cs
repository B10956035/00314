using System;

namespace _20220307
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int a = (int)meal_cost;
            int b = a + tax_percent + tip_percent;
            Console.WriteLine(b);
        }
    }
}