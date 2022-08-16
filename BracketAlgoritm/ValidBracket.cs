using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketAlgoritm
{
    internal class ValidBracket
    {
        public bool IsValid(string line)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char i in line)
            {
                switch(i)
                {
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '(':
                        stack.Push(')');
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != i) return false;
                        break;
                     default:
                        break;
                }
            }
            return stack.Count == 0;
        }
    }
}
