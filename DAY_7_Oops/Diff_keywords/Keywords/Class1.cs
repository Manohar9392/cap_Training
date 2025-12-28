namespace Keywords{

public class keys
{
    public void Multimath(int a ,out int square,out int half,out int cube)
    {
        square=a*a;
        half=a/2;
        cube=a*a*a;
    }

    public void Key_checked(int a,int b)
        {
            

            int result1=a+b;
            Console.WriteLine("Unchecked Sum: " + result1);

            checked
            {
                int result = a + b;
                Console.WriteLine("Checked Sum: " + result);
            }
        }
    
    public void Key_ref_example(ref int a)
    {
        a = a * 2;
       
    }

    public void Without_ref_example(int a)
    {
        a = a * 2;
    }


}
}
