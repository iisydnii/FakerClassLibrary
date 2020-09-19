////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: FakerClassLibrary
// File Name: Female.cs
// Description: class for Female persons
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 09/19/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace FakerClassLibrary
{
    public class Female : Person                                                //Female inherits person abstract class
    {
        private static int day;
        private static int month;
        private static int year;
        private static int age;
        List<int> LeapYear = new List<int>();                                   //List of leap years
        Random rand = new Random();                                             //Instantating random object rand
        DateTime date;

        public Female()
        {
            this.title = Title();                                               //to set title call method Title for specs
            this._firstName = firstName();                                      //to set _firstName call method firstName for specs
            SetLastName(LastName.Brown);                                        //to set _lastName call method SetLastName for specs set default
            SetBirthdate(date = new DateTime(2015, 10, 5));                     //call method SetBirthdate for specs set default
        }

        private FemaleTitle title { get; set; }                                  //Last name property
        private FemaleTitle Title()
        {
            var someTitle = new List<FemaleTitle>();
            foreach (FemaleTitle femTitle in Enum.GetValues                     //Looping through the enums
                    (typeof(FemaleTitle)))
            {
                someTitle.Add(femTitle);                                        //adding the enums to list
            }
                return someTitle[rand.Next(someTitle.Count)];                   //random return
        }

        private FemaleFirstName _firstName { get; set; }                         //first name property 
        private FemaleFirstName firstName()
        {
                var someName = new List<FemaleFirstName>();
                foreach (FemaleFirstName fnames in Enum.GetValues               //Looping through the enums
                    (typeof(FemaleFirstName)))
                {
                    someName.Add(fnames);                                       //adding the enums to list
            }
                return someName[rand.Next(someName.Count)];                     //random return
        }

        private LastName lastName { get; set; }                                 //Last name property 
        public override void SetLastName(LastName lastName)
        {
            var someLastName = new List<LastName>();
            foreach (LastName lastnames in Enum.GetValues(typeof(LastName)))    //Looping through the enums
            {
                someLastName.Add(lastnames);                                    //adding the enums to list
            }
           this.lastName = someLastName[rand.Next(someLastName.Count)];                  //random return
        }

        private DateTime birthdate { get; set; }                                //_birthdate property 
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
            else if ((month == 11)||(month == 9)||(month == 6)||(month == 4))   // nov., sept., june, apirl
            {
                day = rand.Next(1, 31);                                         // creates a number between 1 and 30 for days
            }
            else                                                                // other months
            {
                day = rand.Next(1, 32);                                         // creates a number between 1 and 31 for days
            }
            year = rand.Next(1940, 2002);                                       // creates a number between 1940 and 2002 for years

            birthdate = new DateTime(year, month, day);                        // DateTime AKA birthday set
                GetAge();                                                       //call get age 
        }

        public override LastName GetLastName()
        {
            return lastName;                                                   //return last name
        }

        public override DateTime GetBirthdate()
        {
            return birthdate;                                                  //return birthdate 
        }

        public override int GetAge()
        {
            DateTime now = DateTime.Now;                                        //Current Date
            TimeSpan time = now.Subtract(birthdate);                           //Get the age in days by subtracting the two dates
            age = Convert.ToInt32(time.TotalDays);                              //covert to int
            age = age / 365;                                                    //Getting age into year by dividing the days alive
            return age;                                                         //return age
        }

        public override string ToString()
        {
            String output = "";

            output = "\n\tMeet " + title.ToString() + " "                         //Output for all details
                + _firstName.ToString() + " "                                   //put into a string for later use
                + GetLastName().ToString() + "! \nShe was born "
                + GetBirthdate().ToString()
                + ", that makes her " + age.ToString() + ".";

            return output;
        }

    }
}
