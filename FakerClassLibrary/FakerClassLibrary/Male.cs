using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    public class Male : Person
    {
        int day = 0;
        int month = 0;
        int year = 0;
        DateTime _birthday;

        List<int> LeapYear = new List<int>();
        Random rand = new Random();

        public Male()
        {
        }

        public override void SetLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public override void SetBirthdate(string birthDate)
        {
            month = rand.Next(1, 13);                                           // creates a number between 1 and 12 for months
            if (month == 2)                                                     //Februray 
            {
                int i;
                for (i = 1940; i <= 2002; i += 4)
                {
                    LeapYear.Add(i);                                            //Accounting for Leap years
                }

                foreach (int year in LeapYear)                                  //Loop and find random day for a leep year
                {
                    day = rand.Next(1, 30);                                     // creates a number between 1 and 29 for days
                }

                if (day == 0)                                                   // if day hasnt been set it's not a leap year 
                {                                                               //Seting day
                    day = rand.Next(1, 29);                                     // creates a number between 1 and 28 for days
                }
            }
            else if ((month == 11)||(month == 9)||(month == 6)||(month == 4))   // nov., sept., june, apirl
            {
                day = rand.Next(1, 31);                                         // creates a number between 1 and 30 for days
            }
            else                                                                // other months
            {
                day = rand.Next(1, 32);                                         // creates a number between 1 and 31 for days
            }
            year = rand.Next(1940, 2002);                                       // creates a number between 1940 and 2002 for years

            this._birthday = new DateTime(year, month, day);                    // DateTime AKA birthday set

            throw new NotImplementedException();
        }

        public override LastName GetLastName()
        {
            throw new NotImplementedException();
        }

        public override DateTime GetBirthdate()
        {
            return this._birthday;
            throw new NotImplementedException();
        }

        public override int GetAge()
        {
            DateTime today = DateTime.Today;
            TimeSpan timeSpan = _birthday - today;
            int age = int.Parse(timeSpan.ToString());

            return age;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            String input = "";
            return input;

            throw new NotImplementedException();
        }
    }
}
