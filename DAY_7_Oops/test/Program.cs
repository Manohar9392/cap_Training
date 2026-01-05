using System;
using System.Collections;
using System.Collections.Immutable;
using System.Reflection.Emit;
using System.Text;
using cls;
public class Program
{
    public static void Main(string[] args)
    {
        // Class1 obj=new Class1();
        // obj.Name="Capgemini";
        // Class1 obj2=obj;
        
        // Console.WriteLine("Name is: "+obj2.Name);

        /*

        int[][] data=new int[3][];
        int[] a=new int[]{1,2,3};
        data[0]=a;
        data[1]=new int[]{4,5,6,7};
        data[2]=new int[]{8,9,10,11,12};

        int[][] data2=new int[3][];
        data2=data;
        data2[1][0]=100;
        

        for(int i=0;i<data.Length;i++)
        {
            for(int j=0;j<data[i].Length;j++)
            {
                Console.Write(data[i][j]+" ");
            }
            Console.WriteLine();
        }
        */

/*
        //Collections
        //Non-Generics  

        ArrayList list=new ArrayList();
        list.Add(10);
        list.Add("Capgemini");
        list.Add(45.67);
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }

        Stack stk=new Stack();
        stk.Push(100);  
        stk.Push("Hello");
        stk.Push(45.67);

        foreach(var item in stk)
        {
            Console.WriteLine(item);
        }

        */




        //Generics
      List<int> list2=new List<int>();
        list2.Add(100);
        list2.Add(2000);
        list2.Add(300);    
        //list2.Add("Capgemini"); //Error
        list2.Sort();
        

        for(int i=0;i<list2.Count;i++)
        {
            Console.WriteLine(list2[i]);
        }
        

        // stack<int> stk2=new stack<int>();
        // stk2.Push(111);
        // stk2.Push(222);
        // stk2.Push(333);
        // while(stk2.Count>1)
        // {
        //     Console.WriteLine(stk2.Pop());
        // }
        

    }
}