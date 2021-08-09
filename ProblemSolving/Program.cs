using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome("`l;`` 1o1 ??;l`"));
        }

        public static bool IsPalindrome(string s)
        {
            List<char> withOuthSpecialChar = new List<char>();


            char[] filteredChars = {'`',' ',',', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', '{', '}', '[', ']', ':', ';', '"', '\'', '?', '/', '.', '<', '>', '\\', '|' ,'-'};
            var normal="";
            string reverse ="";
            s = s.ToUpper();
           

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(filteredChars,s[i]);
               
                if(index != -1)
                {
                    continue;
                }
                else
                {
                    withOuthSpecialChar.Add(s[i]);
                    normal += s[i]; 
                }
               
            }


            for (int i = withOuthSpecialChar.Count -1; i >= 0; i--)
            {
                reverse += withOuthSpecialChar[i];
            }

            if (normal == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

    }

}

