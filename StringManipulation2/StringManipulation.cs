using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

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
                    if (Sentence[i] == ' ' || Sentence[i] == '.' || Sentence[i] == '?' || Sentence[i] == '!')
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
            String ConvertedSentence = string.Empty;
            String Pattern = " " + inputword;
            Regex _Regex = new(Pattern);
            if (_Regex.IsMatch(InputString))
            {
                ConvertedSentence = _Regex.Replace(InputString, "");
            }
            else
            {
                ConvertedSentence = InputString;
                MessageBox.Show("There are no" + " " + inputword);
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
            String _Input = InputString;
            Boolean match = false;
            int month = 0;
            int Leapyear = 2028;
            //Date in the Year/Month/Day format.
            String Pattern = "^[\\d]{4}[\\\\/-][\\d]{2}[\\\\/-][\\d]{2}";
            //Date in the Day/Month/Year or Month/Day/Year format.
            String Pattern2 = "[\\d]{2}[\\\\/-][\\d]{2}[\\\\/-][\\d]{4}";
            Regex rg = new(Pattern);
            Regex rg2 = new(Pattern2);
            int nextstart = 0;
            if (rg.IsMatch(InputString))
            {
                //creates an array to store date substrings
                String[] dateParts = new string[3];
                dateParts[0] = InputString.Substring(0, 4);
                dateParts[1] = InputString.Substring(5, 2);
                dateParts[2] = InputString.Substring(8, 2);
                month = Convert.ToInt32(dateParts[1]);


                switch (month) {
                    case 01:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else {

                            match = true;
                        }

                        break;
                    case 02:
                        //Checks For Leapyear
                        if (Convert.ToInt32(dateParts[2]) > 29)
                        {
                            match = false;
                        }
                        else
                        {
                            match = true;
                            for (int i = Leapyear; i < Convert.ToInt16(dateParts[0]); i += 4)
                            {
                                Leapyear = Leapyear + 4;
                            }
                            if (Convert.ToInt16(dateParts[0]) < Leapyear) {
                                for (int i = Leapyear; i > Convert.ToInt16(dateParts[0]); i -= 4)
                                {
                                    Leapyear = Leapyear - 4;
                                }
                            }
                            if (Convert.ToInt32(dateParts[0]) == Leapyear && Convert.ToInt32(dateParts[2]) <= 29 || Convert.ToInt32(dateParts[2])<=28)
                            {

                                match = true;
                            }
                            else
                            {
                                match = false;
                            }

                            

                            

                        }
                        


                        break;

                    case 03:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;


                    case 04:
                        if (Convert.ToInt32(dateParts[2]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 05:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 06:
                        if (Convert.ToInt32(dateParts[2]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 07:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 08:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 09:
                        if (Convert.ToInt32(dateParts[2]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 10:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 11:
                        if (Convert.ToInt32(dateParts[2]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 12:
                        if (Convert.ToInt32(dateParts[2]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;
                }




            }
            //verifies if dd/mm/yyyy is a correct date
            if (rg2.IsMatch(InputString))
            {
                //creates an array to store date substrings
                String[] dateParts = new string[3];
                dateParts[2] = InputString.Substring(6, 4);
                dateParts[1] = InputString.Substring(3, 2);
                dateParts[0] = InputString.Substring(0, 2);
                month = Convert.ToInt32(dateParts[1]);

                //Checks each month in dateParts
                switch (month)
                {
                    case 01:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;
                    case 02:
                        if (Convert.ToInt32(dateParts[1]) > 29)
                        {
                            match = false;
                        }
                        else
                        {
                            //Checks for Leapyear
                            for (int i = Leapyear; i < Convert.ToInt16(dateParts[2]); i += 4)
                            {
                                Leapyear = Leapyear + 4;
                            }
                            if (Convert.ToInt16(dateParts[2]) < Leapyear)
                            {
                                for (int i = Leapyear; i > Convert.ToInt16(dateParts[2]); i -= 4)
                                {
                                    Leapyear = Leapyear - 4;
                                }
                            }
                            if (Convert.ToInt32(dateParts[2]) == Leapyear && Convert.ToInt32(dateParts[0]) <= 29 || Convert.ToInt32(dateParts[0]) <= 28)
                            {

                                match = true;
                            }

                            else
                            {
                                match = false;
                            }


                        }


                        break;

                    case 03:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;


                    case 04:
                        if (Convert.ToInt32(dateParts[0]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 05:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 06:
                        if (Convert.ToInt32(dateParts[0]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 07:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 08:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 09:
                        if (Convert.ToInt32(dateParts[0]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 10:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 11:
                        if (Convert.ToInt32(dateParts[0]) > 30)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;

                    case 12:
                        if (Convert.ToInt32(dateParts[0]) > 31)
                        {
                            match = false;
                        }
                        else
                        {

                            match = true;
                        }

                        break;
                }

                



            }



           

            return match;
        }

           
        
    } 
}
