////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: FakerClassLibrary
// File Name: Address.cs
// Description: Clas for the creation of an address in the 50 us states
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 09/19/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    public class Address
    {
        String stateAbbr;                                                       //State abbrevations 
        Random rand = new Random();                                             //Instantating random object rand
        List<String> street = new List<string>() { "Sassafras", "Jason Pollke", //Street List of 10
                    "Hamilton", "Rainbow", "Rim", "Randolphe", "University",
                    "Mayflower", "Jefferson", "Jackson" };
        List<String> City = new List<string>() { "Bristol", "Johnson city",     //City list of 10
                    "Abingdon", "Springfield", "kingsprt", "Mystic Falls",
                    "Fall Branch", "Paris", "Damacus", "Nashville" };
        List<String> StateAbbr = new List<string>();                            //State abbrevations list see GetStateAbbr() for more details
        Dictionary<String, String> StateDictionary =                            //All 50 states and their abbrevations
            new Dictionary<String, String>() {
             {"AL", "ALABAMA"},{"AK", "ALASKA"},
             {"AZ", "ARIZONA"},{"CA", "CALIFORNIA"}, {"CO", "COLORADO" },
             {"CT", "CONNECTICUT"}, {"DE", "DELAWARE" }, {"FL", "FLORIDA" },
             {"GA", "GEORGIA"}, {"HI", "HAWAII"}, {"ID", "IDAHO"},
             {"IL", "ILLINOIS"}, {"IN", "INDIANA"}, {"IA", "IOWA"},
             {"KS", "KANSAS"}, {"KY", "KENTUCKY"}, {"LA", "LOUISIANA"},
             {"ME", "MAINE"}, {"MD", "MARYLAND"}, {"MA", "MASSACHUSETTS"},
             {"MI", "MICHIGAN"}, {"MN", "MINNESOTA"}, {"MS", "MISSISSIPPI"},
             {"MO", "MISSOURI"}, {"MT", "MONTANA"}, {"NE", "NEBRASKA"},
             {"NV", "NEVADA"}, {"NH", "NEW HAMPSHIRE"},{"NJ", "NEW JERSEY"},
             {"NM", "NEW MEXICO"}, {"NY", "NEW YORK"}, {"NC", "NORTH CAROLINA"},
             {"ND", "NORTH DAKOTA"}, {"OH", "OHIO"}, {"OK", "OKLAHOMA"},
             {"OR", "OREGON"}, {"PA", "PENNSYLVANIA"}, {"RI", "RHODE ISLAND"},
             {"SC", "SOUTH CAROLINA"}, {"SD", "SOUTH DAKOTA"},
             {"TN", "TENNESSEE"}, {"TX", "TEXAS"}, {"UT", "UTAH"},
             {"VT", "VERMONT"}, {"VA", "VIRGINIA"}, {"WA", "WASHINGTON"},
             {"WV", "WEST VIRGINIA"}, {"WI", "WISCONSIN"}, {"WY", "WYOMING"}};
    
    
        public Address()                                                        //Constructor - calling the set up of the a persons address
        {
            GetHouseNumber();
            GetStreetName();
            GetStreetType();
            GetCity();
            this.state = GetStateAbbr();
            this.zipCode = AssignZipCode();
            Console.WriteLine(ToString());                                      //Requiring that if address is called it must be printed in the console
        }

        private uint houseNumber {get; set; }                                   //houseNumber property
        private uint GetHouseNumber()                                           //the setup and return of houseNumber
        {
            houseNumber = (uint)rand.Next(1, 5001);                             //Get random number for houseNumber
            return houseNumber;                                                 //return houseNumber
        }

        private String streetName {get; set; }                                  //streetName property
        private String GetStreetName()                                          //the setup and return of streetName 
        {
            streetName = street[rand.Next(street.Count)];                       //Get random string from street list for streetName
            return streetName;                                                  //return streetName
        }

        private StreetType streetType { get; set; }                             //streetType property
        private StreetType GetStreetType()                                      //the setup and return of streetType 
        {
            var someStreet = new List<StreetType>();
            foreach (StreetType street in Enum.GetValues                        //Looping through the enums of streetType
                (typeof(StreetType)))
            {
                someStreet.Add(street);                                         //adding the enums to list
            }
            streetType = someStreet[rand.Next(someStreet.Count)];               //Get random StreetType from someStreet list for StreetType 
            return streetType;                                                  //return streetType
        }

        private String city { get; set; }                                       //city property
        private String GetCity()                                                //the setup and return of city
        {
            city = City[rand.Next(City.Count)];                                 //Get random string from city list for city
            return city;                                                        //return city
        }

        private String state { get; set; }                                      //state property
        private String zipCode { get; set; }                                    //zipCode property

        private Dictionary<String, String> stateDictionary                      //stateDictionary  property
        {
            get { return StateDictionary; }
            set { }
        }

        public String GetStateAbbr()
        {
            foreach (KeyValuePair<string, string> entry in StateDictionary)     //loop through dictionary
            {
                StateAbbr.Add(entry.Key);                                       //add the key to StateAbbr list
            }
            int index = rand.Next(StateAbbr.Count);                             //getting random StateAbbr index 
            stateAbbr = StateAbbr[index];                                       //turning StateAbbr to a string

            AssignStateName();                                                  //call AssignStateName() method
            return stateAbbr;                                                   //return stateAbbr
        }

        private String AssignStateName()
        {
            state = StateDictionary[stateAbbr];                                 //assign state using stateAbbr (key) in StateDictionary

            return state;
        }

        private String AssignZipCode()
        {
            String firstHalf;                                                   //memory space for holding the string of the first half of a zip code
            String SecHalf;                                                     //memory space for holding the string of the Second half of a zip code
            int length;                                                         //For the length of the firstHalf
            int randomNum;                                                      //For holding random number of the second Half
            int min;                                                            //min starting zip
            int max;                                                            //max starting zip

            Dictionary<String, int> zipSingleChar                               //Dictionary of starting zips with no range
                = new Dictionary<String, int>()
            {
                {"CT", 06}, {"MA", 027}, {"MT", 59 }, {"ND", 58 }, {"OR", 97 },
                {"SC", 29 }, {"SD", 57}, {"VT", 05 }, {"UT", 84}
            };
            Dictionary<String, int> Min = new Dictionary<String, int>()         //Dictionary of minimum starting zips
            {
                {"AL", 35}, {"AZ", 85}, {"CO", 80}, {"GA", 30}, {"IN", 46},
                {"KS", 66}, {"MI", 48}, {"NE", 68}, {"NJ", 07}, {"NC", 27},
                {"OK", 73},{"RI", 028},{"FL", 32}, {"IA", 50}, {"IL", 60},
                {"KY", 40}, {"MO", 63}, {"OH", 43}, {"NY", 10}, {"TX", 75 },
                {"WI", 53}, {"HI", 967}, {"AK", 995}, {"CA", 900}, {"DE", 206},
                {"ID", 832}, {"LA", 700}, {"ME", 039}, {"MD", 206}, {"MN", 550},
                {"MS", 386}, {"NV", 889}, {"NH", 030}, {"NM", 870}, {"PA", 150},
                {"TN", 370}, {"VA", 220}, {"WA", 980}, {"WV", 247}, {"WY", 820}
            };

            Dictionary<String, int> Max = new Dictionary<String, int>()         //Dictionary of maximum starting zips
            {
                {"AL", 36}, {"AZ", 86}, {"CO", 81}, {"GA", 31}, {"IN", 47},
                {"KS", 67}, {"MI", 49}, {"NE", 69}, {"NJ", 08}, {"NC", 28},
                {"OK", 74},{"RI", 029},{"FL", 34}, {"IA", 52}, {"IL", 62},
                {"KY", 42}, {"MO", 65}, {"OH", 45}, {"NY", 14}, {"TX", 79},
                {"WI", 54}, {"HI", 968}, {"AK", 999}, {"CA", 961}, {"DE", 219},
                {"ID", 839}, {"LA", 715}, {"ME", 049}, {"MD", 219}, {"MN", 567},
                {"MS", 399}, {"NV", 899}, {"NH", 038}, {"NM", 884}, {"PA", 196},
                {"TN", 385}, {"VA", 246}, {"WA", 994}, {"WV", 269}, {"WY", 831}
            };

            if (stateAbbr == "CT" || stateAbbr == "MA" || stateAbbr == "MT"
                || stateAbbr == "ND" || stateAbbr == "OR" || stateAbbr == "SC"
                || stateAbbr == "SD" || stateAbbr == "VT" || stateAbbr == "UT") // if (assigned state has starting zips with no range)
            {
                firstHalf = zipSingleChar[stateAbbr].ToString();                // assign firsthalf

                length = firstHalf.Length;                                      //firstHalf Length

                if (stateAbbr == "MA" || stateAbbr == "CT" || stateAbbr == "VT") // Corrections for states with leading zero
                {
                    firstHalf = "0" + firstHalf;
                }

                if (length == 2)                                                // For states with 2 starting digits
                {
                    randomNum = rand.Next(000, 1000);                           //getting random number between 0 and 999
                    SecHalf = randomNum.ToString();                             //assign second half of zip from the random number picked

                    if (SecHalf.Length == 1)                                    // Corrections for random number with leading zero
                    {
                        SecHalf = "00" + SecHalf;
                    }
                    if (SecHalf.Length == 2)                                    // Corrections for random number with leading zero
                    {
                        SecHalf = "0" + SecHalf;
                        
                    }

                    zipCode = firstHalf + SecHalf;                              //concatenating strings
                }

                if (length == 3)                                                // For states with 3 starting digits
                {
                    randomNum = rand.Next(00, 100);                             //getting random number between 0 and 99
                    SecHalf = randomNum.ToString();                             //assign second half of zip from the random number picked

                    if (SecHalf.Length == 1)                                    // Corrections for random number with leading zero
                    {
                        SecHalf = "00" + SecHalf;
                    }
                    if (SecHalf.Length == 2)                                    // Corrections for random number with leading zero
                    {
                        SecHalf = "0" + SecHalf;
                    }

                    zipCode = firstHalf + SecHalf;                              //concatenating strings
                }

            }
            else
            {                                                                   // if (assigned state has starting zip range)

                min = Min[stateAbbr];                                           //get states min zip starting half
                max = Max[stateAbbr];                                           //get states max zip starting half
                firstHalf = rand.Next(min, max).ToString();                     //assing first half from random number picker using min and max
                length = firstHalf.Length;                                      //getting length of first half

                if (stateAbbr == "NJ" || stateAbbr == "RI" || stateAbbr == "ME"
                    || stateAbbr == "NH")                                       // Corrections for states with leading zero
                {
                    firstHalf = "0" + firstHalf;
                }

                if (length == 2)                                                // For states with 2 starting digits
                {
                    randomNum = rand.Next(000, 1000);                           //getting random number between 0 and 999
                    SecHalf = randomNum.ToString();                              //assign second half of zip from the random number picked

                    if (SecHalf.Length == 1)
                    {
                        SecHalf = "00" + SecHalf;
                    }
                    if (SecHalf.Length == 2)
                    {
                        SecHalf = "0" + SecHalf;
                    }

                    zipCode = firstHalf + SecHalf;
                }

                if (length == 3)                                                // For states with 3 starting digits
                {
                    randomNum = rand.Next(00, 100);                             //getting random number between 0 and 99
                    SecHalf = randomNum.ToString();                              //assign second half of zip from the random number picked

                    if (SecHalf.Length == 1)                                    // Corrections for random number with leading zero
                    {
                        SecHalf = "00" + SecHalf;
                    }
                    if (SecHalf.Length == 2)                                    // Corrections for random number with leading zero
                    {
                        SecHalf = "0" + SecHalf;
                    }

                    zipCode = firstHalf + SecHalf;                               //concatenating strings
                }


            }

            return zipCode;                                                     //return zip
        }

        public override String ToString()                                       //ToString method for output 
        {
            String input = "";
            input = "\nAddress: " + houseNumber + " " + streetName +
                " " + streetType + "\n\t" + city + ", " + stateAbbr +
                " " + zipCode;
            return input;
        }
    }
}
