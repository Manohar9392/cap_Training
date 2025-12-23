namespace ScienceLib{

public class AeroScience
{
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
