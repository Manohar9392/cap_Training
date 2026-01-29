using System;

public static class StringExtensions
    {
        public static bool Ispalindrome(this string str)
        {
            
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
public class Program
{
    
    [Obsolete("Use NewAdd method instead")] ///by using attribute Obsolete we can mark a method as obsolete 
    ///we can change the metadata of the method
    public static int OldAdd(int a,int b)
    {
        return a+b;
    }

    public static int NewAdd(int a,int b)
    {
        return a+b;
    }
    public static void Main()
    {
        // int result1=OldAdd(5,10); //This will give a warning because OldAdd is marked as obsolete
        // Console.WriteLine("Result from OldAdd: "+result1);

        // int result2=NewAdd(5,10);
        // Console.WriteLine("Result from NewAdd: "+result2);

        // string name="Aeroplane";
        // name=name.ToLower();
        // string res="";
        // if(name.Contains(' '))
        // {
        //     Console.WriteLine("The name contains space");
        // }
        // for(int i=0;i<name.Length;i++)
        // {
        //     if((int)name[i]%2==1)
        //     {
        //         res+=name[i];
        //     }
        // }
        // char [] arr=res.ToCharArray();
        // int i=0;
        // int j=arr.Length-1;
        // while(i<j)
        // {
        //     char temp=arr[i];
        //     arr[i]=arr[j];
        //     arr[j]=temp;
        //     i++;
        //     j--;
        // }
        // for(int i=0;i<arr.Length;i++)
        // {
        //     if(i%2==0)
        //     {
        //         arr[i]=char.ToUpper(arr[i]);
        //     }
        // }
        // Console.WriteLine(new string (arr));

        string str="madam";
        bool ispalindrome=str.Ispalindrome();
        Console.WriteLine(ispalindrome);
    }
}