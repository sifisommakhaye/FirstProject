using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.People
{
    public class Person
    {
        public string name;
        public int age;
        public bool hasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi! my name is " + name + " and my age is " + age);
        }
    }
}
