using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Calculator_in_C_



//STATIC CONSTRUCTOR KYA HOTA HAI
//IT'S USED TO INITIALIZE STATIC VARIABLES OF THE CLASS
//YE EK HI BAAR CALL KIA JATA HAI 
//YE KOI ACCESS SPECIFIER OR PARAMETER USE NI KRTA
//CLR USE KIA JAAT HAI STATIC CONSTRUCTOR KO CALL KRTA HAI 

{
    internal class staticConstuctor
    {

        //EXAMPLE 
        public static string PersonName;
        public static int PersonAge;



        //YE NICHE DO CONSTRUCTOR HEIN, BUT WE NED TO UNDERSTAND AS WE CAN'T 
        //CREATE AN OBJECT FOR STATIC CONSTRUCTOR SO WHEN WE CALL AN DEAFULT CONSTRUCTOR 
        // BY CEATING IT'S OBJECT, FIRST THAT STATIC CONSTRUTOR WILL RUN AND THEN DEFAULT CONS


        //IT'S STATIC CONS
        static void staticConstructor()
        {
            PersonName = "inshaw";
            PersonAge = 23;
            Console.WriteLine("I'M STATIC ");

        }

        //IT'S DEFAULT CONS
        public void staticConstrutor()
        {
            Console.WriteLine("default constructor invoked");
        }

        public static void GetDetails()
        {
            Console.WriteLine("Person's name is:{0} ", PersonName);
            Console.WriteLine("Person's age is:{0} ", PersonAge);

        }

    }
}