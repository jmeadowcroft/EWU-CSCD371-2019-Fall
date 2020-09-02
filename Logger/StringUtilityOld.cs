using System;
namespace Logger
{
    public static class StringUtilityOld
    {
        public static string ToTitleCase(this string sentence)
        {
            return sentence;
        }
        //
        //    public static string ToTitleCase(this string sentence)
        //    {
        //        string[] words = sentence.Split(' ');
        //        string title = "";
        //        for(int i = 0; i < words.Length; i++) 
        //        {
        //            char[] letters = words[i].ToCharArray();
        //            letters[0] = char.ToUpper(letters[0]);
        //            words[i] = letters.ToString();
        //            if (i != words.Length - 1)
        //                title = title + words[i] + " ";
        //            else
        //                title = title + words[i];



        //        }
        //        return title;
        //    }
    }
}