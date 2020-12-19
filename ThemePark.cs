using System;
using System.Collections.Generic;

public class ThemePark
{
    public string ThemeParkName;
    public float TicketCost;
    public int AverageDailyAttendance;

    private IList<IThemeParkRide> ThemeParkRides; 
    public List<IRestaurant> restaurants;

    public float TotalIncome;
    public float TotalCost;

    public ThemePark(IList<IThemeParkRide> themeParkRides)
    {
        ThemeParkRides = themeParkRides;
        restaurants = new List<IRestaurant>();
    }

    private void CalculateTotalRestaurantIncome()
    {
        TotalIncome += AverageDailyAttendance * ((Restaurant.TotalIncome) / 3);
    }

    private void CalculateTotalRestaurantCost() {
        Restaurant.TotalLoss += AverageDailyAttendance * ((Restaurant.TotalLoss)/3);
    }

    private void CalculateTotalRideIncome() {
        TotalIncome += TicketCost * AverageDailyAttendance;
    }

    private void CalculateTotalRideCost() {
        TotalCost += (float)(ThemeParkRide.TotalSpeed * .50 * 12);
    }

    private float CalculateProfit()  
    {  
        CalculateTotalRestaurantIncome();
        CalculateTotalRestaurantCost();
        CalculateTotalRideCost();
        CalculateTotalRideIncome();
        return TotalIncome - TotalCost;  
    }

    public void PrintRides() {
        Console.WriteLine(ThemeParkName + " contains the following rides: \n");
        foreach (IThemeParkRide ride in ThemeParkRides) {
            if(ride is IExtraDetails)
            {
                Console.WriteLine(((IExtraDetails)ride).ExtraDetails());
            }
            if(ride is ISpinningEngine)
            {
                ((ISpinningEngine)ride).Start(ride.ToString());
                ((ISpiningEngine)ride).Stop(ride.ToString());
            }
            Console.WriteLine(ride.rideDetails());
        }
    }

    public void PrintRestaurants() 
    {
        Console.WriteLine(ThemeParkName + " contains the following restaurants: \n");
        foreach (IRestaurant restaurant in restaurants) 
        {
            Console.WriteLine(restaurant.extraDetails());
            //Console.WriteLine(restaurant.restaurantDetails());
        }
    }

    public void PrintProfit() {
        Console.WriteLine(ThemeParkName + " makes " + CalculateProfit() + " in income.");
    }
}