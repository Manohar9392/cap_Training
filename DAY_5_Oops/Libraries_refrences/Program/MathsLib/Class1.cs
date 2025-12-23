using CommonLib;
namespace MathsLib{

public class Alzebra:Login_access
{
    /// <summary>
    /// Logs in a user with given username and id.
    /// </summary>
    /// <param name="username"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public override String Login(String username,int id)
        {
            return "Login Succesful"+Confidential_data();
            
            
        }

    /// <summary>
    /// Logs out the user.
    /// </summary>
    /// <returns></returns>
    public override String Logout()
        {
            return "Logout Succesful";
        }
    /// <summary>
    /// Adds two integers.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts second integer from first.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
}