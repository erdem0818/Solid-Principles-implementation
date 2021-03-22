public class DarkRestaurant : Restaurant
{
    private string location;

    //detailste kullanılacak, name,income ve loss
    public DarkRestaurant(string name,float income, float loss,string location): base(name,income,loss)
    {
        
        this.location = location;
    }

    public override string extraDetails()
    {
        return "location: " + this.location;
    }
}
