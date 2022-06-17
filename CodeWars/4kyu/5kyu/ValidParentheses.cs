using System;
using System.Collections.Generic;
using System.Text;

namespace _5kyu
{
    public class ValidParentheses
    {
        public bool Valid(string input)
        {
            int token = 0;

            for (int i = 0; i < input.Length && token >= 0; i++)
            {
                token += (input[i] == '(') ? 1 : (input[i] == ')') ? -1 : 0;
            }

            return token == 0;

        }
    }
}
