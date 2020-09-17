using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    public class Male : Person
    {
        int day = 0;
        int month = 0;
        int year = 0;
        int age;
        private LastName lastName;
        private DateTime birthdate;
        List<int> LeapYear = new List<int>();
        Random rand = new Random();

        public Male()
        {
            this.Title = Title;
        }

        private MaleTitle Title
        {
            get { return Title; }
            set
            {
                var someTitle = new List<MaleTitle>();
                foreach (MaleTitle mTitle in Enum.GetValues(typeof(MaleTitle)))
                {
                    someTitle.Add(mTitle);
                }
                Title = someTitle[rand.Next(someTitle.Count)];
            }
        }

        private MaleFirstName firstName
        {
            get { return firstName; }

            set
            {
                var someName = new List<MaleFirstName>();
                foreach (MaleFirstName mNames in Enum.GetValues(typeof(MaleFirstName)))
                {
                    someName.Add(mNames);
                }
                firstName = someName[rand.Next(someName.Count)];

            }
        }

        public override void SetLastName(LastName lastName)
        {
            var someLastName = new List<LastName>();
            foreach (LastName lastnames in Enum.GetValues(typeof(LastName)))
            {
                someLastName.Add(lastnames);
            }
            this.lastName = someLastName[rand.Next(someLastName.Count)];
            throw new NotImplementedException();
        }

        public override void SetBirthdate(DateTime birthDate)
        {
            month = rand.Next(1, 13);                                           // creates a number between 1 and 12 for months
            if (month == 2)                                                     // Februray 
            {
                int i;
                for (i = 1940; i <= 2002; i += 4)
                {
                    LeapYear.Add(i);                                            // Accounting for Leap years
                }

                foreach (var year in LeapYear)                                  // Loop and find random day for a leep year
                {
                    day = rand.Next(1, 30);                                     // creates a number between 1 and 29 for days
                }

                if (day == 0)                                                   // if day hasnt been set it's not a leap year 
                {                                                               // Seting day
                    day = rand.Next(1, 29);                                     // creates a number between 1 and 28 for days
                }
            }
            else if ((month == 11) || (month == 9) || (month == 6) || (month == 4))   // nov., sept., june, apirl
            {
                day = rand.Next(1, 31);                                         // creates a number between 1 and 30 for days
            }
            else                                                                // other months
            {
                day = rand.Next(1, 32);                                         // creates a number between 1 and 31 for days
            }
            year = rand.Next(1940, 2002);                                       // creates a number between 1940 and 2002 for years

            birthdate = new DateTime(year, month, day);                         // DateTime AKA birthday set

            throw new NotImplementedException();
        }

        public override LastName GetLastName()
        {
            return lastName;
            throw new NotImplementedException();
        }

        public override DateTime GetBirthdate()
        {
            return birthdate;
            throw new NotImplementedException();
        }

        public override int GetAge()
        {
            DateTime now = DateTime.Now;
            TimeSpan time = now.Subtract(birthdate);
            age = int.Parse(time.ToString());
            return age;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            String input = "";
            input = "\tMeet " + Title + " " + firstName + " " + lastName +
                "! \nShe was born " + birthdate + ", that makes her " +
                age + ".";
            return input;

            throw new NotImplementedException();
        }

    }
}
