using System;
namespace FakerClassLibrary
{
    public abstract class Person
    {

        private Address address { get; set; }
        private LastName lastName { get; set; }
        private DateTime birthdate { get; set; }

        public void SetLastName(LastName lastName)
        {
        }

        public void SetBirthdate(DateTime birthDate)
        {
        }

        public LastName GetLastName()
        {
            return lastName;
        }

        public DateTime GetBirthdate()
        {
            return birthdate;
        }

        public int GetAge()
        {
            int age = 0;
            return age;
        }

        public string ToString()
        {
            String input = "";
            return input;
        }

    }
}
