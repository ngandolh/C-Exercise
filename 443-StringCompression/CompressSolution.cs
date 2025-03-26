using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _443_StringCompression
{
    internal class CompressSolution
    {
        public int Compress(char[] chars)
        {
            if (chars.Length == 1)
            {
                return 1;
            }
            int writeIndex = 0;
            int i = 0;

            while (i < chars.Length)
            {
                int count = 0;
                char currentChar = chars[i];

                while (i < chars.Length && chars[i] == currentChar)
                {
                    i++;
                    count++;
                }

                chars[writeIndex++] = currentChar;

                if (count > 1)
                {
                    foreach (char c in count.ToString())
                    {
                        chars[writeIndex++] = c;
                    }
                }
            }

            return writeIndex;
        }
    }
}
