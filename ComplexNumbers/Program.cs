using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComplexNumber cn = new ComplexNumber(3,2);
            //Console.WriteLine(cn.ToString());

            //cn.SetImaginary(-3);
            //Console.WriteLine(cn.ToString());
            //Console.WriteLine(cn.GetMagnitude());
            //Console.WriteLine(cn.ToString());

            //ComplexNumber cn1 = new ComplexNumber(-1,1);
            //cn.Add(cn1);
            //Console.WriteLine(cn.ToString());

            ComplexNumber c1 = new ComplexNumber(-1, 1);
            ComplexNumber c2 = new ComplexNumber(-1, 1);

            ComplexNumber add = new ComplexNumber();
            ComplexNumber sub = new ComplexNumber();

            add = c1 + c2;
            sub = c1 - c2;
            Console.WriteLine(add);
            Console.WriteLine(sub);
        }
    }
}
