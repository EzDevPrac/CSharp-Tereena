using System;

namespace StrategyDesign
{

    public interface ICalculateInterface
    {
        //define method  
         int Calculate(int value1, int value2);
    }

    public class Minus : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            //define logic  
            return value1 - value2;
        }
    }

    public class Plus : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            //define logic  
            return value1 + value2;
        }
    }

    public class CalculateClient
    {
        private ICalculateInterface calculateInterface;

        //Constructor: assigns strategy to interface  
        public CalculateClient(ICalculateInterface strategy)
        {
            calculateInterface = strategy;
        }

        //Executes the strategy  
        public int Calculate(int value1, int value2)
        {
            return calculateInterface.Calculate(value1, value2);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculateClient minusClient = new CalculateClient(new Minus());
            Console.WriteLine("Minus: " + minusClient.Calculate(7, 1).ToString());

            CalculateClient plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus: " + plusClient.Calculate(7, 1).ToString());
        }
    }
}
