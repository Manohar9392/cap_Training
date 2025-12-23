using CommonLib;
namespace ScienceLib{

public class AeroScience:Login_access
{
    /// <summary>
    /// Login validation
    /// </summary>
    /// <param name="username"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public override String Login(String username,int id)
        {
            return "Login Succesful";
            
        }

    /// <summary>
    /// Logout Validation
    /// </summary>
    /// <returns></returns>
    public override String Logout()
        {
            return "Logout Succesful";
        }

    
    

    /// <summary>
    /// Calculates the speed of sound at sea level.
    /// </summary>
    /// <returns></returns>
    
    public double SpeedOfSoundAtSeaLevel()
    {
        return 343.2; // Speed of sound in air at sea level in m/s
    }



    /// <summary>
    /// Calculates the force using mass and acceleration.
    /// </summary>
    /// <param name="mass"></param>
    /// <param name="acceleration"></param>
    /// <returns>Force</returns>

    public double Force(double mass, double acceleration)
    {
        return mass * acceleration; // F = m * a
    }

}
}
