public class SmartHome
{
    public bool IsSecuritySystemArmed { get; private set; }
    public bool IsLightsOn { get; private set; }
    private int temperature;

    public int Temperature
    {
        get
        { 
            return temperature; 
        }
        private set
        {
            if (value < 15 || value > 30)
            {
                temperature = 23;
            }
            else temperature = value;
        }
    }

    public SmartHome(int temperature, bool isSecuritySystemArmed, bool isLightsOn)
    {
        Temperature = temperature;
        IsSecuritySystemArmed = isSecuritySystemArmed;
        IsLightsOn = isLightsOn;
    }

    public void SetTemperature(int t)
    {
        Temperature = t;
    }

    public void ArmSecuritySystem()
    {
        IsSecuritySystemArmed = !IsSecuritySystemArmed;
    }

    public void ToggleLights()
    {
        IsLightsOn = !IsLightsOn;
    }
}