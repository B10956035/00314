using System;

namespace B10956035
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            string[] name = { "jack", "marry", "tom", "grace", "alice" };
            int[] ascore = { 80, 65, 100, 98, 83 };
            int[] bscore = { 75, 67, 93, 25, 82 };
            int[] cscore = { 60, 62, 91, 50, 87 };
            Console.WriteLine("輸入座號1-5:");
            string input = Console.ReadLine();
            int input_num = Int32.Parse(input);
            int arrayIndex = Array.IndexOf(num, input_num);
            if (arrayIndex > -1)
            {
                Console.WriteLine("座號：" + num[arrayIndex]);
                Console.WriteLine("姓名：" + name[arrayIndex]);
                Console.WriteLine("電腦概論：" + ascore[arrayIndex]);
                Console.WriteLine("程式設計：" + bscore[arrayIndex]);
                Console.WriteLine("動畫設計：" + cscore[arrayIndex]);
            }
            else
            {
                Console.WriteLine("超出座號範圍");
            }
            Console.WriteLine();
        }
    }
}