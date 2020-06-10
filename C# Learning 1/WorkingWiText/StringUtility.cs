using System;
using System.Collections.Generic;

namespace WorkingWiText
{
    public class StringUtility
    {
        public static string SummarisingTxt(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChar += word.Length + 1;
                if (totalChar > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + ". . .";
        }

    }
}
