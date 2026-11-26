using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_in_C_
{
    internal class Constuct
    { string name;
        int age;


        //CONSTRUCTOR OVERLOADING MEIN AP SAME CONSTRUCTOR BNA SKTE HO BUT WITH 
        // DIFFERENT TYPES, BUT BUT YOUR PARAMETER NUMBERS CAN BE CHANGE

//OK WE CAN CREATE MULTIPLE CONSTRUCTOR IN A  CLASS 
// BUT IT'S TYPE SHOULD BE DIFFERENT, MEANS IF YOU'VE MADE A DEFAULT CONSTRUCTOR
// THEN OTHER ONE WOULD BE PARAMETERIZED CONSTRUCTOR




         internal void consOver()
        {

        }
        public Constuct()
        {
            Console.WriteLine("this is c1");
        }
        public Constuct(int age, string name)
        {
             this.age = age;
            this.name = name;

            Console.WriteLine("This is parameterized constructor: {}", age + name);



        }





    }
}

// CONSTRUCTOR IN INHERITANCE

class BaseClass
{  
    public BaseClass(string message)

    {
        Console.WriteLine(message);
    }
}

class DerivedClass : BaseClass
{

    public DerivedClass() : base("Hellollllllllllllllllloooooooooooooooooooyyyyyyyyyyyy")
    {
        Console.WriteLine("this is the constructor of derived class!");

    }
}