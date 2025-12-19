using System;

class Program
{
    // 
    
     static void Main()
    {
       /*#region Input And Declaration
        Console.WriteLine("Enter a number to check if it is even or odd (q to exit the process):");
        String? choice=Console.ReadLine();
        int Local_number;
        bool result_of_function=false;
        #endregion

        while (choice != "q" && choice != "Q"
        )
        {
            Local_number=int.TryParse(choice,out Local_number)?Local_number:0;
            result_of_function = Conditions.Iseven(Local_number);
            Console.WriteLine(result_of_function ? "The number is even" : "The number is odd");
            Console.WriteLine("Enter a number to check if it is even or odd (q to exit the process):");
            choice = Console.ReadLine();
        }
        */


    //ques 1
   /* Console.WriteLine("Enter the height to classify (in cm):");
    String? input = Console.ReadLine();
    double height;
    height=double.TryParse(input, out height) ? height : 0.0;
    Console.WriteLine(Practice_questions.Height_classifier(height));
    */

    //ques 2
    
    /*Console.WriteLine("Enter three numbers to find the maximum among them:");
    String? input1 = Console.ReadLine();
    String? input2 = Console.ReadLine();
    String? input3 = Console.ReadLine();
    int num1, num2, num3;
    num1 = int.TryParse(input1, out num1) ? num1 : 0;
    num2 = int.TryParse(input2, out num2) ? num2 : 0;
    num3 = int.TryParse(input3, out num3) ? num3 : 0;
    int max = Practice_questions.Max_of_three(num1, num2, num3);
    Console.WriteLine("The maximum number is: " + max);

    */


    //ques 3

    Console.WriteLine("Enter a year to check if it is a leap year or not:");
    String? input = Console.ReadLine();
    int year;
    year = int.TryParse(input, out year) ? year : 0;
    bool isLeap = Practice_questions.IsLeapYear(year);
    Console.WriteLine(isLeap ? "The year is a leap year." : "The year is not a leap year.");


        
    }
}

