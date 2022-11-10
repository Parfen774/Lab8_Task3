using System;
using System.Collections.Generic;

namespace Progaram
{
    class Program
    {
        public static void Main()
        {
            string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
            string[] result = CheckAnagrams(array);
            PrettyPrint(result);
        }

        public static string[] CheckAnagrams(string[] array)
        {
            List<string> result = new List<string>();
            string lastWord = "";

            for (int i = 0; i < array.Length; i++)
            {
                string word = SortSymbol(array[i]);

                if (word != lastWord)
                {
                    result.Add(array[i]);
                    lastWord = word;
                }
            }

            return result.ToArray();
        }

        public static string SortSymbol(string word)
        {
            char[] charsArray = word.ToCharArray();
            Array.Sort(charsArray);

            return String.Join("", charsArray);
        }

        public static void PrettyPrint(string[] array)
        {
            string result = "";

            foreach (var item in array)
            {
                result += $"\'{item}\' ";
            }

            Console.WriteLine($"[{result.Trim()}]");
        }
    }
}