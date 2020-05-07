/*using System;

namespace PrototypeDesign
{
    public class Address
    {
        public string State
        { get; set; }

        public string City
        { get; set; }

    }

    public class AuthorForShallowCopy  
{  
          public string Name  
          {get;set;}  
          public string TwitterAccount  
          {get;set;}  
          public string Website  
          {get;set;}  
          public Address HomeAddress  
          {get;set;}
     
        public object Clone()  
          {  
                    return this.MemberwiseClone();  
          }
        public string GetDetails()
        {
            return string.Format("{0} \n{1} \n{2} \n{3} - {4}", Name, TwitterAccount, Website, HomeAddress.City, HomeAddress.State);
        }
    }


    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy Sample\n");
            AuthorForShallowCopy o = new AuthorForShallowCopy();
            
            o.Name = "Sukesh Marla";
            o.TwitterAccount = "https://twitter.com/SukeshMarla";
            o.Website = "http://www.sukesh-marla.com";
                o.HomeAddress = new Address()
                {
                    City = "Mumbai",
                    State = "Maharastra"
                };
            
            Console.WriteLine("Original Copy");
            Console.WriteLine(o.GetDetails());
            AuthorForShallowCopy clonedObject = (AuthorForShallowCopy)o.Clone();
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject.GetDetails());
            Console.WriteLine("\nMake Changes to clone copy address");
            clonedObject.Name = "Mr.Changer";
            clonedObject.TwitterAccount = "https://twitter.com/MrChanger";
            clonedObject.Website = "https://MrChanger.com";
            clonedObject.HomeAddress.State = "Karnataka";
            clonedObject.HomeAddress.City = "Manglore";
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject.GetDetails());
            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine(o.GetDetails());
        }
    }
}
*/

using System;
namespace PrototypeDesign
{
    public class Address 
    {
        public string State
        { get; set; }
        public string City
        { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class AuthorForDeepCopy 
    {
        public string Name
        { get; set; }
        public string TwitterAccount
        { get; set; }
        public string Website
        { get; set; }
        public Address HomeAddress
        { get; set; }
        public object Clone()
        {
            AuthorForDeepCopy objPriCopy = (AuthorForDeepCopy)this.MemberwiseClone();
            objPriCopy.HomeAddress = (Address)this.HomeAddress.Clone();
            return objPriCopy;
        }
        public string GetDetails()
        {
            return string.Format("{0} \n{1} \n{2} \n{3} - {4}", Name, TwitterAccount, Website, HomeAddress.City, HomeAddress.State);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Deep Copy Sample\n");
            AuthorForDeepCopy o = new AuthorForDeepCopy();


                o.Name = "Sukesh Marla";
                o.TwitterAccount = "https://twitter.com/SukeshMarla";
                o.Website = "http://www.sukesh-marla.com";
                o.HomeAddress = new Address()
                {
                    City = "Mumbai",
                    State = "Maharastra"
                };
            
            Console.WriteLine("Original Copy");
            Console.WriteLine(o.GetDetails());
            AuthorForDeepCopy clonedObject = (AuthorForDeepCopy)o.Clone();
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject.GetDetails());
            Console.WriteLine("\nMake Changes to clone copy address");
            clonedObject.Name = "Mr.Changer";
            clonedObject.TwitterAccount = "https://twitter.com/MrChanger";
            clonedObject.Website = "https://MrChanger.com";
            clonedObject.HomeAddress.State = "Karnataka";
            clonedObject.HomeAddress.City = "Manglore";
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject.GetDetails());
            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine(o.GetDetails());
        }
    }
}