using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_in_C_
{
    internal class copyCon
    {

        string name;
        int age;
        public copyCon(string name, int age )
        {
            this.name = name;
            this.age = age;
        }



        //YE HAI COPY CONSTRUCTOR OR ISSE TB CALL KRTE HEIN JB HUMENE COPY USE KRNI 
        // A CONSTRUCTOR KI
        public copyCon (copyCon h)
        {
            this.name = h.name;
            this.age = h.age;
        }

        public void getData()
        {
            Console.WriteLine("Name:{0}", name);

            Console.WriteLine("Age :{0}", age);
        }
    }
}
//THE COPY CONSTRUCTOR SHOULD BE A PARAMETERIZED CONSTRUCTOR WHICH CONTAIN THE 
// PARAMETER OF SAME CLASS TYPE



