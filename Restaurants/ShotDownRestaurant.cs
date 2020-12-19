public class ShotDownRestaurant : Restaurant
{
    private string location;

    public ShotDownRestaurant(string name,string location): base(name,0,0)
    {
        this.location = location;
    }

    public override string extraDetails()
    {
        //TotalIncome = 0;
        //TotalIncome=0;
        return "this restaurant shot down";
    }
}