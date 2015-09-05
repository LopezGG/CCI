using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview

{
    class Program
    {
        static void Main (string[] args)
        {
            string s = "Jesus Help Me";
            string s1 = "Jesus pelHdMe";

            //implement a algorithm to see if a string has all unique characters
            bool result = StringMani.uniqueChar("Good");
            //Console.WriteLine(result);

            //algorithm to reverse a string
            //Console.WriteLine(StringMani.ReverseString(s));
            
            //find if one string is permutation of another
            Console.WriteLine(StringMani.Permutation(s, s1));

            //Replace all Spaces with '%20'
            //string s2 = StringMani.ReplaceSpace(s);
            //Console.WriteLine(s2);
            //Basic string compression using counts of repeated chars
            
            Console.ReadLine();
        }
    }
}
