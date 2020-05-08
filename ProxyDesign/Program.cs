using System;

namespace ProxyDesign
{
    public interface IShape
    {
        string GetShape();
        void Details();
    }

    public class RealPolygon : IShape
    {
        public void Details()
        {
            Console.WriteLine("This is real polygon Class");
        }
        public string GetShape()
        {
            return "This is polygon shape from real/ actual class";
        }
    }

    public class ProxyPolygon : IShape
    {
        public void Details()
        {
            Console.WriteLine("This is Proxy polygon Class");
        }
        public string GetShape()
        {
            IShape _shape = new RealPolygon();
            _shape.Details();
            return _shape.GetShape();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ProxyPolygon proxyClass = new ProxyPolygon();
            proxyClass.Details();
            string RealPolygonDetails = proxyClass.GetShape();
            Console.WriteLine(RealPolygonDetails);
        }
    }
}
