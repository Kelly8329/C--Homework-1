using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目：閏年");
            Console.Write("請輸入一個中華民國年份：");
            string input = Console.ReadLine();
            int year = int.Parse(input)+1911;

            if (DateTime.IsLeapYear(year))
            { 
                Console.WriteLine(year-1911 + "是閏年");
            }
            else
            {
                Console.WriteLine(year-1911 + "不是閏年");
            }
            Console.ReadLine();
        }
    }
}
