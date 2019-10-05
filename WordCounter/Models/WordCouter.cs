using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models 
{
    public class CountWords 
    {
        char[] AlphabeticUpper { get; set;}
        int WordCount { get; set; }
        // string InputWord { get; set; }
        // string InputText { get; set; }
       public CountWords () 
       {
           int WordCount = 0;
        //    string InputWord = "";
        //    string InputText = "";
            
        }


        // public string RemovePunc (string input)
        // {
        //     var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
        //     foreach (var c in charsToRemove)
        //     {
        //         input = input.Replace(c, string.Empty);
        //     }
        //     return input;

        // }
               
        // public int FindWord(string inputWord, string inputText)
        // {   
        // CountWords newCountWords = new CountWords();
        // char[] spearator = {' '}; 
        // String[] inputArray = inputText.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
        // int result = 0;
        // foreach(string word in inputArray)
        // { 
        //     if(inputWord == word)
        //     {
        //         newCountWords.WordCount ++;
        //         result = newCountWords.WordCount;
        //     }
        //     else
        //     {
        //         result = 0;
        //     }
        //     }
        //     return result;
        // }
  

    public bool LettersOnly(string input)
       {
            bool result = true;
            char[] inputArray = input.ToCharArray();
            foreach(char letter in inputArray)
            {
                bool isLetter = Char.IsLetter(letter);
                {
                    if(isLetter)
                    {
                        result=  true;         
                    }
                    else
                    {
                        result = false;
                    }       
                }
               
            }
            return result; 
       }


    }    
      
    
}




   
