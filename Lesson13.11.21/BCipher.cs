using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._11._21
{
    class BCipher : Alphabet, ICipher
    {
        public string Encode(string text)
        {
            string output = "";
            foreach (char symbol in text)
            {
                if (EnglishAlphabetUpper.Contains(symbol)) //Английский (верхний регистр)
                {
                    output += EnglishAlphabetUpper[EnglishAlphabetUpper.Count() - EnglishAlphabetUpper.IndexOf(symbol)];
                }
                else if (EnglishAlphabetLower.Contains(symbol)) //Английский (нижний регистр)
                {
                    output += EnglishAlphabetLower[EnglishAlphabetLower.Count() - EnglishAlphabetLower.IndexOf(symbol)];
                }
                else if (RussianAlphabetUpper.Contains(symbol)) //Русский (верхний регистр)
                {
                    output += RussianAlphabetUpper[RussianAlphabetUpper.Count() - RussianAlphabetUpper.IndexOf(symbol)];
                }
                else if (RussianAlphabetLower.Contains(symbol)) //Русский (нижний регистр)
                {
                    output += RussianAlphabetLower[RussianAlphabetLower.Count() - RussianAlphabetLower.IndexOf(symbol)];
                }
                else //Если не является русской или английской буквой
                {
                    output += symbol;
                }
            }
            return output;
        }
        public string Decode(string text)
        {
            string output = "";
            foreach (char symbol in text)
            {
                if (EnglishAlphabetUpper.Contains(symbol)) //Английский (верхний регистр)
                {
                    output += EnglishAlphabetUpper[EnglishAlphabetUpper.Count() - EnglishAlphabetUpper.IndexOf(symbol) - 1];
                }
                else if (EnglishAlphabetLower.Contains(symbol)) //Английский (нижний регистр)
                {
                    output += EnglishAlphabetLower[EnglishAlphabetLower.Count() - EnglishAlphabetLower.IndexOf(symbol) - 1];
                }
                else if (RussianAlphabetUpper.Contains(symbol)) //Русский (верхний регистр)
                {
                    output += RussianAlphabetUpper[RussianAlphabetUpper.Count() - RussianAlphabetUpper.IndexOf(symbol) - 1];
                }
                else if (RussianAlphabetLower.Contains(symbol)) //Русский (нижний регистр)
                {
                    output += RussianAlphabetLower[RussianAlphabetLower.Count() - RussianAlphabetLower.IndexOf(symbol) - 1];
                }
                else //Если не является русской или английской буквой
                {
                    output += symbol;
                }
            }
            return output;

        }
    }
}
