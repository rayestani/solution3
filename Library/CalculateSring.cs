using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Library
{
    public class CalculateString
    {
        /// <summary>
        /// Метод выделяет отдельные слова и вычисляет для них частоту встречемости
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string GetWords(string line)
        {

            var matches = Regex.Split(line.ToLower(), "\r\n");
            Dictionary <string, Text> dct = new Dictionary<string, Text>();
            var i = 1;
            string result = "";
            foreach (var sent in matches)
            {
                var words = Regex.Matches(sent, @"\w+(-\w+)*").Cast<Match>().Select(i => i.Value).ToArray();
               
                foreach (var word in words)
                {

                    if (!dct.ContainsKey(word))
                    {
                        dct.Add(word, new Text(){ Rows = new HashSet<int>() });
                        var value = dct[word];
                        value.Rows.Add(i);
                        value.Count++;
                    } 
                       
                }
                i++;
            }
            foreach (var item in dct.OrderBy(b => b.Key))
            {
                Console.WriteLine("{0}{1}", item.Key.PadRight(10), item.Value.Count, string.Join(" ", item.Value.Rows));
            }
            return result;

        }

        class Text
        {
            public int Count;
            public HashSet<int> Rows;
        }

    }
}
