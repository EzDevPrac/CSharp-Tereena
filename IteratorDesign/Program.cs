using System;
using System.Collections.Generic;

namespace IteratorDesign
{
    // The 'Aggregate' Interface
    public interface ISocialNetworking
    {
        Iterator CreateIterator();
    }

    
    /// The 'ConcreteAggregate' class
    public class Facebook : ISocialNetworking
    {
        private string[] Users;
        public Facebook() 
        {
            // Sign up for an facebook account
            Users = new[] { "Terna", "Lavanya", "Raju" };
        }

        public Iterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }

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

    /// The 'Iterator' Interface
     
        public interface Iterator
    {
        void First();   //Reset back to the first element
        string Next();  //Get next
        bool IsDone();  //End of collection check
        //string CurrentItem();  //Get current item
    }


    /// The 'ConcreteIterator' class

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
}

