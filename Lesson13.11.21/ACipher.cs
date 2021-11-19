using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._11._21
{
    class ACipher : Alphabet, ICipher
    {
        public string Encode(string text)
        {
            string output = "";
            try
            {
                foreach (char symbol in text)
                {
                    if (symbol == 'я' || symbol == 'z' || symbol == 'Z' || symbol == 'Я')
                    {
                        throw new Exception();
                    }
                    if (EnglishAlphabetUpper.Contains(symbol)) //Английский (верхний регистр)
                    {
                        output += EnglishAlphabetUpper[EnglishAlphabetUpper.IndexOf(symbol) + 1];
                    }
                    else if (EnglishAlphabetLower.Contains(symbol)) //Английский (нижний регистр)
                    {
                        output += EnglishAlphabetLower[EnglishAlphabetLower.IndexOf(symbol) + 1];
                    }
                    else if (RussianAlphabetUpper.Contains(symbol)) //Русский (верхний регистр)
                    {
                        output += RussianAlphabetUpper[RussianAlphabetUpper.IndexOf(symbol) + 1];
                    }
                    else if (RussianAlphabetLower.Contains(symbol)) //Русский (нижний регистр)
                    {
                        output += RussianAlphabetLower[RussianAlphabetLower.IndexOf(symbol) + 1];
                    }
                    else
                    {
                        output += symbol;
                    }
                }
                Console.WriteLine($"Зашифрованный вариант (ACipher): {output}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: введено некорректное крайнее значение.");
            }
            return output;
        }



        public string Decode(string text)
        {
            string output = "";
            try
            {
                foreach (char symbol in text)
                {
                    if (symbol == 'a' || symbol == 'A' || symbol == 'А' || symbol == 'а')
                    {
                        throw new Exception();
                    }
                    if (EnglishAlphabetUpper.Contains(symbol)) //Английский (верхний регистр)
                    {
                        output += EnglishAlphabetUpper[EnglishAlphabetUpper.IndexOf(symbol) - 1];
                    }
                    else if (EnglishAlphabetLower.Contains(symbol)) //Английский (нижний регистр)
                    {
                        output += EnglishAlphabetLower[EnglishAlphabetLower.IndexOf(symbol) - 1];
                    }
                    else if (RussianAlphabetUpper.Contains(symbol)) //Русский (верхний регистр)
                    {
                        output += RussianAlphabetUpper[RussianAlphabetUpper.IndexOf(symbol) - 1];
                    }
                    else if (RussianAlphabetLower.Contains(symbol)) //Русский (нижний регистр)
                    {
                        output += RussianAlphabetLower[RussianAlphabetLower.IndexOf(symbol) - 1];
                    }
                    else
                    {
                        output += symbol;
                    }
                }
                Console.WriteLine($"Расшифрованный вариант (ACipher): {output}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: введено некорректное крайнее значение.");
            }
            return output;
        }
    }
}
