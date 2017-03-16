//Problem 1. StringBuilder.Substring

//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.


namespace SB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public static class SBExtension
    {
        public static StringBuilder SubString(this StringBuilder str, int index, int length)
        {
            var result = new StringBuilder();
            if (index >= 0 && index <= length)
            {
                for (int i = index; i <= length; i++)
                {
                    result.Append(str[i]);
                    result.ToString(); 
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException("There is no sutch index in the collection!");
            }
        }
    }
}
