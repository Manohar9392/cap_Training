namespace part1{
public delegate int DelegateMethod(int a,int b);

public class Class1
{
    public int a;
    public int b;
    public int result;

    public Class1()
        {
            
        }

    public void delegateEx1()
    {

    DelegateMethod delegatevar1=new DelegateMethod(Multimethod);
    Console.WriteLine(delegatevar1(a,b));

    }

    private int Addmethod(int a,int b)
        {
            return a+b+10;
        }
    
    private int Multimethod(int a,int b)
        {
            return a*b;
        }

}

public class Calling_delegate()
    {
        public Class1? v1;

        public void Call()
        {
            if(v1!=null){
            v1.delegateEx1();
            }
        }
    }
}
