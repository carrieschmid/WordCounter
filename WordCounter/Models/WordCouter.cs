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
        // string InputText { get; set;}
       public CountWords () 
       {
           char [] alphabet = new char[]{' ','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
           int WordCount = 0;
        //    string InputWord = inputWord;
        //    string InputText = inputText;
            
        }


        public string RemovePunc (string input)
        {
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            foreach (var c in charsToRemove)
            {
                input = input.Replace(c, string.Empty);
            }
            string finalInput = "";
            foreach(char letter in input)
            {
                
                bool isLetter = char.IsLetter(letter);
                {
                    if(isLetter)
                    {
                        finalInput = input;                   
                    }
                    else
                    {
                        finalInput = "Please remove characters.";
                    }
                    

                    return finalInput;
                }
            }
        }


    
            // inputString = new string((from c in inputString
            //       where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
            //       select c).ToArray());

        //     char[] array = input.ToCharArray();
        //     char[] AlphabeticUpper = new char[25];
        //     for (int index = 0; index<= array.Length; index ++) 
        //         for(int j = 0; j <=AlphabeticUpper.Length; j ++)
                
        //     {
        //         if(array[index] == AlphabeticUpper[j]  )
        //         {
        //             return true;
        //         }
        //     }
        // return false;

        



        public int FindWord(string inputWord, string inputText)
        {   
        CountWords newCountWords = new CountWords();

        char[] spearator = {' '}; 

        String[] inputArray = inputText.Split(spearator,  
           StringSplitOptions.RemoveEmptyEntries);
        int result = 0;
        foreach(string word in inputArray)
        { 
            if(inputWord == word)
            {
                newCountWords.WordCount ++;
                result = newCountWords.WordCount;
            }
            else
            {
                result = 0;
            }
            }
            return result;
        }
  

        }    
      
    
    }

