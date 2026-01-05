using System;
// using main_class;
using partial_class;

public class Program
{
    public static void Main(string[] args)
    {

        Student s1=new Student();
        s1.Name="ram";
        s1.Partial_student();

        Console.WriteLine(General.Get_details());

        string a="i am good";
        Console.WriteLine(a.Wordcount());
    }
}