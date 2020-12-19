public class WhiteRide : ThemeParkRide
{
    int scariness;

    public WhiteRide(string name,float speed, int scariness): base(name,speed)
    {
        this.scariness = scariness;
    }

    public override string rideDetails()
    {
        return this.Name + " is a white ride which is rated: " +
                this.scariness.ToString() + " on a scale of 1-10 \n";
    }
}