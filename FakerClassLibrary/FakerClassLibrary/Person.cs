////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: FakerClassLibrary
// File Name: Person.cs
// Description: Abstract class is the parent of Female and Male
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 09/19/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
namespace FakerClassLibrary
{
    public abstract class Person
    {
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
