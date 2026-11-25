class Calcultor {


    public static void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine(result);
    }

    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine(result);
    }
    public static void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine(result);
    }

    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine(result);
    }

    static void Main()
    {
        Console.WriteLine("Enter 1st number:");
     int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number:");
        int num2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter operator: + - * /: ");
        string op = Console.ReadLine();




        if (op == "+")
        {
           Calcultor.Addition(num1, num2);
        }
        else if (op == "-")
        {
            Calcultor.Subtraction(num1, num2);
        }
        else if (op == "*")
        {
            Calcultor.Multiplication(num1, num2);
        }
        else if (op == "/")
        {
            Calcultor.Division(num1, num2);
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }
    }


}
