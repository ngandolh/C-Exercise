using System;

// Lớp trừu tượng Employee
public abstract class Employee
{
    public abstract void Working();
}

// Lớp Developer kế thừa từ Employee và triển khai phương thức Working
public class Developer : Employee
{
    public override void Working()
    {
        Console.WriteLine("Developer is coding...");
    }
}

// Lớp Tester kế thừa từ Employee và triển khai phương thức Working
public class Tester : Employee
{
    public override void Working()
    {
        Console.WriteLine("Tester is testing...");
    }
}

// Lớp Salesman kế thừa từ Employee và triển khai phương thức Working
public class Salesman : Employee
{
    public override void Working()
    {
        Console.WriteLine("Salesman is selling...");
    }
}

//class SingleResponsibility
//{
//    static void Main(string[] args)
//    {
//        Employee dev = new Developer();
//        Employee tester = new Tester();
//        Employee salesman = new Salesman();

//        dev.Working();      // Output: Developer is coding...
//        tester.Working();   // Output: Tester is testing...
//        salesman.Working(); // Output: Salesman is selling...
//    }
//}
