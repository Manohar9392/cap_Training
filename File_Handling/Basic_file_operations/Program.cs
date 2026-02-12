using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        string basedir = AppContext.BaseDirectory;
        string path = Path.Combine(basedir, "input.txt");

        Console.WriteLine(basedir);
        File.WriteAllText(path, "Hello, World!");
        string content = File.ReadAllText(path);
        Console.WriteLine(content);
        File.AppendAllText(path, "\ni am manu");
        content = File.ReadAllText(path);
        Console.WriteLine(path);
        

        Console.ReadLine(); 
    }
}