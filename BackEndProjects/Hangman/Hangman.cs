using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.Hangman
{
    internal class Hangman
    {
        // Class fields
        private string word;                // The secret word to guess
        private int attempts;               // Remaining attempts
        private char[] chars;               // Array to store guessed characters
        private List<char> usedLetters;     // List to store already used letters

        // Constructor
        public Hangman(List<string> words, int attempt)
        {
            // Exception handling for empty word list
            if (words == null || words.Count == 0)
            {
                throw new ArgumentException("Word list cannot be empty.");
            }

            // Initializing fields
            attempts = attempt;
            Random random = new Random();
            // Selecting a random word from the list
            word = words[random.Next(0, words.Count - 1)].ToLower();
            chars = new char[word.Length];
            usedLetters = new List<char>();

            // Initializing characters array with underscores
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '_';
            }
        }

        // Method to run the game
        public void Run()
        {
            // Main game loop
            while (attempts > 0 && chars.Contains('_'))
            {
                // Displaying current progress
                foreach (char k in chars)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");

                // Prompting user for input
                Console.WriteLine("Enter a letter");
                char c;
                // Handling invalid inputs or already used letters
                while (!char.TryParse(Console.ReadLine(), out c) || usedLetters.Contains(c))
                {
                    Console.WriteLine("Invalid input or letter already used. Please enter a valid letter");
                }
                Guess(c); // Handling user's guess
            }

            // Game outcome
            if (!chars.Contains('_'))
            {
                Console.WriteLine($"Congratulations! You guessed the word: {word} ");
            }
            else
            {
                Console.WriteLine($"You ran out of attempts! The word was: {word}");
            }
        }

        // Method to process user's guess
        public void Guess(char c)
        {
            bool guessedCorrectly = false;
            // Checking if the guessed letter matches any character in the word
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                {
                    chars[i] = c;
                    guessedCorrectly = true;
                }
            }

            // Handling correct or incorrect guesses
            if (guessedCorrectly)
            {
                Console.WriteLine("Correct guess!");
            }
            else
            {
                attempts--;
                Console.WriteLine($"The Secret Word does not contain {c}, you have {attempts} attempts left");
            }

            usedLetters.Add(c); // Adding guessed letter to used letters list
        }
    }
}
