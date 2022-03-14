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
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int k = 1; k <= num; k++)
            {
                Console.WriteLine("n*" + k);
            }
            Console.WriteLine("");
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.Write(a + "*" + b + "=" + a * b + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}