using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCountLibrary
{
    public class WordCountClass
    {
        public int WordCount(string textString, string word)
        {
            textString = textString.ToLower();   
            string regString = @"^[a-zа-я\s]*$";
            string regWord = @"^[a-zа-я]{2,}$";
            if (!Regex.IsMatch(textString, regString, RegexOptions.IgnoreCase))
            {
                throw new Exception("вы ввели неверную строку");
            }
            if (!Regex.IsMatch(word, regWord, RegexOptions.IgnoreCase))
            {
                throw new Exception("строка менее 2х символов");
            }
            string povtor="";
            int count = 0;
            foreach (char item in textString)
            {
                if (item != ' ')
                {
                    povtor += item;
                }
                if (item == ' ')
                {
                    if (povtor == word)
                    {
                        count++;
                    }
                    povtor = "";
                }
            }
            if (povtor == word)
            {
                count++;
            }
            povtor = "";

            return count;
        }            
    }   
}
