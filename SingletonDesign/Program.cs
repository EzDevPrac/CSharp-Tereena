using System;

namespace NoThreadSafeSingletonDesign
{
    class Program
    {
        //No Thread-Safe Singleton Design Pattern implementation
        static void Main(string[] args)
        {
             Singleton fromTeachaer = Singleton.GetInstance;
             string str1=fromTeachaer.PrintDetails("From Teacher");
             Console.WriteLine(str1);

             //or we can do like this
             //Console.WriteLine(Singleton.GetInstance.PrintDetails("From Teacher"));


             //Singleton fromStudent = Singleton.GetInstance;
            //string str2=fromStudent.PrintDetails("From Student");
            //Console.WriteLine(str2);
            Console.WriteLine(Singleton.GetInstance.PrintDetails("From Student"));

        }
    }
        public sealed class Singleton
        {
            private static int counter = 0;
            private static Singleton instance = null;
            public static Singleton GetInstance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();
                    return instance;
                }
            }

            private Singleton()
            {
                counter++;
                Console.WriteLine("Counter Value " + counter);
            }

            public string PrintDetails(string message)
            {
               //Console.WriteLine(message);
               return message;
               
            }
        }
    }

