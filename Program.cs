using System;
using System.Text.RegularExpressions;

namespace pr_12._09._22
{
    class Program
    {
        public static string isAnagramm(string str1, string str2)
        {
            string pattern = @"\.+?|\,+?|\ +?|\-+?|\:+?|\!+?";
            str1 = (Regex.Replace(str1, pattern, String.Empty));
            str2 = (Regex.Replace(str2, pattern,String.Empty));
            char[] a = ((str1.ToLower()).ToCharArray());
            char[] b = ((str2.ToLower()).ToCharArray());
            Array.Sort(a);
            Array.Sort(b);
            string x = new string(a);
            string y = new string(b);
            if (Equals(x, y)) return "Анаграмма";
            else return "Не анаграмма";
        }

        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.Write(isAnagramm(input1, input2));
        }
    }
}