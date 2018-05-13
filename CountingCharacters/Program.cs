using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> Chars = new Dictionary<char, int>();
            Dictionary<char, int> result = CountingCharacters(input);
            foreach (KeyValuePair<char, int> kv in Chars)
                Console.WriteLine("{0}; {1}", kv.Key, kv.Value);
            Console.ReadLine();

             Dictionary<char, int> CountingCharacters(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (Chars.ContainsKey(text[i]))
                    {
                        Chars[text[i]] += 1;
                    }
                    else
                    {
                        Chars.Add(text[i], 1);
                    }
                }

                return Chars;
            }
        }
    }
}
