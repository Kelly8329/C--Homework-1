using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目：奇偶數判斷 #2");
            Console.WriteLine("輸入一串以逗號分隔的字串");
            Console.Write("輸入：");
            string input = Console.ReadLine();//讀取輸入的字串
          
            string[] arr = input.Split(',');//宣告一個arr字串陣列，並存入剛剛讀取的字串，並用"，"分開，所以這個陣列中沒有"，"
            int[] data = new int[arr.Length];//宣告一個data整數陣列，這個陣列的長度要跟arr陣列一樣，目的是為了接收輸入的數字

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = int.Parse(arr[i]);//將input的內容一個一個拿出來強制轉成int
                data[i] = temp;
            }

            Array.Sort(data);//將數字排序

            Console.WriteLine("--------------");

            var odd = data.Where((x) => x % 2 != 0);//判斷奇數
            Console.Write("奇數：");         
            string tmpStrodd = string.Join(",", odd);
            Console.WriteLine(tmpStrodd);

            var even = data.Where((x) => x % 2 == 0);//判斷偶數
            Console.Write("偶數：");         
            string tmpStreven = string.Join(",", even);
            Console.WriteLine(tmpStreven);
      
            Console.ReadLine();
        }

    }
}
