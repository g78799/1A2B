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

            int[] ints = new int []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int tp = 0;
            Random rnd = new Random();

            for (int i = 0; i<ints.Length; i++)
            {
                int n = rnd.Next(ints.Length); 
                tp = ints[i];
                ints[i] = ints[n];
                ints[n] = tp;
            }



            Console.WriteLine($"{ints[0]},{ints[1]},{ints[2]},{ints[3]}");
            Console.WriteLine("請輸入數字");

            int[] enter = new int[4];
            int a = 0, b = 0;
            string c = Console.ReadLine();

            
                for (int i = 0; i < 4; i++)
                {
                    enter[i] = Convert.ToInt32(c[i].ToString());
                }




                for (int i = 0; i < 4; i++)
                {
                    if (enter[i] == ints[i])
                    {
                        a++;
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (enter[j] == ints[i])
                        {
                          b++;
                        }
                    }
                }


                b -= a;

                

                Console.WriteLine($"{a}A,{b}B");
            

            

            if (a==4)
            {
                Console.WriteLine("答案正確");
            }

            

            


            Console.ReadLine();




        }
    }
}
