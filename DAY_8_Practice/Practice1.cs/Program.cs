using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Palindrome;

public class Program()
{
    
    /// <summary>
    /// Starting Point to check Palindrome Method....
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        /*
        #region  code to check Palindrome
        Console.Write("Enter the String to check whether it is palindrome or not: ");
        string Name=Console.ReadLine();
        Console.WriteLine(Name.IsPalindrome()?"It is a Palindrome":"It is not a Palindrome");//IsPalindrome is a user defined Function
        #endregion
        */

        #region Pattern Matching
        string input=" Error: Timeout not Found";
        string Pattern=@"timeout";          //pattern
        //validating using regex 
        var rx =new Regex
        (
            Pattern,
            RegexOptions.IgnoreCase,
            TimeSpan.FromMilliseconds(150)
        );
        Console.WriteLine(rx.IsMatch(input)?"Found":"NotFound");
        #endregion
        

    }
}