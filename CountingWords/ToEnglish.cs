using System;
using System.Collections.Generic;
using System.Text;

namespace CountingWords
{
    class ToEnglish
    {
        /// <summary>
        /// Проверяет введен ли текст на английском языке.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string SortEnglish(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            for (int i = 0; i < result.Length; i++)
            {
                var c = result[i];
                if (!(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z'))
                {
                    throw new Exception("Введенный параметр имел неверный формат. Необходимо ввести текст на английском.");
                }
            }
            return result;
        }


    }
}
