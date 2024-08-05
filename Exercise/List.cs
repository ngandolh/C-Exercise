using System;

public class ListDemo
{
    //Represents a strongly typed list of objects that can be accessed by index.
    //Provides methods to search, sort, and manipulate lists.
    public static void Demo()
    {
        //Create list
        List<string> citiesList = new List<string>();

        //Add each item
        citiesList.Add("New York");
        citiesList.Add("Madrid");
        citiesList.Add("Ho Chi Minh");
        citiesList.Add("Tokyo");
        citiesList.Add("Paris");

        foreach (string city in citiesList)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("=======================================================");
        Console.WriteLine("AddRange");
        //Add all item 
        string[] listRange = { "San Fransico", "Bayner Munich", "Roma", "Quatar", "Madrid" };
        citiesList.AddRange(listRange);

        foreach (string city in citiesList)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("=======================================================");
        Console.WriteLine("Remove");
        //Remove item
        citiesList.Remove("Quatar");

        foreach (string city in citiesList)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine("=======================================================");
        Console.WriteLine("Clear");

        // Sử dụng Clear để xóa toàn bộ danh sách
        citiesList.Clear();
        Console.WriteLine("List after Clear:");
        foreach (string city in citiesList)
        {
            Console.WriteLine(city); // Không in ra gì vì danh sách trống
        }

        citiesList.AddRange(new List<string> { "New York", "Madrid", "Ho Chi Minh", "Tokyo", "Paris" });

        // Sử dụng RemoveAll để xóa các phần tử thỏa mãn điều kiện
        citiesList.RemoveAll(city => city.StartsWith("T"));
        Console.WriteLine("\nList after RemoveAll cities starting with 'T':");
        foreach (string city in citiesList)
        {
            Console.WriteLine(city); // Output: New York, Madrid, Ho Chi Minh, Paris
        }

        //Conclusion:
        //List can add duplicated.
        //Clear: Delete the entire list, making the list empty.
        //Removeall: Delete the elements that meet a specific condition, retain the elements that do not satisfy the condition.

    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //        Demo();
    //    }
    //}
}
