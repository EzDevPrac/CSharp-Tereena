using System;

namespace PuzzleInFacadePattern
{

    public class Logic1Provider
    {
        public void GetLogic1(int[] myNum, int snumber)
        {
            for (int i = 0; i < myNum.Length; i++)
            {
                for (int j = i + 1; j < myNum.Length; j++)
                {
                    if (myNum[i] + myNum[j] == snumber)
                    {
                        Console.WriteLine("Match found at" + i + " " + j);
                    }
                }
            }
        }
    }

    public class Logic2Provider
    {
        public void GetLogic2(int[] myNum, int snumber)
        {
            Array.Sort(myNum);

            int low = 0;
            int high = myNum.Length - 1;

            while (low < high)
            {
                if (myNum[low] + myNum[high] == snumber)
                {
                    Console.WriteLine("Sum found at" + low + "and" + high);
                    low++;

                }
                else if (myNum[low] + myNum[high] < snumber)
                {
                    low = low + 1;
                }
                else
                {
                    high = high - 1;
                }
            }
        }
    }

    public class PuzzleFacade
    {
        public void GetLogic1(int[] myNum, int snumber)
        {
            Logic1Provider logic1provider = new Logic1Provider();
            logic1provider.GetLogic1(myNum, snumber);

        }
        public void GetLogic2(int[] myNum, int snumber)
        {
            Logic2Provider logic2provider = new Logic2Provider();
            logic2provider.GetLogic2(myNum, snumber);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the no of elements in the array");
            int num = Convert.ToInt16(Console.ReadLine());
            int[] myNum = new int[num];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < num; i++)
            {
                myNum[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter the sum of the number to be found");
            int snumber = Convert.ToInt16(Console.ReadLine());



            var facadeforclient = new PuzzleFacade();
            Console.WriteLine("..........Output for Logic1.........");
            facadeforclient.GetLogic1(myNum, snumber);
            Console.WriteLine("..........Output for Logic2.........");
            facadeforclient.GetLogic2(myNum, snumber);
        }
    }
}
