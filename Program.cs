using System;
using System.Collections.Generic;

namespace SOLIDP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IThemeParkRide> themeParkRides = new List<IThemeParkRide>();
            themeParkRides.Add(new DarkRide("haunted mission",2,2));
            themeParkRides.Add(new SpinningRide("spin",50,50,3));

            ThemePark warwarLand = new ThemePark(themeParkRides);

            warwarLand.TicketCost = 90;
            warwarLand.AverageDailyAttendance = 50000;            

            

            warwarLand.PrintRides();

            warwarLand.restaurants.Add(new DarkRestaurant("eskihisar ocakbaşı", 100,50, "eskihisar"));
            warwarLand.restaurants.Add(new DarkRestaurant("sahil cafe", 17,18,"Darıca"));
            warwarLand.restaurants.Add(new ShotDownRestaurant("kapalı","istanbul"));

            warwarLand.PrintRestaurants();

            warwarLand.PrintProfit();
        }
    }
}
