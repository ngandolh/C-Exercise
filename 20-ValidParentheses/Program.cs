using System;
using System.Collections.Generic;

namespace _20_ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Console.WriteLine(IsValid("()"));       // Output: true
            Console.WriteLine(IsValid("()[]{}"));   // Output: true
            Console.WriteLine(IsValid("(]"));       // Output: false
            Console.WriteLine(IsValid("([])"));     // Output: true
        }

        public static bool IsValid(string s)
        {
            // Stack to keep track of opening brackets
            Stack<char> stack = new Stack<char>();

            // Dictionary to map closing brackets to their corresponding opening brackets
            Dictionary<char, char> bracketMap = new Dictionary<char, char>()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (char c in s)
            {
                if (bracketMap.ContainsKey(c))
                {
                    char topElement = stack.Count > 0 ? stack.Pop() : '#';

                    if (topElement != bracketMap[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            // If the stack is empty, all brackets were matched; otherwise, return false
            return stack.Count == 0;
        }

        //Top 1: 0ms
        //public bool IsValid(string s)
        //{
        //    char[] stack = new char[s.Length];
        //    int top = -1;

        //    foreach (char c in s)
        //    {
        //        // Öffnende Klammern werden "gepusht"
        //        if (c == '(' || c == '{' || c == '[')
        //        {
        //            stack[++top] = c;
        //        }
        //        // Schließende Klammern werden geprüft
        //        else
        //        {
        //            if (top == -1 ||
        //               (c == ')' && stack[top] != '(') ||
        //               (c == '}' && stack[top] != '{') ||
        //               (c == ']' && stack[top] != '['))
        //            {
        //                return false;
        //            }
        //            top--; // "Pop"
        //        }
        //    }

        //}
    }
