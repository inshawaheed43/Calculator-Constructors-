using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_in_C_
{

    //THIS IS FOR STATIC CLASS WE CAN'T CREATE AN OBJECT OR WE CAN'T INHERITED IT AGAIN
    //IT ONLY CONTAIN ONLY STATIC MEMBERS
    internal class Product
    {
        internal static void Main()
        {

            staticClass.getProductDetails();
            staticClass.getDiscount();
        }

    }


    internal static class staticClass
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;


        //YE STATIC CLASS KA CONSTRUCTOR HAI
        static staticClass()
        {
            ProductId = 111;
            ProductName = "Lotion";
            ProductPrice = 500 ;
            
        }

        //YE METHOD HAI 
        public static void getProductDetails()
        {
            Console.WriteLine("The Product Id {0}", ProductId);
            Console.WriteLine("The Product Price {0}", ProductPrice);

            Console.WriteLine("The Product Name {0}", ProductName);

        }

        //YE EK OR METHOD HAI 
        public static void getDiscount()

        {

            int d_amount = ProductPrice / 10;
            Console.WriteLine("Your discounted price is: {0}", d_amount);
            Console.WriteLine("Total cost of product is {0}", (ProductPrice - d_amount));
            //Console.WriteLine("The Product Id {0}", ProductId);
            //Console.WriteLine("The Product Price {0}", ProductPrice);

            //Console.WriteLine("The Product Name {0}", ProductName);

        }


    }

    

}

