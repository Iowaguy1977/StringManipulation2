using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace FindAWord
{
    public class StringManipulation
    {
        
        public static String AddWord(String InputString, String Inputword, int _randomNum)
        {
            //Create Variables
            String Sentence = InputString;
            String Word = Inputword;
            String NewWord = "";
            Random random = new();
            int WordPlace = _randomNum;
            //Loop through each char in the sentence
            for (int i = WordPlace; i < Sentence.Length; i++)
            {
                //If you find the end of the sentence then add the word else continue on!
                if (i == Sentence.Length)
                {
                    NewWord = string.Concat(Sentence, Word);

                }
                else
                {
                    //If you find a space or puntuation add the word
                    if (Sentence[i] == ' '|| Sentence[i] == '.' || Sentence[i] == '?' || Sentence[i] == '!')
                    {
                        NewWord = Sentence.Insert(i, " " + Word);
                        break;
                    }
                   
                }
            }



            return NewWord;
        }

        public static string DeleteWord(String InputString, String inputword)
        {
            String ConvertedSentence=string.Empty;
            String Pattern = " " + inputword;
            Regex _Regex = new(Pattern);
            if (_Regex.IsMatch(InputString))
            {
                ConvertedSentence=_Regex.Replace(InputString,"");
            }
          return ConvertedSentence;
        }

        public static Boolean VerifyEmail(String InputString)
        {
            string Pattern = "^[a-zA-Z0-9]+@[a-zA-Z0-9]+.com$";

            Regex rg = new(Pattern);
            
            return rg.IsMatch(InputString);
        }

        public static Boolean VerifyDate(String InputString)
        {
            String _Input=InputString;
            String Patten= "^[\\d]{4}[\\\\/-][\\d][^{3-9}{^a-z}{^22}{2}][\\\\/-][\\d]{2}";
            Regex rg = new(Patten);
            

            return rg.IsMatch(InputString) ;
        }
    }
}
