using System;
using System.Collections.Generic;
using System.Linq;


namespace WordCounter.Models
{
    abstract class CountMethod
    {
    public abstract int Count<TSource> (System.Collections.Generic.IEnumerable<TSource> source); 
    }
    public class CountWords 
    {
        public string RemovePunc (string input)
        {
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            foreach (var c in charsToRemove)
            {
                input = input.Replace(c, string.Empty);
            }
            return input;

        }

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

               
        public int FindWord(string inputWord, string inputText)
        {   
        CountWords newCountWords = new CountWords();
        char[] separator = {' '}; 
        String[] inputArray = inputText.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        var matchQuery = from word in inputArray
                        where word == inputWord
                        select word;
        int wordCount = matchQuery.Count();  
        
        return wordCount;

        }

    }
            
}
  

    
      
    





   
