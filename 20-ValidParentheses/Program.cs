namespace _20_ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public bool ValidParentheses(string s)
    {
        List<string> Data = new List<string> { ")", "(", "{", "}", "[", "]" };
        bool result = false;
        int count = 0;
        foreach (var item in Data)
        {
            if (item.Contains(s))
            {
                result = true;
                count++;
            }
            else
            {
                result = false;
            }
        }
        return result;
    }
}
