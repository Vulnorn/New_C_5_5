using System;
using System.Collections.Generic;
using System.Linq;

namespace ObedinitVOdnyKollekciu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] characterStringFirst = new string[0];
            string[] characterStringSecond = new string[0];
            List<string> characters = new List<string>();

            characterStringFirst = CreateArray(characterStringFirst);
            CreateCollection(characters, characterStringFirst);
            characterStringSecond = CreateArray(characterStringSecond);
            CreateCollection(characters, characterStringSecond);
            WriteCollection(characters);
        }

        static string[] CreateArray(string[] characterString)
        {
            string userInput;
            char whitespace = ' ';

            Console.WriteLine($"Введите строку с набором цифр через пробел");
            userInput = Console.ReadLine();
            characterString = userInput.Split(whitespace);

            return characterString;
        }

        static void CreateCollection(List<string> characters, string[] characterString)
        {
            bool isReplay = false;

            for (int i = 0; i < characterString.Length; i++)
            {
                if (characters.Count != 0)
                {
                    for (int j = 0; j < characters.Count; j++)
                    {
                        if (characters[i] == characterString[j])
                            isReplay = true;
                    }
                }

                if (isReplay == false)
                    characters.Add(characterString[i]);
            }
        }

        static void WriteCollection(List<string> characters)
        {
            foreach (var character in characters)
            {
                Console.Write($"{character}; ");
            }
        }
    }
}
