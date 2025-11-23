using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Programm
{
    //1
    public static string ConcatenateStrings(string str1, string str2, out string str)
    {
        return str = string.Concat(str1, str2);
    }

    //2
    public static string GreetUser(string name, int age, out string str)
    {
        return str = $"Hello, {name}! \nYou are {age} years old.";
    }

    //3
    public static string InfoString(string str, out string result)
    {
        return result = $"Number of characters: {str.Length}\nUppercase string: {str.ToUpper()}\nLowercase string: {str.ToLower()} ";
    }

    //4
    public static string SubstringString (string str, out string result)
    {
        return result = str.Substring(0, 5) ;
    }

    //5
    public void BuilderStr (string[] str, out StringBuilder result)
    {
        result = new StringBuilder();
        result.Append(str) ;
    }

    //6
    public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord, out string result)
    {
        return result = inputString.Replace(wordToReplace, replacementWord);
    }
}
