using System;

namespace PalindromeApp
{
    public class Palindrome
    {
        public bool IsAPalindrome(string s)
        {
            string  revs = "";
            char[] str1 = s.ToCharArray();
            Array.Reverse(str1);
            revs = new string(str1);
            if(revs==s)
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
