using System;

namespace FacadeDesign
{
        public interface IPizza
        {
            String GetVegPizza();
            String GetNonVegPizza();
        }

        public class PizzaProvider : IPizza
        {
            public String GetNonVegPizza()
            {
                GetNonVegToppings();
                Console.WriteLine("Getting Non Veg Pizza.");
                return "Getting Non Veg Pizza.";
            }
            public String GetVegPizza()
            {
                Console.WriteLine("Getting Veg Pizza.");
                return "Getting Veg Pizza.";
            }
            private void GetNonVegToppings()
            {
                Console.WriteLine("Getting Non Veg Pizza Toppings.");
            }
        }

        public interface IBread
        {
            String GetGarlicBread();
            String GetCheesyGarlicBread();
        }

        public class BreadProvider : IBread
        {
            public String GetGarlicBread()
            {
                Console.WriteLine("Getting Garlic Bread.");
                return "Getting Garlic Bread.";
            }
            public String GetCheesyGarlicBread()
            {
                GetCheese();
                Console.WriteLine("Getting Cheesy Garlic Bread.");
                return "Getting Cheesy Garlic Bread.";
            }
            private void GetCheese()
            {
                Console.WriteLine("Getting Cheese.");
            }
        }

        public class RestaurantFacade
        {
            private IPizza _PizzaProvider;
            private IBread _BreadProvider;
            public RestaurantFacade()
            {
                _PizzaProvider = new PizzaProvider();
                _BreadProvider = new BreadProvider();
            }
            public string GetNonVegPizza()
            {
                String str=_PizzaProvider.GetNonVegPizza();
                //Console.WriteLine(str);
                return str;
            }
            public String GetVegPizza()
            {
               String str= _PizzaProvider.GetVegPizza();
               //Console.WriteLine(str);
               return str;
        }
            public String GetGarlicBread()
            {
                String str=_BreadProvider.GetGarlicBread();
                //Console.WriteLine(str);
                return str;
        }
            public String GetCheesyGarlicBread()
            {
                String str=_BreadProvider.GetCheesyGarlicBread();
                //Console.WriteLine(str);
                return str;
        }

        public class Program
        {

            public static void Main(string[] args)
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
    }
}
