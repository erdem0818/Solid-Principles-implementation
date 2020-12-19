public class BrokenRide : ThemeParkRide,IExtraDetails
{
    public BrokenRide(string name):base(name,0)
    {

    }

    public string ExtraDetails()
    {
        TotalSpeed = 0;
        return "This is a example " + " of a broken ride and should not be " 
        + "counted in the total right now";
    }
}