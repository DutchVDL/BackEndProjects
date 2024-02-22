using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.Hangman
{
    internal class Hangman
    {
        private string word;
        private int attempts;
        private char[] chars;
        private List<char> usedLetters;

        public Hangman(List<string> words, int attempt)
        {
            if (words == null || words.Count == 0)
            {
                throw new ArgumentException("Word list cannot be empty.");
            }


            attempts = attempt;
            Random random = new Random();
            word = words[random.Next(0, words.Count-1)].ToLower();
            chars = new char[word.Length];
            usedLetters = new List<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '_';
            }
        }

        public void Run()
        {
            while (attempts > 0 && chars.Contains('_'))
            {
                foreach (char k in chars)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");


                Console.WriteLine("Enter a letter");
                char c;

                while (!char.TryParse(Console.ReadLine(), out c) || usedLetters.Contains(c))
                {
                    Console.WriteLine("Invalid input or letter already used. Please enter a valid letter");
                }
                Guess(c);
            }

            if (!chars.Contains('_'))
            {
                Console.WriteLine($"Congratulations! You guessed the word: {word} ");
            }
            else
            {
                Console.WriteLine($"You ran out of attempts! The word was: {word}");
            }
        }

        public void Guess(char c)
        {
            bool guessedCorrectly = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                {
                    chars[i] = c;
                    guessedCorrectly = true;
                }
            }

            if (guessedCorrectly)
            {
                Console.WriteLine("Correct guess!");
            }
            else
            {
                attempts--;
                Console.WriteLine($"The Secret Word does not contain {c}, you have {attempts} attempts left");
            }

            usedLetters.Add(c);
        }
    }
}
