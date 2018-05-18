using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目：迴圈倒置 #1");
            Console.WriteLine("輸入一串以逗號分隔的字串，並將其反向顯示");
            Console.Write("輸入：");
            string input = Console.ReadLine();
            char [] Arraystring = input.ToCharArray();//將輸入的數字存入Arraystring字串內
            Array.Reverse(Arraystring);//將字串排序，反轉Array內項目順序
            Console.Write("結果：");
            for (int i = 0; i < Arraystring.Length; i++)
            {
                Console.Write(Arraystring[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
