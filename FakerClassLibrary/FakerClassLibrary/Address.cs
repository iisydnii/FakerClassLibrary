using System;
using System.Collections.Generic;
using System.Linq;

namespace FakerClassLibrary
{
    public class Address
    {
        Random rand = new Random();
        List<String> street;
        List<String> City;
        List<String> StateAbbr = new List<string>();
        Dictionary<String, String> StateDictionary;
        String stateAbbr;
        public Address()
        {
            street = new List<string>() { "Sassafras", "Jason Pollke",
                    "Hamilton", "Rainbow", "Rim", "Randolphe", "University",
                    "Mayflower", "Jefferson", "Jackson" };

            City = new List<string>() { "Bristol", "Johnson city",
                    "Abingdon", "Springfield", "kingsprt", "Mystic Falls",
                    "Fall Branch", "Paris", "Damacus", "Nashville" };
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.streetType = streetType;
            this.city = city;
            this.state = GetStateAbbr();
            this.zipCode = AssignZipCode();
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
        private String city
        {
            get { return city; }
            set
            {
                city = City[rand.Next(City.Count)];
            }
        }
        private String state { get; set; }

        private String zipCode { get; set; }

        private Dictionary<String, String> stateDictionary
        {
            get { return StateDictionary; }
            set
            {
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
            }
        }

        public String GetStateAbbr()
        {
            foreach (KeyValuePair<string, string> entry in StateDictionary)
            {
                StateAbbr.Add(entry.Key);
            }
            int index = rand.Next(StateAbbr.Count);
            stateAbbr = StateAbbr[index];

            AssignStateName();
            AssignZipCode();

            return stateAbbr;
        }

        private String AssignStateName()
        {
            state = StateDictionary[stateAbbr];

            return state;
        }

        private String AssignZipCode()
        {
            String firstHalf;
            int length;
            int randomNum;
            int min;
            int max;

            Dictionary<String, int> zipSingleChar = new Dictionary<String, int>()
            {
                {"CT", 06}, {"MA", 027}, {"MT", 59 }, {"ND", 58 }, {"OR", 97 },
                {"SC", 29 }, {"SD", 57}, {"VT", 05 }, {"UT", 84}
            };
            Dictionary<String, int> Min = new Dictionary<String, int>()
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

            Dictionary<String, int> Max = new Dictionary<String, int>()
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
                || stateAbbr == "SD" || stateAbbr == "VT" || stateAbbr == "UT")
            {
                firstHalf = zipSingleChar[stateAbbr].ToString();
                length = firstHalf.Length;

                if (length == 2)
                {
                    randomNum = rand.Next(000, 1000);
                    zipCode = firstHalf + randomNum;
                }

                if (length == 3)
                {
                    randomNum = rand.Next(00, 100);
                    zipCode = firstHalf + randomNum;
                }

            }
            else
            {

                firstHalf = Min[stateAbbr].ToString();
                min = Min[stateAbbr];
                max = Max[stateAbbr];
                length = firstHalf.Length;

                firstHalf = rand.Next(min, max).ToString();

                if (length == 2)
                {
                    randomNum = rand.Next(000, 1000);
                    zipCode = firstHalf + randomNum;
                }

                if (length == 3)
                {
                    randomNum = rand.Next(00, 100);
                    zipCode = firstHalf + randomNum;
                }


            }

            return zipCode;
        }

        public override String ToString()
        {
            String input = "";
            input = "\n\tAddress: " + houseNumber + " " + streetName +
                " " + streetType + "\n" + city + ", " + stateAbbr +
                " " + zipCode;
            return input;
        }
    }
}
