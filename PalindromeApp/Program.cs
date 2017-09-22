using System;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter then string:");
            string s = Console.ReadLine();
            string revs = "";
            char[] str1 = s.ToCharArray();
            Array.Reverse(str1);
            revs = new string(str1);
            if(revs==s)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }    
}
