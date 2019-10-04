using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCounter.Models 
{
    public class CountWords 
    {
        char[] AlphabeticUpper { get; set;}
       public CountWords () 
       {
           char [] AlphabeticUpper = new char[]{'A','B','C','D','E','F','G','H','I', 'J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            
        }

          
        public bool CheckUpperInput (string input)
        {
            char[] array = input.ToCharArray();
            char[] AlphabeticUpper = new char[25];
            if(AlphabeticUpper.IsMatch(array)){
                return true;
            }
            return false;
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
}   
