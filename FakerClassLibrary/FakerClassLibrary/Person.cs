using System;
namespace FakerClassLibrary
{
    public abstract class Person
    {


        private LastName lastName;
        private DateTime birthdate;

        public abstract void SetLastName(LastName lastName);

        public abstract void SetBirthdate(DateTime birthDate);

        public abstract LastName GetLastName();

        public abstract DateTime GetBirthdate();

        public abstract int GetAge();

        public abstract string ToString();

    }
}
