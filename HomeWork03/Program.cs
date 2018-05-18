using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目：迴圈倒置 #2");
            Console.Write("輸入一個整數數字：");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            for (int i = value; i > 0; i--)
            {
                Console.WriteLine("");//要換行

                for (int j = value; j >= i; j--)
                {
                    Console.Write(i);
                }
            }

            Console.ReadLine();
        }

    }
}
