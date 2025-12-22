using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the num: ");
        int num=int.Parse(Console.ReadLine());
        for(int i=0;i<num;i++)
        {
            for(int j=0;j<num-i+1;j++)
            {
                Console.Write(" ");
            }
            for(int k=1;k<=2*i+1;k++)
            {
                if(k>i+1)
                {
                    Console.Write(k%i+1);               
             }
                else
                {
                    Console.Write(k);
                }
            }
            for(int j=0;j<num-i+1;j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();


        }
    }
}