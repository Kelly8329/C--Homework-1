using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目：字串替換");
            Console.WriteLine("請輸入四位數的阿拉伯數字");
            Console.Write("輸入 ");
            string input = Console.ReadLine();
            char[] arychar = input.ToCharArray();//將輸入的字串存入陣列

            if (arychar.Length == 4)
            {
                Console.Write("顯示 ");
                for (int i = 0; i < arychar.Length; i++)
                {
                    switch (arychar[i])
                    {
                        case '0':
                            Console.Write("零");
                            break;
                        case '1':
                            Console.Write("一");
                            break;
                        case '2':
                            Console.Write("二");
                            break;
                        case '3':
                            Console.Write("三");
                            break;
                        case '4':
                            Console.Write("四");
                            break;
                        case '5':
                            Console.Write("五");
                            break;
                        case '6':
                            Console.Write("六");
                            break;
                        case '7':
                            Console.Write("七");
                            break;
                        case '8':
                            Console.Write("八");
                            break;
                        case '9':
                            Console.Write("九");
                            break;
                    }
                }
            }
            else if (arychar.Length > 4)
            {
                Console.Write("你輸入的字串大於四位數");
            }
            else
            {
                Console.Write("你輸入的字串小於四位數");
            }
            Console.ReadLine();
        }
    }
}
