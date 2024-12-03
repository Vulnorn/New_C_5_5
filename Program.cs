using System;

namespace ObedinitVOdnyKollekciu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] characterStringFirst = new string[0];
            string[] characterStringSecond = new string[0];
            List<string> characters = new List<string>();

            characterStringFirst = CreateArray();
            AddUniqueValuesCollection(characters, characterStringFirst);
            characterStringSecond = CreateArray();
            AddUniqueValuesCollection(characters, characterStringSecond);
            WriteCollection(characters);
        }

        static string[] CreateArray()
        {
            string[] characterString = new string[0];
            string userInput;
            char whitespace = ' ';

            Console.WriteLine($"Введите строку с набором цифр через пробел");
            userInput = Console.ReadLine();
            characterString = userInput.Split(whitespace);

            return characterString;
        }

        static void AddUniqueValuesCollection(List<string> characters, string[] characterString)
        {
            for (int i = 0; i < characterString.Length; i++)
            {
                if(characters.Contains(characterString[i])==false)
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