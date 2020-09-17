using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    public class Address
    {
        Random rand = new Random();
        List<String> street;
        List<String> City;
        Dictionary<String, String> StateDictionary;
        public Address()
        {
            street = new List<string>() { "Sassafras", "Jason Pollke",
                "Hamilton", "Rainbow", "Rim", "Randolphe", "University",
                "Mayflower", "Jefferson", "Jackson" };

            City = new List<string>() { "Bristol", "Johnson city",
                "Abingdon", "Springfield", "kingsprt", "Mystic Falls",
                "Fall Branch", "Paris", "Damacus", "Nashville" };

            StateDictionary = new Dictionary<String, String>() {
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
        
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.streetType = streetType;
            this.city = city;
        }

        private uint houseNumber
        {
            get { return houseNumber; }
            set
            {
                houseNumber = (uint)rand.Next(1, 5001);
            }
        }

        private String streetName
        {
            get { return streetName; }
            set
            {
                streetName = street[rand.Next(street.Count)];
            }
        }
        private StreetType streetType
        {
            get { return streetType; }
            set
            {
                var someStreet = new List<StreetType>();
                foreach (StreetType street in Enum.GetValues                    //Looping through the enums
                    (typeof(StreetType)))
                {
                    someStreet.Add(street);                                     //adding the enums to list
                }
                streetType = someStreet[rand.Next(someStreet.Count)];
            }
        }
        private String city {
            get { return city; }
            set
            {
                city = City[rand.Next(City.Count)];
            }
        }
        private String state { get; set; }
        private String zipCode { get; set; }
        private Dictionary<String, String> stateDictionary { get; set; }

        public String GetStateAbbr()
        {
            
        }
        public String toString()
        {
            String input = "";
            return input;
        }
    }
}
