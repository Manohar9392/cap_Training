using System;

public class Program
{
    public static List<int> NumbersList=new List<int>();

    public void AddNumbers(int n)
    {
        NumbersList.Add((int)n/10);
    }

    public double GetGpaScored()
    {
        double gpa=0;
        double total=0;
        if(NumbersList.Count==0)
        {
            return -1;
        }
        foreach(var v in NumbersList)
        {
            total+=(v*3);
        }
        gpa=total/(NumbersList.Count*3);
        return gpa;
    }

    public char GetGradeScored(double gpa)
    {
        if(gpa<5 || gpa>10)
        {
            return 'z';
        }
        char val;
        if(gpa>=5 && gpa<6)
        {
            val='E';
        }
        else if (gpa < 7)
        {
            val= 'D';
        }
        else if(gpa<8)
        {
            val='C';
        }
        else if (gpa < 9)
        {
            val='B';
        }
        else if(gpa<10)
        {
            val='A';
        }
        else
        {
            val='S';
        }
        return val;

    }
    public static void Main()
    {

        Program p=new Program();

        int num;
        while(true)
        {
            Console.Write("Enter the num or -1 to exit: ");
            num=int.Parse(Console.ReadLine());
            if(num==-1)
            {
                break;
            }
            else
            {
                p.AddNumbers(num);
            }
        }

        Console.Write("Total gpa is : ");
        double res=p.GetGpaScored();
        Console.WriteLine(res.ToString("F2"));

        Console.Write("Your Grade is: ");
        char res1=p.GetGradeScored(res);
        if(res1=='z')
        {
            Console.WriteLine("Invalid gpa!");
        }
        else{
        Console.WriteLine(res1);
        }
        
    }
}