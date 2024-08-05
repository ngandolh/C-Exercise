using System;
using System.Collections;

public class ArrayListDemo
{
    //ArrayList is non-generic collection.
    //Same a array but increase dynamically.
    //Unknown type and size data.
    //URL: https://www.tutlane.com/tutorial/csharp/csharp-arraylist
    public static void ArrayListDemoModify()
	{
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Do");
        arrayList.Add(4.5);
        arrayList.Add(true);
        arrayList.Add(null);

        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("===================================================");
        //Đảo chuỗi
        Console.WriteLine("Reverse");
        arrayList.Reverse();
        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("===================================================");
        //	It is useful to get or set the number of elements an arraylist can contain.
        arrayList.Capacity = 5;
        foreach (var i in arrayList)
        {
            Console.WriteLine(i);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ArrayListDemoModify();
        }
    }
}
