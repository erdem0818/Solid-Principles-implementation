public class DarkRide : ThemeParkRide ,IExtraDetails
{
    private int scariness;

    //when you inherit ThemParkRide class to this class, you have to write constructor method like that.
    public DarkRide(string name, float speed, int scariness) : base(name,speed)
    {
        this.scariness = scariness;
    }

    public string ExtraDetails()
    {
        return this.Name + " is a dark ride " + " which is rated " +this.scariness.ToString() + " on a scale from 1-10 \n";
    }
}