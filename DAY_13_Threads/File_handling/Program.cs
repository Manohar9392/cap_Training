using System;

public class Program
{
    public static void Main()
    {
        string[] lines={"first Line","Second line","third line"};

        string docpath="C:/LPUEx_csharp_projects";
        // Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        using(StreamWriter outputFile=new StreamWriter(Path.Combine(docpath, "file.txt")))
        {
            foreach(string s in lines)
            {
                outputFile.WriteLine(s);
            }
            Console.WriteLine("text added to file successfully");
        }
    }
}