namespace _392_IsSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsSubsequenceSolution isSubsequenceSolution = new IsSubsequenceSolution();
            string s = "abc";
            string t = "ahbgdc";
            bool result = isSubsequenceSolution.IsSubsequence(s, t);
            Console.WriteLine("IsSubsequence: " + result);

            Console.WriteLine("**********************");

            string s2 = "axc";
            string t2 = "ahbgdc";
            bool result2 = isSubsequenceSolution.IsSubsequence(s2, t2);
            Console.WriteLine("IsSubsequence: " + result2);
        }
    }
}
