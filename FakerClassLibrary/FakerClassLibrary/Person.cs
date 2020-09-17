using System;
namespace FakerClassLibrary
{
    public abstract class Person
    {

        public abstract LastName lastName { get; set; }

        public abstract DateTime birthdate { get; set; }

        public abstract void SetLastName(LastName lastName);

        public abstract void SetBirthdate(DateTime birthDate);

        public abstract LastName GetLastName();

        public abstract DateTime GetBirthdate();

        public abstract int GetAge();

        public abstract string ToString();

    }
}
