using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratory work 10.1");

            ACipher CiphA = new ACipher();
            BCipher CiphB = new BCipher();

            Console.WriteLine("Введите строку: ");
            string Example = Console.ReadLine();

            string CodeExample = CiphA.Encode(Example); //шифрование по смещению на 1 символ вправо

            CodeExample = CiphB.Decode(Example); //расшифрование по индексу символа i
            Console.WriteLine($"Зашифрованный вариант (BCipher): {CodeExample}");

            Console.WriteLine("Homework 10.1");

            Console.ReadKey();
        }
    }
}
