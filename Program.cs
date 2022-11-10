using System;
using System.Collections.Generic;

namespace Progaram
{
    class Program
    {
        public static void Main()
        {
            string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
            List<string> newArray = new List<string>();
            string lastWord = "";

            for (int i = 0; i < array.Length; i++)
            {
                string word = SortSymbol(array[i]);

                if (word != lastWord)
                {
                    newArray.Add(array[i]);
                    lastWord = word;
                }
            }

            string[] result = newArray.ToArray();
            PrettyPrint(result);
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