using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Library;

namespace CountingWords
{
    class Program
    {
        /// <summary>
        /// Выводит значение полученное с помощью GetWords.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                var str = new CalculateString();
                string line = ToEnglish.SortEnglish("Введите строку.");
                Console.WriteLine(" " + str.GetWords(line));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
 
        }



    }
}
