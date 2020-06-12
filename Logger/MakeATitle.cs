using System;
namespace Title
{
    public static class MakeATitle
    {
        public static string ToTitleCase(this string sentence)
        {
            string[] words = sentence.Split(' ');
            string title = "";
            for(int i = 0; i < words.Length; i++) 
            {
                char[] letters = words[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                words[i] = letters.ToString();
                title = title + words[i] + " ";
      
            }
            return title;
        }
    }
}