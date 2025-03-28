﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSharpChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
     //String input ="33#";   //Result("E")
     //String input ="227*#"; //Result("B")
     //String input ="4433555 555666#";  //Result("HELLO")
     //String input ="8 88777444666*664#";  //Result("TURIG")
       String input ="44 999 20 833777788*";  //Result("HYA TEST")

     List<string> arr = SeperateInput(input);
      
      Console.WriteLine("Segments:");
        foreach (var segment in arr)
        {
            Console.WriteLine(segment);
        }
        
        String str=OldPhonePad(arr);
        Console.WriteLine(str);
    }
    static List<string> SeperateInput(string input)
    {
       //string pattern = @"([a-zA-Z0-9]+|[\*\#])";

        input = RemoveCharacterForStar(input); 
        Console.WriteLine(input);
        List<string> ResultData = new List<string>();
        MatchCollection matchedData = Regex.Matches(input, @"(\d)\1*"); 

        foreach (Match result in matchedData)
        {
            ResultData.Add(result.Value);
        }
        return ResultData;
    }
    
    static string RemoveCharacterForStar(string input)
    {
        List<char> lstchars = new List<char>(input);
        for (int i = 0; i < lstchars.Count; i++)
        {
            if (lstchars[i] == '*' && i>0)
            {
               lstchars.RemoveAt(i);
               lstchars.RemoveAt(i-1); 
            }
        }
        return new string(lstchars.ToArray());
    }
    public static String OldPhonePad(List<string> input)
    {
    string result="";
      foreach (var segment in input)
        {
           
       switch (segment)
            {
                case "1" : 
                      result += "&";
                      break;
                case "11":
                     result += "'";
                     break;
                case "111" :
                     result += "(";
                     break;
                case "2" :
                     result += "a";
                     break;
                case "22" :
                     result += "b";
                     break;
                case "222" :
                     result += "c";
                     break;
                case "3" :
                     result += "d";
                     break;
                case "33" :
                     result += "e";
                     break;
                case "333" :
                     result += "f";
                     break;
                case "4" :
                     result += "g";
                     break;
                case "44" :
                     result += "h";
                     break;
                case "444" :
                     result += "i";
                     break;
                case "5" :
                     result += "j";
                     break;
                case "55" :
                     result += "k";
                     break;
                case "555" :
                     result += "l";
                     break;
                case "6" :
                     result += "m";
                     break;
                case "66" :
                     result += "n";
                     break;
                case "666" :
                     result += "o";
                     break;
                case "7" :
                     result += "p";
                     break;
                case "77" :
                     result += "q";
                     break;
                case "777" :
                     result += "r";
                     break;
                case "7777" :
                     result += "s";
                     break;
                case "8" :
                     result += "t";
                     break;
                case "88" :
                     result += "u";
                     break;
                case "888":
                     result += "v";
                     break;
                case "9" :
                     result += "w";
                     break;
                case "99" :
                     result += "x";
                     break;
                case "999" :
                     result += "y";
                     break;
                case "9999" :
                     result += "z";
                     break;
                case "0" :
                     result += " ";
                     break;
                case "#" :
                     result += "";
                     break;
                default :
                     result += "";
                     break;
            };
       
        }
         return result.ToUpper();
      
    }
  }
}