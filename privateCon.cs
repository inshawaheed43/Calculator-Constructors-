using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_in_C_
{
    internal class privateCon
    {

        //AGR KISI CLASS MEIN PRIVATE CONSTRUCTOR HAI TO
        //HUM USKA INSTANCE OR OBJECT NI BNA SKATE
        //us class ko hum inherit or derieved bhi ni krwa skte

        private privateCon()
        {

        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        } 

    }
}
