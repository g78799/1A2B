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
            while (true) 
            {
                Console.WriteLine("歡迎來到1A2B猜數字遊戲");

                int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                int tp = 0;
                Random rnd = new Random();

                for (int i = 0; i < ints.Length; i++)
                {
                    int n = rnd.Next(ints.Length);
                    tp = ints[i];
                    ints[i] = ints[n];
                    ints[n] = tp;
                }



                Console.WriteLine($"{ints[0]},{ints[1]},{ints[2]},{ints[3]}");
                while (true)
                {

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
                        else
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (enter[j] == ints[i])
                                {
                                    b++;
                                }
                            }
                        }

                    }

                    Console.WriteLine($"判定結果是{a}A,{b}");

                    if (a == 4)
                    {
                        Console.WriteLine("恭喜你猜對了");
                        Console.WriteLine("你還要繼續玩嗎?(y/n)");

                        

                    }

                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }


                }
            }

            

            


            Console.ReadLine();




        }
    }
}
