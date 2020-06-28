using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTeacher
{
    class Person
    {
        protected int age;

        public void SetAge(int n)
        {
            age = n;
        }

        public void SayHello()
        {
            Console.WriteLine("hello");
        }
    }
}
