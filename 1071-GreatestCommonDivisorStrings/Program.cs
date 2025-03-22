namespace _1071_GreatestCommonDivisorStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GcdOfStringsSolution gcdOfStringsSolution = new GcdOfStringsSolution();
            string str1 = "ABCABC";
            string str2 = "ABC";
            string result = gcdOfStringsSolution.GcdOfStrings(str1, str2);
            System.Console.WriteLine(result);

            str1 = "ABABAB";
            str2 = "ABAB";
            result = gcdOfStringsSolution.GcdOfStrings(str1, str2);
            System.Console.WriteLine(result);

            str1 = "LEET";
            str2 = "CODE";
            result = gcdOfStringsSolution.GcdOfStrings(str1, str2);
            System.Console.WriteLine(result);

            str1 = "ABCDEF";
            str2 = "AFEDSF";
            result = gcdOfStringsSolution.GcdOfStrings(str1, str2);
            System.Console.WriteLine(result);

        }
    }
}
