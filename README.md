[![Build Status](https://dev.azure.com/tereena99/Csharp/_apis/build/status/EzDevPrac.CSharp-Tereena?branchName=master)](https://dev.azure.com/tereena99/Csharp/_build/latest?definitionId=4&branchName=master)

# CsharpConcepts



**Inversion of Control**
>> IoC is a design principle which recommends the inversion of different kinds of controls in object-oriented design to achieve loose coupling between application classes.

**Dependency Inversion Principle**
>> The DIP principle also helps in achieving loose coupling between classes. It is highly recommended to use DIP and IoC together in order to achieve loose coupling.

>> DIP suggests that high-level modules should not depend on low level modules. Both should depend on abstraction.

**Dependency Injection**
>> Dependency Injection (DI) is a design pattern which implements the IoC principle to invert the creation of dependent objects.

>> we are going to implement Dependency Injection and strategy pattern together to move the dependency object creation completely out of the class.


**The Dependency Injection pattern involves 3 types of classes.**

**1.Client Class**
>> The client class (dependent class) is a class which depends on the service class

**2.Service Class**
>> The service class (dependency) is a class that provides service to the client class.

**3.Injector Class**
>> The injector class injects the service class object into the client class.

* The following figure illustrates the relationship between these classes:

![DependencyInjectionUML](https://user-images.githubusercontent.com/39005871/82202911-3414c100-9920-11ea-97ea-0c8854a39f26.png)

* As you can see, the injector class creates an object of the service class, and injects that object to a client object.

**Types of Dependency Injection**

* The injector class injects dependencies broadly in three ways: through a constructor, through a property, or through a method.

**1.Constructor Injection:**
>> In the constructor injection, the injector supplies the service (dependency) through the client class constructor.

**2.Property Injection:**
>> In the property injection (aka the Setter Injection), the injector supplies the dependency through a public property of the client class.

**3.Method Injection:**
>> In this type of injection, the client class implements an interface which declares the method(s) to supply the dependency and the injector uses this interface to supply the dependency to the client class.

**IoC Container**
>> The IoC container is a framework used to manage automatic dependency injection throughout the application, so that we as programmers do not need to put more time and effort into it.

**Example**
**IProduct Interface**
```csharp
    public interface IProduct
    {
        string InsetData();
    }
 ```
 
 **Data Access Layer class implement the interface Iproduct**
 ```charp
    public class DL : IProduct
    {
        public string InsetData()
        {
            string val = "Dependency Injection Injected";
            Console.WriteLine(val);
            return val;
        }
    }
```
**Business acess layer class**
```csharp
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
```  
**Main Class which shows how the dependency injection is done**

```csharp 
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
```
**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/DependencyInjectionUsingUnityFramework

**DESIGN PATTERNS**

**Proxy Design Pattern**
* Proxy Design pattern falls under Structural Pattern.

* The proxy design pattern is used to provide a surrogate object, which references to other objects.

* The proxy pattern involves a class, called proxy class, which represents the functionality of another class.

**UML Diagram**
![proxyUML](https://user-images.githubusercontent.com/39005871/81795164-7194db00-9529-11ea-9cf8-2f1d13b613e3.png)

* The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.Subject**
>> This is an interface having members that will be implemented by RealSubject and Proxy class.

**2.RealSubject**
>> This is a class which we want to use more efficiently by using proxy class.

**3.Proxy**
>> This is a class which holds the instance of RealSubject class and can access RealSubject class members as required.

**Example**
**Subject Interface**
```csharp
public interface IShape
    {
        string GetShape();
    }
```
**Real Subject**
```csharp
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
```
**Proxy**
```csharp
public class ProxyPolygon : IShape
    {
        IShape _shape;
        public void Details()
        {
            Console.WriteLine("This is Proxy polygon Class");
        }
        public string GetShape()
        {
            _shape = new RealPolygon();
            return _shape.GetShape();
        }
    }
 ```
 **Entry Point**
 ```csharp
 class Program
    {
        static void Main(string[] args)
        {
            ProxyPolygon proxyClass = new ProxyPolygon();
            proxyClass.Details();
            string RealPolygonDetails = proxyClass.GetShape();
            Console.WriteLine(RealPolygonDetails);
            Console.ReadLine();
        }
    }
 ```
 **Reference**
 https://github.com/EzDevPrac/CSharp-Tereena/tree/master/ProxyDesign
 
**Adapter Design Pattern**

* Adapter pattern falls under Structural Pattern.

* Adapter pattern acts as a bridge between two incompatible interfaces. This pattern involves a single class called adapter which is responsible for communication between two independent or incompatible interfaces.

**For Example:**
* A card reader acts as an adapter between a memory card and a laptop. You plugins the memory card into card reader and card reader into the laptop so that memory card can be read via laptop.

* Imagine an online shopping portal which displays the products for selling on its home page. These products are coming from a third party vendor with which the portal has tied hands to sell products. The third party vendor already has an inventory system in place which can give the list of products it is selling There is no interface available to online shopping portal with which the portal can call the third party vendor’s inventor code.\
Imagine an online shopping portal which displays the products for selling on its home page. These products are coming from a third party vendor with which the portal has tied hands to sell products. The third party vendor already has an inventory system in place which can give the list of products it is selling There is no interface available to online shopping portal with which the portal can call the third party vendor’s inventor code.

**UML Diagram**

![AdapterUML](https://user-images.githubusercontent.com/39005871/81669708-35e40d80-9464-11ea-9619-ab3e93ffa8b5.png)

* The classes, interfaces, and objects in the above UML class diagram are as follows:

**01.ITarget**
>> This is an interface which is used by the client to achieve its functionality/request.

**2.Adapter**
>> This is a class which implements the ITarget interface and inherits the Adaptee class. It is responsible for communication between Client and Adaptee.

**3.Adaptee**
>> This is a class which has the functionality, required by the client. However, its interface is not compatible with the client.

**4.Client**
>> This is a class which interacts with a type that implements the ITarget interface. However, the communication class called adaptee, is not compatible with the client

**Example**
**ITarget interface**
```csharp
interface ITarget
{
  List<string> GetProducts();
}
```
**Adapter Class**
```csharp
class VendorAdapter:ITarget
{
   public List<string> GetProducts()
   {
      VendorAdaptee adaptee = new VendorAdaptee();
      return adaptee.GetListOfProducts();
   }
}
```
**Adaptee class**
```csharp
public class VendorAdaptee
{
   public List<string> GetListOfProducts()
   {
      List<string> products = new List<string>();
      products.Add("Gaming Consoles");
      products.Add("Television");
      products.Add("Books");
      products.Add("Musical Instruments");
      return products;
   }
}
```
**Client class**
```csharp
class ShoppingPortalClient
{
   static void Main(string[] args)
   {
      ITarget adapter = new  VendorAdapter();
      foreach (string product in adapter.GetProducts())
      {
        Console.WriteLine(product);
      }
      Console.ReadLine();
   }
}
```
**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/AdapterDesign

**Prototype Design Pattern**

* Prototype pattern falls under Creational Pattern.

* Prototype design pattern is used to create a duplicate object or clone of the current object to enhance performance. This pattern is used when the creation of an object is costly or complex.

**The cloning falls under two categories: shallow and deep.**

* A shallow copy copies all reference types or value types, but it does not copy the objects that the references refer to. The references in the new object point to the same objects that the references in the original object points to.

* (Only Parent Object is cloned here).
 
* In contrast, a deep copy of an object copies the elements and everything directly or indirectly referenced by the elements.

* (Parent Object is cloned along with the containing objects)

**UML Diagram**

![PrototypeUML](https://user-images.githubusercontent.com/39005871/81197106-85968500-8fdd-11ea-9c49-f5546b5699b7.png)

* The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.Prototype**

* This is an interface which is used for the types of object that can be cloned itself.

**2.ConcretePrototype**

* This is a class which implements the Prototype interface for cloning itself.

**Example**

**Address Class**
```csharp
public class Address  
{  
    public string State  
    {get;set;}  
  
    public string City  
    {get;set;}   
}  
```
**AuthorForShallowCopy Class**
```csharp
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
}  
```
**Client Code**
```csharp
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
```
**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/PrototypeDesign

**Abstract Factory Pattern**

* Abstract Factory Design method falls under Creational Pattern.

* In Abstract Factory pattern an interface is responsible for creating a set of related objects, or dependent objects without specifying their concrete classes.

* Abstract Factory patterns act a super-factory which creates other factories. This pattern is also called a Factory of factories.

**UML Diagram**

![AbstractFactoryUML](https://user-images.githubusercontent.com/39005871/81134339-0a4bb980-8f72-11ea-8218-3ff3ca96dbe6.png)

* The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.AbstractFactory**
>> This is an interface which is used to create abstract product

**2.ConcreteFactory**
>>This is a class which implements the AbstractFactory interface to create concrete products.

**3.AbstractProduct**
>>This is an interface which declares a type of product.

**4.ConcreteProduct**
>>This is a class which implements the AbstractProduct interface to create a product.

**5.Client**
>>This is a class which uses AbstractFactory and AbstractProduct interfaces to create a family of related objects.

**Example**

**AbstractFactory Interface**
```csharp
interface VehicleFactory
{
 Bike GetBike(string Bike);
 Scooter GetScooter(string Scooter);
}
```
**The 'ConcreteFactory1' class.**
```csharp
class HondaFactory : VehicleFactory
{
 public Bike GetBike(string Bike)
 {
 switch (Bike)
 {
 case "Sports":
 return new SportsBike();
 case "Regular":
 return new RegularBike();
 default:
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
 }

 }

 public Scooter GetScooter(string Scooter)
 {
 switch (Scooter)
 {
 case "Sports":
 return new Scooty();
 case "Regular":
 return new RegularScooter();
 default:
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
 }

 }
}
```
**The 'ConcreteFactory2' class.**
```csharp
class HeroFactory : VehicleFactory
{
 public Bike GetBike(string Bike)
 {
 switch (Bike)
 {
 case "Sports":
 return new SportsBike();
 case "Regular":
 return new RegularBike();
 default:
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
 }

 }

 public Scooter GetScooter(string Scooter)
 {
 switch (Scooter)
 {
 case "Sports":
 return new Scooty();
 case "Regular":
 return new RegularScooter();
 default:
 throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
 }

 }
}
```
**The 'AbstractProductA' interface**
```csharp
interface Bike
{
 string Name();
}
```
**The 'AbstractProductB' interface**
```csharp
interface Scooter
{
 string Name();
}
```
**The 'ProductA1' class**
```csharp
class RegularBike : Bike
{
 public string Name()
 {
 return "Regular Bike- Name";
 }
}
```
**The 'ProductA2' class**
```csharp
class SportsBike : Bike
{
 public string Name()
 {
 return "Sports Bike- Name";
 }
}
```
**The 'ProductB1' class**
```csharp
class RegularScooter : Scooter
{
 public string Name()
 {
 return "Regular Scooter- Name";
 }
}
```
**The 'ProductB2' class**
```csharp
class Scooty : Scooter
{
 public string Name()
 {
 return "Scooty- Name";
 }
}
```
**The 'Client' class**
```csharp
class VehicleClient
{
 Bike bike;
 Scooter scooter;

 public VehicleClient(VehicleFactory factory, string type)
 {
 bike = factory.GetBike(type);
 scooter = factory.GetScooter(type);
 }

 public string GetBikeName()
 {
 return bike.Name();
 }

 public string GetScooterName()
 {
 return scooter.Name();
 }

}
```
**Abstract Factory Pattern Demo**
```csharp
class Program
{
 static void Main(string[] args)
 {
 VehicleFactory honda = new HondaFactory();
 VehicleClient hondaclient = new VehicleClient(honda, "Regular");
 
 Console.WriteLine("******* Honda **********");
 Console.WriteLine(hondaclient.GetBikeName());
 Console.WriteLine(hondaclient.GetScooterName());
 
 hondaclient = new VehicleClient(honda, "Sports");
 Console.WriteLine(hondaclient.GetBikeName());
 Console.WriteLine(hondaclient.GetScooterName());
 
 VehicleFactory hero = new HeroFactory();
 VehicleClient heroclient = new VehicleClient(hero, "Regular");
 
 Console.WriteLine("******* Hero **********");
 Console.WriteLine(heroclient.GetBikeName());
 Console.WriteLine(heroclient.GetScooterName());
 
 heroclient = new VehicleClient(hero, "Sports");
 Console.WriteLine(heroclient.GetBikeName());
 Console.WriteLine(heroclient.GetScooterName());
 
 Console.ReadKey();
 }
}
```
**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/AbstractFactoryDesign

**Iterator Pattern**

* Iterator Design Pattern falls under Behavioral Pattern.

* Iterator Design Pattern provides a way to access the elements of a collection object in a sequential manner without knowing its underlying structure.

**UML Diagram**

![IteratorUML](https://user-images.githubusercontent.com/39005871/80931620-ca050380-8dd8-11ea-9e59-907de11794b2.png)

* The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.Client**

>> This is the class that contains an object collection and uses the Next operation of the iterator to retrieve items from the aggregate in an appropriate sequence.

**2.Iterator**

>> This is an interface that defines operations for accessing the collection elements in a sequence.

**3.ConcreteIterator**

>> This is a class that implements the Iterator interface.

**4.Aggregate**

>> This is an interface which defines an operation to create an iterator.

**5.ConcreteAggregate**

>> This is a class that implements an Aggregate interface.

**Example**

**Iterator Interface**
```csharp
        public interface Iterator
    {
        void First();   //Reset back to the first element
        string Next();  //Get next
        bool IsDone();  //End of collection check
        //string CurrentItem();  //Get current item
    }
```
**ConcreteIterator1
```csharp
    public class FacebookIterator : Iterator
    {
        private string[] Users;
        private int position;
        public FacebookIterator(string[] users)
        {
            this.Users = users;
            
        }
        
        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return Users[position++];
        }

        public bool IsDone()
        {
            return position >= Users.Length;
        }
        /*public string CurrentItem()
        {
            return Users[position];
        }*/
    }
 ```
 **ConcreteIterator2
 ```csharp
 public class TwitterIterator : Iterator
    {
        private string[] Users;
        private int position;
        public TwitterIterator(string[] users)
        {
            this.Users = users;
            
        }
        
        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return Users[position++];
        }

        public bool IsDone()
        {
            return position >= Users.Length;
        }

        /*public string CurrentItem()
        {
            return Users[position];
        }
        */

    }
 ```
 **Aggregate Interface**
 ```csharp
 public interface ISocialNetworking
    {
        Iterator CreateIterator();
    }
 ```
 **ConcreteAggregate1**
 ```csharp
 public class Facebook : ISocialNetworking
    {
        private string[] Users;
        public Facebook() 
        {
            // Sign up for an facebook accaount
            Users = new[] { "terna", "Lavanya", "Raju" };
        }

        public Iterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
```
**ConcreteAggregate2**
```csharp
    public class Twitter : ISocialNetworking
    {
        private string[] Users;
        public Twitter()
        {
            // Sign up for an Twitter accaount
            Users = new[] { "Karan", "Shashank", "xyz" };
        }

        public Iterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
```
**Entry Point**
```csharp
    public class Program
    {
        public static void Main(string[] args)
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            Iterator fbIterator = fb.CreateIterator();
            Iterator twIterator = tw.CreateIterator();

            Console.WriteLine("Facebook.....");
            PrintUsers(fbIterator);
            Console.WriteLine();
            Console.WriteLine("Twitter.....");
            PrintUsers(twIterator);



        }

        public static void PrintUsers(Iterator iterate)
        {
            iterate.First();
            while(!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }

        }
    }
```
**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/IteratorDesign

**Strategy Pattern**

* Strategy Design Pattern falls under Behavioral Pattern.

* This pattern allows a client to choose an algorithm from a family of algorithms at run-time and gives it a simple way to access it.

* Strategy Design Pattern involves the removal of an algorithm from its host class and putting it in a separate class.

**UML Diagram**

![StrategyUML](https://user-images.githubusercontent.com/39005871/80506714-99196e80-8993-11ea-9084-7ac0e0990694.png)

* The classes, interfaces, and objects in the above UML class diagram are as follows:

**1.Context**

>> This is a class that contains a property to hold the reference of a Strategy object. This property will be set at run-time according to the algorithm that is required.

**2.Strategy**

>>This is an interface that is used by the Context object to call the algorithm defined by a ConcreteStrategy.

**3.ConcreteStrategyA/B**

>>These are classes that implement the Strategy interface.

**Example**

**Strategy Interface**
```csharp
public interface ICalculateInterface  
{  
  int Calculate(int value1, int value2);  
}  
```
**ConcreteStrategy A**
```csharp
class Minus : ICalculateInterface  
{  
       public int Calculate(int value1, int value2)  
        { 
        return value1 - value2;  
        }  
}  
```
**ConcreteStrategy B**
```csharp
class Plus : ICalculateInterface  
{  
       public int Calculate(int value1, int value2)  
        {  
           return value1 + value2;  
        }  
}  
```
**Client**
```csharp
class CalculateClient  
{  
       private ICalculateInterface calculateInterface;  
  
       public CalculateClient(ICalculateInterface strategy)  
        {  
            calculateInterface = strategy;  
        }  
  
       public int Calculate(int value1, int value2)  
        {  
           return calculateInterface.Calculate(value1, value2);  
        }  
}  
```
**Entry Point**
```csharp
class MainApp  
{  
    static void Main()  
    {  
        CalculateClient minusClient = new CalculateClient(new Minus());  
        Response.Write("Minus: " + minusClient.Calculate(7, 1).ToString());  
  
         CalculateClient plusClient = new CalculateClient(new Plus());  
         Response.Write("Plus: " + plusClient.Calculate(7, 1).ToString());  
     }
 }
```

**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/StrategyDesign

**Observer Pattern**

* Observer Design Pattern falls under Behavioral Pattern

* This pattern is used when there is one too many relationships between objects such as if one object is modified, its dependent objects are to be notified automatically.

* Observer Design Pattern is allowed a single object, known as the subject, to publish changes to its state and other observer objects that depend upon the subject are automatically notified of any changes to the subject's state.

* There are n numbers of observers (objects) which are interested in a special object (called the subject). Explaining one step further- there are various objects (called observers) which are interested in things going on with a special object (called the subject). So they register (or subscribe) themselves to subject (also called publisher). The observers are interested in happening of an event (this event usually happens in the boundary of subject object) whenever this event is raised (by the subject/publisher) the observers are notified.

**UML Diagram**

![ObserverUML](https://user-images.githubusercontent.com/39005871/80446136-9dae3a80-8933-11ea-9825-9f872d3df75f.png)

1.  Subject They are the publishers. When a change occurs to a subject it should notify all of its subscribers.

2.  Observers They are the subscribers. They simply listen to the changes in the subjects.

**Example**

* Consider an online electronics store which has a huge inventory and they keep on updating it. The store wants to update all its users/customers whenever any product arrives in the store. The online electronic store is going to be the subject. Whenever the subject would have any addition in its inventory, the observers (customers/users) who have subscribed to store notifications would be notified. Let’s look at the code straight away to get an idea of how we can implement Observer pattern in C#.


**Subject Interface**
```csharp
interface ISubject
{
   void Subscribe(Observer observer);
   void Unsubscribe(Observer observer);
   void Notify();
}
```
**ConcreteSubject**
```csharp
public class Subject:ISubject
{
  private List<Observer> observers = new List<Observer>();
  private int _int;
  public int Inventory
  {
    get
    {
       return _int;
    }
    set
    {
          if (value > _int)
             Notify();
          _int = value;
    }
  }
  public void Subscribe(Observer observer)
  {
     observers.Add(observer);
  }

  public void Unsubscribe(Observer observer)
  {
     observers.Remove(observer);
  }

  public void Notify()
  {
     observers.ForEach(x => x.Update());
  }
}
```
**Observer interface**
```csharp
interface IObserver
{
  void Update();
}
```
**Concrete Observer**
```csharp
public class Observer:IObserver
{
  public string ObserverName { get;private set; }
  public Observer(string name)
  {
    this.ObserverName = name;
  }
  public void Update()
  {
    Console.WriteLine("{0}: A new product has arrived at the store",this.ObserverName);
  }
}
```

**Entry Point**
```csharp
static void Main(string[] args)
{
   Subject subject = new Subject();
   // Observer1 takes a subscription to the store
   Observer observer1 = new Observer("Observer 1");
   subject.Subscribe(observer1);
   // Observer2 also subscribes to the store
   subject.Subscribe(new Observer("Observer 2"));
   subject.Inventory++;
   // Observer1 unsubscribes and Observer3 subscribes to notifications.
   subject.Unsubscribe(observer1);
   subject.Subscribe(new Observer("Observer 3"));
   subject.Inventory++;
   Console.ReadLine();
}
```

**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/ObserverDesign


**Decorator Pattern**

* Decorator design pattern falls under Structural Pattern.

* The decorator pattern is used to add new functionality to an existing object without changing its structure.

* This pattern creates a decorator class which wraps the original class and add new behaviors/operations to an object at run-time.

**UML Diagram**

![DecoratorUML](https://user-images.githubusercontent.com/39005871/80344809-cd066e00-8885-11ea-82da-5507f3651862.png)

The classes, interfaces, and objects in the above UML class diagram are as follows:

1.  Component
This is an interface containing members that will be implemented by ConcreteClass and Decorator.

2.  ConcreteComponent
This is a class which implements the Component interface.

3.  Decorator
This is an abstract class which implements the Component interface and contains the reference to a Component instance. This class also acts as base class for all decorators for components.

4. ConcreteDecorator
This is a class which inherits from Decorator class and provides a decorator for components.

**Implementation of Code**

**Component**
```csharp
 public interface ICar
    {
        string Make { get; }
        double GetPrice();
    }
```
**ConcreteComponent1**
```csharp
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
```
**ConcreteComponent2**
```csharp
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
```
**Decorator**
```csharp
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
 ```
    
**ConcreteDecorator**

```csharp
     public class OfferPrice : CarDecorator
    {   
        public OfferPrice(ICar car) : base(car)
        {

        }
        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
```
**Entry Point**
```csharp
    class Program
    {
        static void Main(string[] args)
        {
            //Create Suzuki instance.
            ICar car = new Suzuki();

            //Wrp Suzuki instance with OfferPrice.   
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(string.Format("Make :{0}  Price:{1}" +  " DiscountPrice:{2}", decorator.Make, decorator.GetPrice(), decorator.GetDiscountedPrice()));
        }
    }
}
```

**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/DecoratorDesign



**Singleton Pattern**

* Singleton pattern falls under Creational Pattern.

* We need to use the Singleton Design Pattern in C# when we need to ensures that only one instance of a particular class is going to be created and then provide simple global access to that instance for the entire application.

**UML Diagram**

![SingletonUML](https://user-images.githubusercontent.com/39005871/80344821-d5f73f80-8885-11ea-8856-b47cb395029d.png)

* As you can see in the above diagram, different clients (NewObject a, NewObject b and NewObject n) trying to get the singleton instance.  Once the client gets the singleton instance then they invoke the methods.

* Example of the Singleton Design Pattern using C#

* Let us understand the Singleton Design pattern in C# with an example. There are many ways, we can implement the Singleton Design Pattern in C# are as follows.

1.  No Thread-Safe Singleton design pattern.
2.  Thread-Safety Singleton implementation.
3.  The Thread-Safety Singleton Design pattern implementation using Double-Check Locking.
4.  Thread-Safe Singleton Design pattern implementation without using the locks and no lazy instantiation.
5.  Fully lazy instantiation of the singleton class.
6.  Using .NET 4’s Lazy<T> type. 
       
**Example of No Thread-Safe Singleton design pattern**
```csharp
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


```

**Example of Thread-Safe Singleton design pattern using Locking**
```csharp
using System;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadSafetyWithLockSingleton
{

    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}




```
**Example of Thread-Safety Singleton Design pattern implementation using Double-Check Locking.**
```csharp
using System;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadSafetyDoubleLockSingleon
{

    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }


        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)

        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}


```
**Example of Thread-Safe Singleton design pattern using Eager Loading**
```csharp
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EagerLoadingSingleton
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static readonly Singleton singleInstance = new Singleton();

        public static Singleton GetInstance
        {
            get
            {
                return singleInstance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}


```

**Reference**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/EagerLoadingSingleton


**Factory Method Design Pattern:**

* Factory method pattern falls under Creational Pattern .

* Factory method is a design pattern which defines an interface for creating an object but let the classes that implement the interface decide which class to instantiate.

**UML Diagram**

The UML class diagram for the implementation of the factory design pattern is given below:

![FactoryUml](https://user-images.githubusercontent.com/39005871/79754610-6dfca280-8335-11ea-8349-038c3273920b.jpeg)


1.  Product: It defines the interface of objects the factory method creates.
2.  ConcreteProduct: This is a class that implements the Product interface. 
3.  Creator: This is an abstract class & declares the factory method, which returns an object of the type Product. 
4.  ConcreteCreator: This is a class that implements the Creator class & overrides the factory method to return an instance of ConcreteProduct.

**Factory Pattern Example**

Assume you have three different cards which are considered here as classes MoneyBack, Titanium and Platinum, all of them implement abstract class CreditCard. You need to instantiate one of these classes, but you don't know which of them, it depends on the user. This is a perfect scenario for the Factory Method design pattern.

![FactoryExample](https://user-images.githubusercontent.com/39005871/79754633-794fce00-8335-11ea-877c-ffb87b9e57f4.jpeg)

The classes, interfaces, and objects in the above class diagram can be identified as

**Product** - CreditCard\
**ConcreteProduct**- MoneyBackCreditCard, TitaniumCreditCard, PlatinumCreditCard\
**Creator**- CardFactory\
**ConcreteCreator**- MoneyBackCardFactory, TitaniumCardFactory, PlatinumCardFactory

**Here are the code blocks of each participant:**

**1.Product**

```csharp
       abstract class CreditCard  
    {  
        public abstract string CardType { get; }  
        public abstract int CreditLimit { get; set; }  
        public abstract int AnnualCharge { get; set; }  
    }      
```
**2.ConcreteProduct**

MoneyBackCreditCard
```csharp
using System;  
      class MoneyBackCreditCard : CreditCard  
    {  
        private readonly string _cardType;  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public MoneyBackCreditCard(int creditLimit, int annualCharge)  
        {  
            _cardType = "MoneyBack";  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override string CardType  
        {  
            get { return _cardType; }  
        }  
  
        public override int CreditLimit  
        {  
            get { return _creditLimit; }  
            set { _creditLimit = value; }  
        }  
  
        public override int AnnualCharge  
        {  
            get { return _annualCharge; }  
            set { _annualCharge = value; }  
        }  
    }    
```
TitaniumCreditCard
```csharp
using System;  
  
    class TitaniumCreditCard : CreditCard  
    {  
        private readonly string _cardType;  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public TitaniumCreditCard(int creditLimit, int annualCharge)  
        {  
            _cardType = "Titanium";  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override string CardType  
        {  
            get { return _cardType; }  
        }  
  
        public override int CreditLimit  
        {  
            get { return _creditLimit; }  
            set { _creditLimit = value; }  
        }  
  
        public override int AnnualCharge  
        {  
            get { return _annualCharge; }  
            set { _annualCharge = value; }  
        }      
    }  
```
PlatinumCreditCard
```csharp
using System;  
  
    class PlatinumCreditCard : CreditCard  
    {  
        private readonly string _cardType;  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public PlatinumCreditCard(int creditLimit, int annualCharge)  
        {  
            _cardType = "Platinum";  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override string CardType  
        {  
            get { return _cardType; }  
        }  
  
        public override int CreditLimit  
        {  
            get { return _creditLimit; }  
            set { _creditLimit = value; }  
        }  
  
        public override int AnnualCharge  
        {  
            get { return _annualCharge; }  
            set { _annualCharge = value; }  
        }  
    }   
```
**3.Creator**
```csharp
    abstract class CardFactory  
    {  
        public abstract CreditCard GetCreditCard();  
    }   
```
**4.ConcreteCreator**

MoneyBackFactory
```csharp
    class MoneyBackFactory : CardFactory  
    {  
        private int _creditLimit;  
        private int _annualCharge;  
  
        public MoneyBackFactory(int creditLimit, int annualCharge)  
        {  
            _creditLimit = creditLimit;  
            _annualCharge = annualCharge;  
        }  
  
        public override CreditCard GetCreditCard()  
        {  
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);  
        }  
    }    
```
TitaniumFactory:
```csharp
    class TitaniumFactory: CardFactory      
    {      
        private int _creditLimit;      
        private int _annualCharge;      
      
        public TitaniumFactory(int creditLimit, int annualCharge)      
        {      
            _creditLimit = creditLimit;      
            _annualCharge = annualCharge;      
        }      
      
        public override CreditCard GetCreditCard()      
        {      
            return new TitaniumCreditCard(_creditLimit, _annualCharge);      
        }      
    }          
```
PlatinumFactory:
```csharp
    class PlatinumFactory: CardFactory      
    {      
        private int _creditLimit;      
        private int _annualCharge;      
      
        public PlatinumFactory(int creditLimit, int annualCharge)      
        {      
            _creditLimit = creditLimit;      
            _annualCharge = annualCharge;      
        }      
      
        public override CreditCard GetCreditCard()      
        {      
            return new PlatinumCreditCard(_creditLimit, _annualCharge);      
        }      
    }        
```
**Factory Pattern Client Demo**
```csharp
using System;  
  
    public class ClientApplication  
    {  
        static void Main()  
        {  
            CardFactory factory = null;  
            Console.Write("Enter the card type you would like to visit: ");  
            string card = Console.ReadLine();  
  
            switch (card.ToLower())  
            {  
                case "moneyback":  
                    factory = new MoneyBackFactory(50000, 0);  
                    break;  
                case "titanium":  
                    factory = new TitaniumFactory(100000, 500);  
                    break;  
                case "platinum":  
                    factory = new PlatinumFactory(500000, 1000);  
                    break;  
                default:  
                    break;  
            }  
  
            CreditCard creditCard = factory.GetCreditCard();  
            Console.WriteLine("\nYour card details are below : \n");  
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",  
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);  
              
        }  
    }     
```



**A working Prototype of the code is available in the following link**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/FactoryDesign


**Builder Pattern:**
* It is a creational design pattern, which allows constructing complex objects step by step. 
* Builder patterns makes it possible to produce different products or representations using the same construction process. 

**UML Diagram**

The UML class diagram for the implementation of the builder design pattern is given below:

![BuilderUml](https://user-images.githubusercontent.com/39005871/79754667-85d42680-8335-11ea-85b5-bb0596a31c89.jpeg)

1.  Builder: This is an interface which is used to define all the steps to create a product. 
2.  ConcreteBuilder: This is a class which implements the Builder interface to create a complex product. 
3.  Product: This is a class which defines the parts of the complex object which are generated by the builder pattern. 
4.  Director: This is a class which is used to construct an object using the builder interface.

**Builder Pattern Example**

![BuilderExample](https://user-images.githubusercontent.com/39005871/79754701-95536f80-8335-11ea-8c0d-7a55b5c9e14b.jpeg)


The classes, interfaces, and objects in the above class diagram can be identified as follows:

**IVehicleBuilder** - Builder interface\
**HeroBuilder & HondaBuilder**- Concrete Builder\
**Vehicle**- Product\
**Vehicle Creator** - Director

**Here are the code blocks of each participant:**

**1.Builder**
```csharp
public interface IVehicleBuilder
{
 void SetModel();
 void SetEngine();
 void SetTransmission();
 void SetBody();
 void SetAccessories();

 Vehicle GetVehicle();
}
```
**2.ConcreteBuilder**

HeroBuilder
```csharp
public class HeroBuilder : IVehicleBuilder
{
 Vehicle objVehicle = new Vehicle();
 public void SetModel()
 {
 objVehicle.Model = "Hero";
 }

 public void SetEngine()
 {
 objVehicle.Engine = "4 Stroke";
 }

 public void SetTransmission()
 {
 objVehicle.Transmission = "120 km/hr";
 }

 public void SetBody()
 {
 objVehicle.Body = "Plastic";
 }

 public void SetAccessories()
 {
 objVehicle.Accessories.Add("Seat Cover");
 objVehicle.Accessories.Add("Rear Mirror");
 }

 public Vehicle GetVehicle()
 {
 return objVehicle;
 }
}
```
HondaBuilder
```csharp
public class HondaBuilder : IVehicleBuilder
{
 Vehicle objVehicle = new Vehicle();
 public void SetModel()
 {
 objVehicle.Model = "Honda";
 }

 public void SetEngine()
 {
 objVehicle.Engine = "4 Stroke";
 }

 public void SetTransmission()
 {
 objVehicle.Transmission = "125 Km/hr";
 }

 public void SetBody()
 {
 objVehicle.Body = "Plastic";
 }

 public void SetAccessories()
 {
 objVehicle.Accessories.Add("Seat Cover");
 objVehicle.Accessories.Add("Rear Mirror");
 objVehicle.Accessories.Add("Helmet");
 }

 public Vehicle GetVehicle()
 {
 return objVehicle;
 }
}
```
**3.Product**
```csharp
public class Vehicle
{
 public string Model { get; set; }
 public string Engine { get; set; }
 public string Transmission { get; set; }
 public string Body { get; set; }
 public List<string> Accessories { get; set; }

 public Vehicle()
 {
 Accessories = new List<string>();
 }

 public void ShowInfo()
 {
 Console.WriteLine("Model: {0}", Model);
 Console.WriteLine("Engine: {0}", Engine);
 Console.WriteLine("Body: {0}", Body);
 Console.WriteLine("Transmission: {0}", Transmission);
 Console.WriteLine("Accessories:");
 foreach (var accessory in Accessories)
 {
 Console.WriteLine("\t{0}", accessory);
 }
 }
}
```
**4.Director**
```csharp
public class VehicleCreator
{
 private readonly IVehicleBuilder objBuilder;

 public VehicleCreator(IVehicleBuilder builder)
 {
 objBuilder = builder;
 }

 public void CreateVehicle()
 {
 objBuilder.SetModel();
 objBuilder.SetEngine();
 objBuilder.SetBody();
 objBuilder.SetTransmission();
 objBuilder.SetAccessories();
 }

 public Vehicle GetVehicle()
 {
 return objBuilder.GetVehicle();
 }
}
```

**Builder Design Pattern Demo**
```csharp
class Program
{
 static void Main(string[] args)
 {
 var vehicleCreator = new VehicleCreator(new HeroBuilder());
 vehicleCreator.CreateVehicle();
 var vehicle = vehicleCreator.GetVehicle();
 vehicle.ShowInfo();

 Console.WriteLine("---------------------------------------------");

 vehicleCreator = new VehicleCreator(new HondaBuilder());
 vehicleCreator.CreateVehicle();
 vehicle = vehicleCreator.GetVehicle();
 vehicle.ShowInfo();

 
 }
}
```



**A working Prototype of the code is available in the following link**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/BuilderDesign


**Command Design Pattern:**
* Command is behavioral design pattern that converts requests or simple operations into objects.

**UML Diagram**

The UML class diagram for the implementation of the command design pattern is given below:

![CommandUml](https://user-images.githubusercontent.com/39005871/79754761-a9976c80-8335-11ea-9ea8-8f9e425a9a2b.jpeg)


1.  Invoker  --> Asks the command to carry out the action
2.  Command --> This is an interface which specifies the execute operation
3.  Concrete Command --> Class that implements the execute operation by invoking on the receiver
4.  Receiver class --> Class that performs the Action Associated with the Request

**Command Pattern Example**

![CommandExampleDiagram](https://user-images.githubusercontent.com/39005871/79754784-b3b96b00-8335-11ea-8095-dcaa93358f3e.jpeg)



The classes, interfaces, and objects in the above class diagram can be identified as follows:

**Switch**- Invoker class.\
**ICommand** - Command interface.\
**FlipUpCommand and FlipDownCommand** - Concrete Command classes.\
**Light** - Receiver class.

**Here are the code blocks for each participant**
**1.Command**
```csharp
public interface ICommand
{
 void Execute();
}
```
**2.Invoker**
```csharp
public class Switch
{

 public void StoreAndExecute(ICommand command)
 {
 command.Execute();
 }
}
```
**3.Receiver**
```csharp
public class Light
{
 public void TurnOn()
 {
 Console.WriteLine("The light is on");
 }

 public void TurnOff()
 {
 Console.WriteLine("The light is off");
 }
}
```
**4.ConcreteCommand**

FlipUpCommand
```csharp
public class FlipUpCommand : ICommand
{
 private Light _light;

 public FlipUpCommand(Light light)
 {
 _light = light;
 }

 public void Execute()
 {
 _light.TurnOn();
 }
}
```

FlipDownCommand
```csharp
public class FlipDownCommand : ICommand
{
 private Light _light;

 public FlipDownCommand(Light light)
 {
 _light = light;
 }

 public void Execute()
 {
 _light.TurnOff();
 }
}
```
**Command Pattern Demo**
```csharp
class Program
{
 static void Main(string[] args)
 {
 Console.WriteLine("Enter Commands (ON/OFF) : ");
 string cmd = Console.ReadLine();

 Light lamp = new Light();
 ICommand switchUp = new FlipUpCommand(lamp);
 ICommand switchDown = new FlipDownCommand(lamp);

 Switch s = new Switch();

 if (cmd == "ON")
 {
 s.StoreAndExecute(switchUp);
 }
 else if (cmd == "OFF")
 {
 s.StoreAndExecute(switchDown);
 }
 else
 {
 Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
 }
 }
}
```


**A working Prototype of the code is available in the following link**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/CommandDesign


**Facade Design Pattern:**

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

If we try to understand this in simpler terms, then we can say that a room is a façade and just by looking at it from outside the door, one can not predict what is inside the room and how the room is structured from inside. Thus, Façade is a general term for simplifying the outward appearance of a complex or large system.

In software terms, Facade pattern hides the complexities of the systems and provides a simple interface to the clients.

This pattern involves one wrapper class which contains a set of methods available for the client. This pattern is particularly used when a system is very complex or difficult to understand and when the system has multiple subsystems.

**Let’s see the below UML diagram**

![facadeUML](https://user-images.githubusercontent.com/39005871/79759264-157cd380-833c-11ea-879f-2d6108f45e43.png)



Here, we can see that the client is calling the Façade class which interacts with multiple subsystems making it easier for the client to interact with them.

However, it is possible that façade may provide limited functionality in comparison to working with the subsystem directly, but it should include all those features which are actually required by the client. 

For example, When someone calls the restaurant, suppose, for ordering pizza or some other food, then the operator on behalf of the restaurant gives the voice interface which is actually the façade for their customers.

Customers place their orders just by talking to the operator and they don’t need to bother about how they will prepare the pizza, what all operations will they perform, on what temperature they will cook, etc. 

Similarly, in our code sample, we can see that the client is using the restaurant façade class to order pizza and bread of different types without directly interacting with the subclasses.

**CODE**

**This is the interface specific to the pizza.**

```csharp
public interface IPizza {  
    void GetVegPizza();  
    void GetNonVegPizza();  
}  
```

**This is a pizza provider class which will get pizza for their clients. Here methods can have other private methods which client is not bothered about.**
```csharp
public class PizzaProvider: IPizza {  
    public void GetNonVegPizza() {  
        GetNonVegToppings();  
        Console.WriteLine("Getting Non Veg Pizza.");  
    }  
    public void GetVegPizza() {  
        Console.WriteLine("Getting Veg Pizza.");  
    }  
    private void GetNonVegToppings() {  
        Console.WriteLine("Getting Non Veg Pizza Toppings.");  
    }  
}  
```

**Similarly, this is the interface specific for the bread.**
```csharp
public interface IBread {  
    void GetGarlicBread();  
    void GetCheesyGarlicBread();  
}  
```

**And this is a bread provider class.**
```csharp
public class BreadProvider: IBread {  
    public void GetGarlicBread() {  
        Console.WriteLine("Getting Garlic Bread.");  
    }  
    public void GetCheesyGarlicBread() {  
        GetCheese();  
        Console.WriteLine("Getting Cheesy Garlic Bread.");  
    }  
    private void GetCheese() {  
        Console.WriteLine("Getting Cheese.");  
    }  
}  
```
**Below is the restaurant façade class, which will be used by the client to order different pizzas or breads.**
```csharp
public class RestaurantFacade {  
    private IPizza _PizzaProvider;  
    private IBread _BreadProvider;  
    public RestaurantFacade() {  
        _PizzaProvider = new PizzaProvider();  
        _BreadProvider = new BreadProvider();  
    }  
    public void GetNonVegPizza() {  
        _PizzaProvider.GetNonVegPizza();  
    }  
    public void GetVegPizza() {  
        _PizzaProvider.GetVegPizza();  
    }  
    public void GetGarlicBread() {  
        _BreadProvider.GetGarlicBread();  
    }  
    public void GetCheesyGarlicBread() {  
        _BreadProvider.GetCheesyGarlicBread();  
    }  
}  
```
**Finally, below is the main method of our program**

```csharp
void Main() {  
    Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");  
    var facadeForClient = new RestaurantFacade();  
    facadeForClient.GetNonVegPizza();  
    facadeForClient.GetVegPizza();  
    Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");  
    facadeForClient.GetGarlicBread();  
    facadeForClient.GetCheesyGarlicBread();  
}  
```
**Referance**
https://github.com/EzDevPrac/CSharp-Tereena/tree/master/FacadeDesign


