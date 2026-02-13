using System;
using System.Collections.Generic;

class TextEditor
{
    static void Main()
    {
        Console.Write("Enter number of operations: ");
        int n = int.Parse(Console.ReadLine());

        var words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string op = Console.ReadLine();

            if (op.StartsWith("TYPE "))
            {
                string word = op.Substring(5);
                words.Add(word);   // Push (like stack)
            }
            else if (op == "UNDO")
            {
                if (words.Count > 0)
                {
                    words.RemoveAt(words.Count - 1);  // Pop
                }
            }
        }

        Console.WriteLine("Final Text:");
        Console.WriteLine(string.Join(" ", words));
    }
}
