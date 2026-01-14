using System;
using Generic;

namespace Generic
{
    public class Student
    {
        public string? Name{get;set;}
    }

    public class Ugstudent : Student
    {
        public decimal Marks{get;set;}
    }

    public class Pgstudent : Student
    {
        public decimal Score{get;set;}
    }
    
}

public class GlobalType<T>
{
    public List<T> names=new List<T>();

    public void AddEntry(T? t)
    {
        names.Add(t);
    }
    public string GetdataType(T? t)
    {
        return t.GetType().ToString();

    }
    public string classtype(T? t)
    {
        if(t is Ugstudent)
        {
            return "ug student";
        }
        else if(t is Pgstudent){
            return "Pg student";
            
        }
        return "Student";
    }
}
public class Program
{
    public static void Main()
    {
        GlobalType<Student>? obj=new GlobalType<Student>();
        Ugstudent? a=new Ugstudent();
        Pgstudent? b=new Pgstudent();
        //  string c="ram";
        // obj.AddEntry(c); //it is not possible because obj is student datatype it will take only student and its childs datatypes
        obj.AddEntry(b);
        obj.AddEntry(a);

        foreach (var v in obj.names)
        {
        Console.WriteLine(obj.GetdataType(v));
        Console.WriteLine(obj.classtype(v));
        }


        
    }
}