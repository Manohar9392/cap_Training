using System;
public class Program
{
    public static void Main(string[] args)
    {
        //string name = "manu";
        //var e = name.IndexOf('a');
        //name=name.Remove(e, 1);
        //Console.WriteLine(name);
        Console.Write("Enter the first string: ");
        string word1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string word2= Console.ReadLine();
        int cnt = 0;
        foreach(var v in word1)
        {
            if (word2.Contains(v))
            {
                int n = word2.IndexOf(v);
                word2 = word2.Remove(n,1);
            }
            else
            {
                cnt++;
            }
        }
        char[] arr = word1.ToCharArray();
        string res = "";
        for (int i=0;i<arr.Length;i++)
        {
            res+= arr[i].ToString().ToUpper();
        }

        Console.WriteLine(res);

        Console.WriteLine("Remaining are : "+ cnt);
        Console.ReadLine();

    }
}