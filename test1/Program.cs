using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到1A2B猜數字遊戲");

            int[] ans = new int[4];
            Random rnd = new Random();

             ans[0] = rnd.Next(0, 10);
             ans[1] = rnd.Next(0, 10);
             ans[2] = rnd.Next(0, 10);
             ans[3] = rnd.Next(0, 10);

            for(int i = 0;i<4;i++)
            {
               for(int j=0;j<i;j++)
                {
                    while (ans[j] == ans[i])
                    {
                        ans[j]=rnd.Next(10);
                    }
                }
            }
            Console.WriteLine($"{ans[0]},{ans[1]},{ans[2]},{ans[3]}");
            Console.ReadLine();



        }
    }
}
