using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
           char [] AlphabeticUpper = new char[]{'A','B','C','D','E','F','G','H','I', 'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
           int WordCount = 0;
        //    string InputWord = inputWord;
        //    string InputText = inputText;
            
        }




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
  
            // string[] inputArray = new[]{inputText};
            // inputArray.Split(String[], " ")
            // return inputArray[0];

        }    
      
    

        // public bool CheckUpperInput (string input)
        // {
            
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

        // }
    }

