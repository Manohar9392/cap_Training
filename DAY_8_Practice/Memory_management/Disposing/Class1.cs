using System.Collections;

namespace Disposing{

public class Bigboy:IDisposable
{
    public ArrayList Names{get;set;}//Array list to store the Names..
    public Bigboy()
        {
            
        }
    
    /// <summary>
    /// Dispose Method claer refrence of Names by making null
    /// </summary>
    public void Dispose()
        {
            Names=null;
        }
    ~Bigboy()//call by garbage collecter 
        {
            Names=null;
        }

}
}
