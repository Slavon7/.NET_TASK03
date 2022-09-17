using System;
using System.Collections.Generic;

namespace _920a_Omeniuk_PZ3
{
    class Dictionary // Class Dictionary
    {
        private Dictionary<string, List<string>> dictionaryUA; // private varible Dictionaty
        public Dictionary()
        {
            dictionaryUA = new Dictionary<string, List<string>>();
        }
        // Method 
        public void AddWord(string engWord, string UaWord)
        {
            if (dictionaryUA.ContainsKey(engWord))
            {
                dictionaryUA[engWord].Add(UaWord);  // Add UaWord to engWord
            }
            else dictionaryUA.Add(engWord, new List<string> { UaWord }); // Сhecking for the presence of a word
        }
       
        // Method print to the console
        public void Print(string str)
        {
            if (dictionaryUA.ContainsKey(str))
            {
                Console.Write(str + " \t|\t");
                Console.WriteLine(string.Join("\t|\t", dictionaryUA[str])); 
            }
            else Console.WriteLine("Перший раз чую таке слово \t" + str); // Word is null
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionaryUA = new Dictionary(); // Initialize the variable
            // Add words
            dictionaryUA.AddWord("Father", "Батько");
            dictionaryUA.AddWord("Father", "Тато");
            dictionaryUA.AddWord("Father", "Бандера");
            dictionaryUA.AddWord("Ukraine", "Україна");
            dictionaryUA.AddWord("Ukraine", "Батькiвщина");
            dictionaryUA.AddWord("Ukraine", "Вiльна");
            dictionaryUA.Print("Ukraine");

            Console.ReadKey(true);
        }
    }
}