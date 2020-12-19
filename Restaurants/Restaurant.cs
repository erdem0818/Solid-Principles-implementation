public abstract class Restaurant : IRestaurant
{
    public string ResturantName;
    public float RestaurantIncome;
    public float RestaurantLoss;

    public static float TotalIncome;
    public static float TotalLoss;

    public Restaurant(string name, float income, float loss)
    {
        this.ResturantName = name;
        this.RestaurantIncome = income;
        this.RestaurantLoss = loss;

        TotalIncome += income;
        TotalLoss += loss;
    }

    //her yeni sınıf için aynı çalışacak olan fonksiyon, çünkü override etmedik.
    public virtual string restaurantDetails()
    {
        //without this.
        return ResturantName + " which generates " + RestaurantIncome + " in income and costs " + RestaurantLoss + "\n";
    }

    public virtual string extraDetails()
    {
        throw new System.NotImplementedException();
    }
}