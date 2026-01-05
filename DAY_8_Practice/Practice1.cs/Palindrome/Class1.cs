namespace Palindrome{

public static class StringExtension

{

    /// <summary>
    /// Method to check palindrome or not
    /// </summary>
    /// <param name="str"></param>
    /// <returns>True/False</returns>

public static bool IsPalindrome(this string str)
        {
            int size=str.Length;     //Taking string Length
            int Left_pointer=0;      //This Pointer Traverse from front to Right Pointer
            int Right_pointer=size-1; //This Pointer Traverse from End to Left Pointer.
            while(Left_pointer<=Right_pointer)
            {
                if(str[Left_pointer]!=str[Right_pointer])
                {
                    return false;        //here we are checking for false condition
                }
                Left_pointer+=1;
                Right_pointer-=1;
            }
            return true;        //If Every Thing Works return True
        }
}
}
