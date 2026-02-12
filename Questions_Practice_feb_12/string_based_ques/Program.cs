using System;
public class Program
{

    #region merge two sorted arrays
    /*
    public static List<int> MergerTwoSorted(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        int i = 0;
        int j = 0;
        while (i < nums1.Length && j<nums2.Length ) {
            if( nums1[i] <= nums2[j] )
            {
                result.Add(nums1[i]);
                i++;
            }
            else
            {
                result.Add(nums2[j]);
                j++;
            }
        }
        while (i < nums1.Length)
        {
            result.Add(nums1[i]);
            i++;
        }
        while (j < nums2.Length)
        {
            result.Add(nums2[j]);
            j++;
        }
        return result;

    }
    public static void Main()
    {
        int[] arr1 = {1,2,3,4,5};
        int[] arr2 = { 3, 5, 6, 7, 8 };

        var v=MergerTwoSorted(arr1,arr2);
        foreach (var x in v)
        {
            Console.Write(x+" ");
        }
        
    }
    */
    #endregion



    #region palindrome checking
    /*
    public static bool IsPalindrome(string input)
    {
        int i = 0;
        int j = input.Length - 1;
        while(i<j)
        {
            if (input[i] != input[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string input=Console.ReadLine();
        if(IsPalindrome(input))
        {
            Console.WriteLine("it is a palindrome");
        }
        else
        {
            Console.WriteLine("it is not a palindrome");
        }
    }
    */
    #endregion



    #region reverse a string whithout built in

    public static string reverse(string input)
    {
        char[] arr=input.ToCharArray();
        int i = 0, j = arr.Length - 1;
        while(i<j)
        {
            char temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
            i++;
            j--;
        }
        string result = "";
        foreach(var v in arr)
        {
            result += v;
        }
        return result;
        
    }

    public static void Main()
    {
        Console.Write("Enter the string: ");
        string input=Console.ReadLine();
        Console.WriteLine(reverse(input));

    }

    #endregion

}