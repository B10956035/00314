using System;

namespace B10956035
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("輸入數字");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine("odd Weird");
            }
            else if (num < 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (num <= 20)
            {
                Console.WriteLine("even Weird");
            }
            else
            {
                Console.WriteLine("over Weird");
            }
        }
    }
}