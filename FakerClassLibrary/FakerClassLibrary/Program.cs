using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    class Program
    {
        private static int year = 2015;
        private static int month = 1;
        private static int day = 31;


        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello!");
            Female one = new Female();
            LastName last = LastName.Smith;
            DateTime birth = new DateTime(year, month, day);

            // ?? How are you supussoed to create properties the are Random???
            one.Title = FemaleTitle.Dr;
            one.firstName = FemaleFirstName.Abigail;

            // ?? Why bring values in if its randomized ???
            one.SetLastName(last);
            one.SetBirthdate(birth);

            Female two = new Female();
            last = LastName.Allen;
            one.SetLastName(last);
            one.SetBirthdate(birth);

            Male three = new Male();
            last = LastName.Clark;
            one.Title = FemaleTitle.Dr;
            three.firstName = MaleFirstName.Aiden;
            three.SetLastName(last);
            three.SetBirthdate(birth);


            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
            Console.WriteLine(three.ToString());

        }
    }
}
// ?? Age (THE UML CONFUSING ME) ??
// ?? Fields cant be abstract so how will those fiels be required in female and male???
// ?? is there a way to see values while your are debugging??