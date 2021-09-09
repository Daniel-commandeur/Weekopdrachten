using System;
using System.Text;

namespace Weekopdracht1.Business
{
    public class TextHelper
    {
        public static string Sentence(string statement, int length)
        {
            if (statement.Length > length)
            {
                string[] words = statement.Split(' ');
                StringBuilder completedWord = new();
                int charCount = 0;

                if (words.Length > 1)
                {
                    for (int i = 1; i < words.Length; i++)
                    {
                        charCount += words[i].Length;
                        if (charCount >= length)
                        {
                            completedWord.AppendLine();
                            charCount = 0;
                        }
                        completedWord.Append(words[i]);
                        completedWord.Append(' ');
                    }
                }
                return completedWord.ToString();
            }
            return statement;
        }
    }
}
