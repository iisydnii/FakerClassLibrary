using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    class Program
    {
        private static int year = 2015;
        private static int month = 12;
        private static int day = 1;


        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello!");
            Female one = new Female();
            LastName last = LastName.Smith;
            DateTime birth = new DateTime(year, month, day);
            one.Title = FemaleTitle.Dr;
            one.firstName = FemaleFirstName.Abigail;
            one.SetLastName(last);
            one.SetBirthdate(birth);


            Console.WriteLine(one.ToString());
           
        }
    }
}
