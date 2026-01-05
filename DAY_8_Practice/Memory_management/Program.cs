using System;
using System.Collections;
using Disposing;
public class Program
{
    public static void Main(string[] args)
    {
        var list=new List<byte[]>();
        for(int i=0;i<=20000;i++)
        {
            list.Add(new byte[1024]);
        }
        Console.WriteLine("Allocated");
        Console.WriteLine("Total memory: "+GC.GetTotalMemory(forceFullCollection:false));
        list = null;
        GC.Collect();
        Console.WriteLine("Total memory: "+GC.GetTotalMemory(forceFullCollection:false));

        // Bigboy boy=new Bigboy();

        // try
        // {
        //     boy.Names=new ArrayList();
        //     for(int i=0;i<10;i++)
        //     {
        //         boy.Names.Add(i.ToString());
                
        //     }
            
        // }
        // catch(Exception ex)
        // {
            
        // }
        // finally
        // {
        //     boy.Dispose();
        // }

        

    }
}