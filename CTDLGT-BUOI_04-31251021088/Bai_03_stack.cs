using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BUOI_04_31251021088
{

    internal class Bai_03_stack
    {
        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if (c == ')' && top != '(') return false;
                    if (c == ']' && top != '[') return false;
                    if (c == '}' && top != '{') return false;
                }
            }

            return stack.Count == 0;
        }

        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s == null) return;
            s = s.Trim();

            if (IsValid(s))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
