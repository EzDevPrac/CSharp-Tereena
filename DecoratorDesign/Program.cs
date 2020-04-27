 using System;

namespace DecoratorDesign
{

    public interface ICar
    {
        string Make { get; }
        double GetPrice();
    }

    public sealed class Hyndai : ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }

        public double GetPrice()
        {
            return 800000;
        }
    }

    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }

        public double GetPrice()
        {
            return 800000;
        }
    }

    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar Car)
        {
            car = Car;
        }
        public string Make
        {
            get { return car.Make; }
        }

        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountedPrice();
    }

     public class OfferPrice : CarDecorator
    {   
        public OfferPrice(ICar car) : base(car)
        {

        }
        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(string.Format("Make :{0}  Price:{1}" +  " DiscountPrice:{2}", decorator.Make, decorator.GetPrice().ToString(), decorator.GetDiscountedPrice().ToString()));
        }
    }
}