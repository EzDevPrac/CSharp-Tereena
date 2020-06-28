using Microsoft.Practices.Unity;
using System;

namespace DependencyInjectionUsingUnityFramework
{
    //IProduct Interface
    public interface IProduct
    {
        string InsetData();
    }

    //Data Access Layer class
    public class DL : IProduct
    {
        public string InsetData()
        {
            string val = "Dependency Injection Injected";
            Console.WriteLine(val);
            return val;
        }
    }

    //Business acess layer class
    public class BL
    {
        private IProduct _objpro;

        public BL(IProduct objpro) //injecting DL to BL(constructor)
        {
            _objpro = objpro;
        }

        public void Insert()
        {
            _objpro.InsetData(); //calling method of DL
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //creating UnityContainer object
            UnityContainer UI = new UnityContainer();
            //UI.RegisterType<BL>();
            //UI.RegisterType<DL>();

            /* Register a type with specific members to be injected*/
            UI.RegisterType<IProduct,DL>();

            /*We want to resolve the BL by injecting a DL. That is why I wrote Resolve<BL>*/
            BL objDL = UI.Resolve<BL>();  //injects DL
            objDL.Insert(); //BL Method

        }
    }
}
