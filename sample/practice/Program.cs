using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    

    public class Program
    {
        
        public static void Main()
        {





            ////collections
            //ArrayList array=new ArrayList();
            //array.Add(1);
            //array.Add(2);
            //array.Add(3);
            //array.Add('a');


            ////Generics

            //List<int> list=new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //foreach(var v in array)
            //{
            //    Console.WriteLine(v);
            //}


            //foreach(int a in list)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();


            //string name ="manohar" ;
            //char[] arr=name.ToCharArray();
            ////int i = 0;
            ////int j = name.Length - 1;
            ////while (i < j)
            ////{
            ////    char temp=arr[i];
            ////    arr[i]=arr[j];
            ////    arr[j]=temp;
            ////    i++;
            ////    j--;

            ////}

            //Dictionary<char,int> dic = new Dictionary<char,int>();

            //foreach (char c in arr)
            //{
            //    if(!dic.ContainsKey(c))
            //    {
            //        dic.Add(c, 1);
            //    }
            //    else
            //    {
            //        dic[c]++;
            //    }
            //}


            //foreach (var c in dic)
            //{
            //    Console.WriteLine(c.Key + ": " + c.Value);
            //}

            //Console.ReadLine();


            //string result = "";

            //foreach(var v in arr)
            //{
            //    result += v;

            //}
            //Console.WriteLine(result);

            //Console.ReadLine();

          
                // Take input
                Console.Write("Enter first word: ");
                string word1 = Console.ReadLine();
            char[] arr1=word1.ToCharArray();

                Console.Write("Enter second word: ");
                string word2 = Console.ReadLine();
            char[] arr2=word2.ToCharArray();

                int deleteCount = 0;

                // Check each character of word1
                foreach (char ch in arr1)
                {
                    if (!arr2.Contains(ch))
                    {
                    


                        deleteCount++;
                    }
                else
                {
                    arr2.Remove(ch);
                }
                }

                // Output result
                Console.WriteLine("Number of deletions required from word1: " + deleteCount);

            Console.ReadLine();
         
        



    }


}
}

