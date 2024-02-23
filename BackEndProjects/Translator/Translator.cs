using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.Translator
{
    internal class Translator
    {

        private string[] languages = { "GeoEng", "GeoRus", "EngGeo", "RusGeo" };
        private string desktopPath;

        // Constructor to initialize Translator instance and create translation files
        public Translator()
        {
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            foreach (string language in languages)
            {
                string filePath = Path.Combine(desktopPath, $"{language}.txt");

                // Create translation file if it doesn't exist
                if (!File.Exists(filePath))
                {
                    try
                    {
                        File.Create(filePath).Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error creating translation file '{language}.txt': {ex.Message}");
                    }
                }
            }
        }

        // Method to start the Translator application
        public void Run()
        {
            while (true)
            {
                int LangOption = 0;
                Console.WriteLine("Select your option: 1 - GeoEng 2- GeoRus 3-EngGeo 4-RusGeo 5 - Quit");
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                try
                {
                    LangOption = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                if (LangOption == 5)
                {
                    // Exit the application 
                    break;
                }

                string filePath = "";

                switch (LangOption)
                {
                    case 1:
                        filePath = Path.Combine(desktopPath, "GeoEng.txt");
                        break;
                    case 2:
                        filePath = Path.Combine(desktopPath, "GeoRus.txt");
                        break;
                    case 3:
                        filePath = Path.Combine(desktopPath, "EngGeo.txt");
                        break;
                    case 4:
                        filePath = Path.Combine(desktopPath, "RusGeo.txt");
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        continue; // Restart the loop 
                }

                Console.WriteLine("Enter a word you would like to translate: ");
                string targetWord = Console.ReadLine()?.ToLower();

                if (string.IsNullOrEmpty(targetWord))
                {
                    Console.WriteLine("Invalid input. Please enter a word to translate.");
                    continue;  
                }

                try
                {
                    // Read all lines from the translation file
                    string[] lines = File.ReadAllLines(filePath);

                    // Check if the word exists in the translation file
                    bool wordFound = false;
                    foreach (string line in lines)
                    {
                        string[] words = line.Split(new char[] { '.', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (words.Contains(targetWord))
                        {
                            // If word found, print the next word
                            int index = Array.IndexOf(words, targetWord);
                            if (index < words.Length - 1)
                            {
                                Console.WriteLine($"Translation: {words[index + 1]}");
                            }
                          
                            wordFound = true;
                            Console.WriteLine("Do you want to edit this translation? (yes/no)");
                            string editChoice = Console.ReadLine()?.ToLower();
                            if (editChoice == "yes")
                            {
                                EditWord(filePath, targetWord);
                            }else break;
                            break;
                        }
                    }

                    if (!wordFound)
                    {
                        // If word not found, ask user to add it to the translation file
                        Console.WriteLine("That word is not in the dictionary yet. Enter the translation:");
                        string translation = Console.ReadLine()?.Trim();
                        if (!string.IsNullOrEmpty(translation))
                        {
                            // Append the word and its translation to the translation file
                            File.AppendAllText(filePath, $"{targetWord}. {translation}\n");
                            Console.WriteLine("Word added to the dictionary.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid translation. Word not added.");
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Translation file not found.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }




        private void EditWord(string filePath, string targetWord)
        {
            try
            {
                // Read all lines from the translation file
                List<string> lines = new List<string>(File.ReadAllLines(filePath));

                // Find the line containing the target word
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains(targetWord))
                    {
                        // Prompt user for new translation
                        Console.WriteLine("Enter the new translation:");
                        string newTranslation = Console.ReadLine()?.Trim();

                        // Update the line with new translation
                        string[] words = lines[i].Split(new char[] { '.', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        int index = Array.IndexOf(words, targetWord);
                        if (index < words.Length - 1)
                        {
                            words[index + 1] = newTranslation;
                            lines[i] = string.Join(".", words);
                        }

                        // Write the updated lines back to the file
                        File.WriteAllLines(filePath, lines);

                        Console.WriteLine("Translation updated successfully.");
                        return;
                    }
                }

                Console.WriteLine("Word not found in the translation file.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Translation file not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }



}

