using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;



// Optional but good practice

/*
public class Student
{   
    // [XmlElement("Student_id",Order = 1)]
    public int Id { get; set; }

    // [XmlElement("Student_name",Order = 2)]
    public string Name { get; set; }

    // [XmlElement("Student_marks",Order = 3)]
    public int Marks { get; set; }


    // [XmlArray("Numbers", Order = 4)]//ordering the format .
    // [XmlArrayItem("Number")]
    public int[]? arr;

    // [XmlArray("Names", Order = 5)]
    // [XmlArrayItem("Name")]
    public string[]? arr1;

    // [XmlArray("ranks", Order = 6)]
    // [XmlArrayItem("rank")]

    public List<int> vals;

    // public Dictionary<string,int> dict;
}
*/

public class ProcessInfo
{
    public int Id{get;set;}
    public string Process_Name{get;set;}

    public long Working{get;set;}

    
}


class Program
{
    static void Main()
    {
        /*
        Student s = new Student
        {
            Id = 101,
            Name = "Manu",
            Marks = 85,
            arr=new int[] {1,2,3,4},
            arr1=new string[] {"a","b","c","d"}

        };
        s.vals=new List<int>();
        s.vals.Add(10);
        s.vals.Add(20);


        Student s1 = new Student
        {
            Id = 101,
            Name = "Manu",
            Marks = 85,
            arr=new int[] {1,2,3,4},
            arr1=new string[] {"a","b","c","d"}

        };
        s1.vals=new List<int>();
        s1.vals.Add(10);
        s1.vals.Add(20);

        List<Student> students=new List<Student>();
        students.Add(s);
        students.Add(s1);
        // s.dict=new Dictionary<string, int>();
        // s.dict["a"]=1;
        */


        /*
        // serilization of obj into xml format
        XmlSerializer serializer = new XmlSerializer(typeof(Student));

        serializer.Serialize(Console.Out, s);

        Console.WriteLine();
        Console.ReadLine();
        */

        /*
        

        string num1=JsonSerializer.Serialize(students);
        Console.WriteLine(num1);

        var obj=JsonSerializer.Deserialize(num1);
        Console.WriteLine(obj[0].Name);
        */

        Process[] processList = Process.GetProcesses();

        // string AllProcess=JsonSerializer.Serialize(processList);

        Console.WriteLine(processList[0]);


        
    }
}
