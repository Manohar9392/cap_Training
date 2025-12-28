namespace q1{
public class RobotSafetyException : Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
            
        }
       
    }

public class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            double riskScore = 0.0;

            if(armPrecision<0.0 || armPrecision>1.0)
            {
                throw new RobotSafetyException("machineryState must be 'Worn', 'Faulty', or 'Critical'");
            }
            else if(workerDensity<1 || workerDensity>20)
            {
                throw new RobotSafetyException("armPrecision must be between 0.0 and 1.0");
            }
            else if(machineryState!="Worn" && machineryState!="Faulty" && machineryState!="Critical")
            {
                throw new RobotSafetyException("workerDensity must be between 1 and 20");
            }
            else
            {
                
                riskScore = (1 - armPrecision)*15.0 ;

                switch (machineryState)
                {
                    case "Worn":
                        riskScore += workerDensity*1.3;
                        break;
                    case "Faulty":
                        riskScore += workerDensity*2.0;
                        break;
                    case "Critical":
                        riskScore += workerDensity*3.0;
                        break;
                }
            }

            
            return riskScore;
        }

}
}
