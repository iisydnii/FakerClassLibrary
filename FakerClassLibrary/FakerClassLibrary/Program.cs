using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    class Program
    {
        


        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello!");
            Female one = new Female();
            Console.WriteLine(one.ToString());
            Female two = new Female();
            Console.WriteLine(two.ToString());
            Male three = new Male();
            Console.WriteLine(three.ToString());
        }
    }
}
