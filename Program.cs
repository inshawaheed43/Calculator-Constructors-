using Calculator_in_C_;



//IT'S THE MAIN TO RUN OVER ALL FILES OF OTHER CLASSES 
class Over
{

    public void Main()
    {
        //Constuct obj = new Constuct(23, "Insha");

        //FOR CONSTRUCTOR IN INHERITANCE

        //DerivedClass inherit1 = new DerivedClass();




        //COPY CONSTRUCTOR AND PRIVATE CONS
        // OK SO WE'VE COPIED THAT DATA USED IN OBJ1 AND IT'S BEING COPIED AND USEED IN OBJ2

        //copyCon obj1 = new copyCon("Insha", 26);
        //obj1.getData();

        //copyCon obj2 = new copyCon(obj1);
        //obj2.getData();



        //FOR PRIVATE CONSTRUCTOR, WE CAN'T CREATE IT'S OBJECT
        //privateCon.getTime();


        //FOR STATIC CONSTRUCTOR 
        //staticConstuctor obj3 = new staticConstuctor();
        //obj3.staticConstrutor();


    }
}


//class Calcultor
//{


//    public static void Addition(int a, int b)
//    {
//        int result = a + b;
//        Console.WriteLine(result);
//    }

//    public static void Subtraction(int a, int b)
//    {
//        int result = a - b;
//        Console.WriteLine(result);
//    }
//    public static void Multiplication(int a, int b)
//    {
//        int result = a * b;
//        Console.WriteLine(result);
//    }

//    public static void Division(int a, int b)
//    {
//        int result = a / b;
//        Console.WriteLine(result);
//    }

//    internal void Main()
//    {
//        Console.WriteLine("Enter 1st number:");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter 2nd number:");
//        int num2 = int.Parse(Console.ReadLine());


//        Console.WriteLine("Enter operator: + - * /: ");
//        string op = Console.ReadLine();




//        if (op == "+")
//        {
//            Calcultor.Addition(num1, num2);
//        }
//        else if (op == "-")
//        {
//            Calcultor.Subtraction(num1, num2);
//        }
//        else if (op == "*")
//        {
//            Calcultor.Multiplication(num1, num2);
//        }
//        else if (op == "/")
//        {
//            Calcultor.Division(num1, num2);
//        }
//        else
//        {
//            Console.WriteLine("Invalid Operator");
//        }









//    }


//}



////CONSTRUCTOR


//class Const
//{
//    internal void Main()
//    {
//        Const c = new Const();
//        Console.ReadLine();
//    }
//    //IT'S A DEFAULT CONSTRUSTOR AS IT CONTAINS NO PARAMETER AND ARGUMENTS

//    public Const()
//    {
//        Console.WriteLine("Constructor invokes........");
//    }




//}
//public class Employees
//{
//    int empId;
//    string empName;
//    int empAge;


//    public Employees(int empId, string empName, int empAge)
//    {
//        this.empId = empId;
//        this.empName = empName;
//        this.empAge = empAge;


//    }

//    public int getId()
//    {
//        return this.empId;
//    }
//    public string getName()
//    {
//        return this.empName;
//    }
//    public int getAge()
//    {
//        return this.empAge;
//    }
//    internal void Main()
//    {
//        Employees p = new Employees(11, "Insha", 23);
//        Console.WriteLine("Employee's Id is : {}", p.getId);
//        Console.WriteLine("Employee's Name : {}", p.getName);
//        Console.WriteLine("Employee's Age : {}", p.getAge);

//    }

//}

