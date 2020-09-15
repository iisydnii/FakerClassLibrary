using System;
namespace FakerClassLibrary
{
    public abstract class Person
    {
        public abstract void SetLastName(string lastName);

        public abstract void SetBirthdate(string birthDate);

        public abstract void GetLastName();

        public abstract void GetBirthdate();

        public abstract int GetAge();

        public abstract string ToString();

    }
}
