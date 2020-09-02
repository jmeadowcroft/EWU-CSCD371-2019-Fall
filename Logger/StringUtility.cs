using System;

namespace Logger
{
    public class StringUtility
    {
        public static string ToTitleCase(string text)
        {
            string title = "";
            if (text != null)
            {
                string[] words = text.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    char[] letters = words[i].ToCharArray();
                    if (letters.Length != 0)
                    {
                        letters[0] = char.ToUpper(letters[0]);
                        words[i] = new String(letters);
                        if (i != words.Length - 1)
                            title += words[i] + " ";
                        else
                            title += words[i];
                    }
                }
            }
            return title;
        }
    }
}