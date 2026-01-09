using System;
using System.Reflection;
using reflection;

public class Program
{
    /// <summary>
    /// Performing Reflection getting datatypes{class} and properties of particular datatypes we can get with dll file itself.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {
        Assembly a=Assembly.LoadFrom("C:/LPUEx_csharp_projects/Capgemini_Training_3/cap_Training/DAY_10_data_to_data/Reflection/bin/Debug/net10.0/Reflection.dll");

        Type[] types=a.GetTypes();

        foreach(Type t in types)
        {
            Console.WriteLine(t.FullName);//it will print all the Datatypes in Dll file.
        }
        

        var prop=types[1].GetProperties();

        foreach(var t1 in prop)
        {
            Console.WriteLine($"Property Name: {t1.Name} and its datatype is {t1.PropertyType}"); //It will give properties in particular class 
        }

         var prop1=types[1].GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

         foreach(var t2 in prop1)
        {
            Console.WriteLine($"Property Name: '{t2.Name}' and its datatype is '{t2.PropertyType}'"); //It will give properties in particular class Private properties only.
        }




    }
}
