public class DarkRestaurant : Restaurant
{
    private string location;

    //detailste kullanılacak, name,income ve loss
    public DarkRestaurant(string name,float income, float loss,string location): base(name,income,loss)
    {
        //cons içinde verdiğimiz string değişkeni sınıf içindekine aktardı altta this.location veya location yazmamız farkettirmedi bu sepeble 
        //ama bunu yapmazsak boş yazdırır
        this.location = location;
    }

    public override string extraDetails()
    {
        return "location: " + this.location;
    }
}