using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        public static int isWordCount(this string text, string word)
        {
            int count = 0;
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
