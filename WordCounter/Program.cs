  
using System;
using WordCounter.Models;


    class Program
    {
        public static void Main()
        {
        
        CountWords newCountWords = new CountWords();
        
        Console.WriteLine("Please enter a word:");
        string userWord = Console.ReadLine();
        string removeWordPunc = newCountWords.RemovePunc(userWord);
        bool letterOnlyWord = newCountWords.LettersOnly(removeWordPunc);
            if(letterOnlyWord == true)
            {
                userWord = removeWordPunc;
            }
            else
            {
                Console.WriteLine("Please enter alphabetic characters only.");
            }

        Console.WriteLine("Please enter a sentence to find out how many times your word occurs in the sentence:");
        string userText = Console.ReadLine();
        string removeTextPunc = newCountWords.RemovePunc(userText);
        bool letterOnlyText = newCountWords.LettersOnly(removeTextPunc);
            if(letterOnlyText == true)
            {
                userText = removeTextPunc;
            }
            else
            {
                Console.WriteLine("Please enter alphabetic characters only.");
            }
        if(letterOnlyText== true && letterOnlyWord == true)
        {
        int result = newCountWords.FindWord(userWord, userText);
        Console.WriteLine("There are " + result + " instances of your word in the text." );


        }


        }
    }
