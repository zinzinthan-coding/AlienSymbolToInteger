using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.Convert
{
    public class AlienSymbolToInteger
    {
        static Dictionary<char, int> symbol = new Dictionary<char, int>
        {
            {'A', 1},
            {'B', 5},
            {'Z', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'R', 1000}
        };

        public void Main()
        {
            while (true)
            {
                Console.Write("Enter your input that contains only ABZLCDR characters: ");
                string userInput = Console.ReadLine()!;

                if (CheckCharacter(userInput, "ABZLCDR"))
                {
                    Console.WriteLine("Input contains unspecific characters.");
                }
                else
                {
                    Console.WriteLine("Integer of " + userInput + " is => " + ConvertToInteger(userInput));
                }
            }
        }

        static bool CheckCharacter(string input, string allowedCharacters)
        {
            string pattern = $"[^{Regex.Escape(allowedCharacters)}]";
            return Regex.IsMatch(input, pattern);
        }

        public static int ConvertToInteger(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && symbol[s[i]] < symbol[s[i + 1]])
                {
                    result += symbol[s[i + 1]] - symbol[s[i]];
                    i++;
                }
                else
                {
                    result += symbol[s[i]];
                }
            }

            return result;
        }

    }
}
