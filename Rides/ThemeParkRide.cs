using System;

public abstract class ThemeParkRide : IThemeParkRide
{
    public string Name;
    public float Speed;
    public static float TotalSpeed =0;

    public ThemeParkRide(string name,float Speed)
    {
        this.Name = name;
        this.Speed = Speed;
        TotalSpeed += Speed;
    }

    //interface method , this method can be overrided
    //bunu diğer sınıflarda override etmedik buna göre yazdırdı hepsinde aynı çalışan bir fonksiyon haline geldi.
    public virtual string rideDetails()
    {
        return this.Name + " which goes " +this.Speed + "\n";
    }
}