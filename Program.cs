using System;
using System.Collections.Generic;

namespace Progaram
{
    class Program
    {
        public static void Main()
        {
            string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
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

            string[] res = result.ToArray();
            foreach (string item in res)
                Console.Write(item + " ");
        }

        public static string SortSymbol(string word)
        {
            char[] charsArray = word.ToCharArray();
            Array.Sort(charsArray);

            return String.Join("", charsArray);
        }
    }
}