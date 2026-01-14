using System;
using model;

public class Program
{
    /// <summary>
    /// Starting point of Ques1 which performs different operations
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        ///Adding the Details of Persons
        Data.Persons.Add(new Person("Aarya",69,"A2101"));
        Data.Persons.Add(new Person("Daniel",40,"D104"));
        Data.Persons.Add(new Person("Ira",25,"A21"));
        Data.Persons.Add(new Person("Jennifer",33,"I1704"));

        PersonImplementation p1=new PersonImplementation();

        Console.WriteLine(p1.GetName(Data.Persons));
        Console.WriteLine(p1.Average(Data.Persons));
        Console.WriteLine(p1.Max(Data.Persons));
       

    }
}