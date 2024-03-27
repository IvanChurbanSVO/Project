using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class String1
    {
        public static void main()
        {
            string word = "Hello niga";
            word.Print();
            word.ToUpper().Print();
            word.ToLower().Print();

                string word1 = "!!!";
                int x = 5;
                string word3 = $"{word} {word1} = {x}";
                word3.Print();
                int index = word3.IndexOf("!!!")+3;
                word3 = word3.Insert(index, " everyone").Print();
                word3 = word3.Remove(index-3, 3).Print();
                word3 = word3.Replace(" everyone", "and Earth").Print();
                word3 = word3.Replace("Hello", "").Print();
                word3 = word3[6..^0].Print();
        }

    }
}
