using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目：奇偶數判斷 #1");
            Console.Write("請輸入一個數字：");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            if (value % 2 == 0)
            {
                Console.WriteLine("輸入的數字是「偶數」");
            }
            else 
            {
                Console.WriteLine("輸入的數字是「奇數」");
            }

            Console.ReadLine();
        }
    }
}
