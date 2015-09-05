﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview
{
    class StringMani
    {
        public static  Boolean uniqueChar(string s)
        {
            //assume ascii
            if (s.Length == 1)
                return true;
            if (s.Length > 256)
                return false;
            if (String.IsNullOrWhiteSpace(s))
                throw new Exception("Null string");
            Boolean[] flag = new Boolean[256];
            foreach (var c in s)
            {
                if (flag[c])
                    return false;
                flag[c] = true;
            }
            return true;
        }
        public static String ReverseString (String s)
        {
            char[] sarray = s.ToCharArray();
            sarray = Reverse(sarray);
            return String.Join("", sarray);

        }
        public static char[] Reverse(char[] sarray)
        {
            if (sarray.Count() ==0)
                throw new Exception("ha a null space");
            int lower = 0;
            int upper = sarray.Count()-1;
            char temp;
            while(lower < upper)
            {
                temp = sarray[lower];
                sarray[lower++] = sarray[upper];
                sarray[upper] = temp;
            }
            return sarray;
        }

        public static bool Permutation(string s1, string s2)
        {
            if (String.IsNullOrWhiteSpace(s1) || String.IsNullOrWhiteSpace(s2))
                throw new Exception("null string");
            if (s1.Length != s2.Length)
                return false;
            int[] charCount = new int[256];
            int temp;
            foreach (var c in s1)
            {
                charCount[c] = charCount[c] + 1;
            }
            foreach (var c in s2)
            {
                temp = charCount[c] - 1;
                if (temp < 0)
                    return false;
                else
                    charCount[c] = temp;
            }
            return true;
        }

        public static String ReplaceSpace(String s)
        {
            if (String.IsNullOrWhiteSpace(s))
                throw new Exception("empty string");
            int count = 0;
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                if (s[i] == ' ')
                    ++count;
            }
            int newlength = length + 2 * count;
            char[] sarray = new char[newlength];
            char temp;

            for (int i = length -1; i >= 0; i--)
            {
                temp = s[i];
                if (temp == ' ')
                {
                    sarray[--newlength] = '0';
                    sarray[--newlength] = '2';
                    sarray[--newlength] = '%';
                }
                else
                    sarray[--newlength] = temp;
                
            }
            return String.Join("",sarray);
        }

    }
}
