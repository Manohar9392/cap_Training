using System;

public class Program
{
    public static SortedDictionary<string,long> Sorted=new SortedDictionary<string, long>();
    public SortedDictionary<string,long> FindItemDetails(long num)
    {
        SortedDictionary<string,long> temp=new SortedDictionary<string, long>();
        foreach(var v in Sorted)
        {
            if(v.Value==num)
            {
                temp.Add(v.Key,num);
            }
        }
        return temp;
        
    }

    public List<string> FindMinandMax()
    {
        List<string> temp=new List<string>();
        long mini=long.MaxValue;
        long maxi=long.MinValue;
        string min1="";
        string max1="";
        foreach(var v in Sorted)
        {
            if(v.Value<mini)
            {
                mini=v.Value;
                min1=v.Key;
            }

            if(v.Value>maxi)
            {
                maxi=v.Value;
                max1=v.Key;
            }

        }
        temp.Add(min1);
        temp.Add(max1);
        return temp;

        
    }

    public Dictionary<string,long> SortbyCount()
    {
        
        var sortedDict = Sorted.OrderBy(pair => pair.Value)
                     .ToDictionary(pair => pair.Key, pair => pair.Value);
        return sortedDict;
        
    }
    
    public static void Main()
    {
        Program p=new Program();

        string name;
        long num;
        string choice;

       
       while(true)
        {
            Console.Write("Enter the choice and exit for stop:");
            choice=Console.ReadLine();
            if(choice.ToLower()=="exit")
            {
                break;
            }

            Console.Write("Enter the  product name: ");
            name=Console.ReadLine();
            Console.Write("Enter the count of product: ");
            num=long.Parse(Console.ReadLine());
            Sorted.Add(name,num);


        }
        Console.Write("Enter the count to find Products: ");
        long p1=long.Parse(Console.ReadLine());

        SortedDictionary<string,long> res=p.FindItemDetails(p1);
        if(res.Count==0)
        {
            Console.WriteLine("No producted matched with this count ");
        }
        else{
        foreach(var v in res)
        {
            Console.WriteLine($"Item: {v.Key} count is: {v.Value}");
        }
        }

        Console.WriteLine("Min and max items are: ");
        List<string> result=p.FindMinandMax();
        Console.WriteLine($"mincount item is {result[0]}");
        Console.WriteLine($"maxcount item is {result[1]}");


        Console.WriteLine("Sort by values are: ");
        Dictionary<string,long> res2=p.SortbyCount();
        foreach(var v in res2)
        {
            Console.WriteLine($"{v.Key}:{v.Value}");
        }



        
    }
}