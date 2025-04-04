namespace _1657_DetermineTwoStringsAreClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CloseStringsSolution closeStringsSolution = new CloseStringsSolution();
            //string word1 = "abc";
            //string word2 = "bca";
            //bool result = closeStringsSolution.CloseStrings(word1, word2);
            //Console.WriteLine($"Are the strings '{word1}' and '{word2}' close? {result}"); //Expected output: true

            //string word3 = "cabbba";
            //string word4 = "abbccc";
            //bool result2 = closeStringsSolution.CloseStrings(word3, word4);
            //Console.WriteLine($"Are the strings '{word3}' and '{word4}' close? {result2}"); //Expected output: true

            string word5 = "uau";
            string word6 = "ssx";
            bool result3 = closeStringsSolution.CloseStrings(word5, word6);
            Console.WriteLine($"Are the strings '{word5}' and '{word6}' close? {result3}"); //Expected output: false


        }
    }
}
