////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: FakerClassLibrary
// File Name: Program.cs
// Description: driver
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 09/19/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace FakerClassLibrary
{
    class Program
    {
        


        static void Main(string[] args)
        {
            
            Console.WriteLine("*--------------------------------------------" +
                "-----------*");
            Female one = new Female();
            Console.WriteLine(one.ToString());
            Address oneAddress = new Address();
            

            Female two = new Female();
            Console.WriteLine(two.ToString());
            Address twoAddress = new Address();
            

            Male three = new Male();
            Console.WriteLine(three.ToString());
            Address threeAddress = new Address();
            

        }
    }
}
