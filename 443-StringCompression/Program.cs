namespace _443_StringCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompressSolution compressSolution = new CompressSolution();
            char[] chars1 = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }; // 6
            var result = compressSolution.Compress(chars1);
            Console.WriteLine(result);

            Console.WriteLine("==========");

            char[] chars2 = new char[] { 'a' }; //1
            var result2 = compressSolution.Compress(chars2);
            Console.WriteLine(result2);

            Console.WriteLine("==========");

            char[] chars3 = new char[] { 'a', 'b', 'c' };
            var result3 = compressSolution.Compress(chars3);
            Console.WriteLine(result3);

            Console.WriteLine("==========");

            char[] chars4 = new char[] { 'a', 'a', 'a', 'a', 'a', 'b' };
            var result4 = compressSolution.Compress(chars4);
            Console.WriteLine(result4);
            Console.WriteLine("==========");

        }
    }
}
