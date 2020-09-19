using System;
namespace FakerClassLibrary
{
    public abstract class Person
    {
        //Address has = new Address();
        private Address address { get; set; }
        private LastName lastName { get; set; }
        private DateTime birthdate { get; set; }

        public abstract void SetLastName(LastName lastName);

        public abstract void SetBirthdate(DateTime birthDate);

        public abstract LastName GetLastName();

        public abstract DateTime GetBirthdate();

        public abstract int GetAge();

        public abstract string ToString();


    }
}
