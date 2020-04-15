using System;

namespace Logic1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();
            Console.WriteLine("Enter Size of Array:\n");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] myNum = new int[num];
            Console.WriteLine("Enter the Sum Number that is to be Matched:\n");
            int snumber = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter Elements into Array:\n");
            for (int a = 0; a < num; a++)
            {
                myNum[a] = Convert.ToInt32(Console.ReadLine());
            }
            watch.Start();
            for (int i = 0; i < myNum.Length; i++)
            {
                for (int j = i + 1; j < myNum.Length; j++)
                {

                    if (myNum[i] + myNum[j] == snumber)
                    {
                        Console.WriteLine("The Match is found at Index:" + i + "&" + j + "(" + myNum[i] + "+" + myNum[j] + ")");
                    }

                }
            }
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
