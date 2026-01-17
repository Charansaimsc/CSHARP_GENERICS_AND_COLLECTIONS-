using System;
using System.Collections.Generic;

public class CabManager
{
    private List<Driver> drivers = new List<Driver>();
    private SortedList<double, List<Driver>> distanceMap =
        new SortedList<double, List<Driver>>();

    public CabManager()
    {
        LoadDrivers();
        AssignNearestDriver();
        CancelRide(1);
        AssignNearestDriver();
    }

    // Adding the data and load it to list 
    private void LoadDrivers()
    {
        AddDriver(new Driver(1, "sai", 4.6), 2.5);
        AddDriver(new Driver(2, "charan", 4.8), 1.2);
        AddDriver(new Driver(3, "muchakarla", 4.8), 1.2);
        AddDriver(new Driver(4, "saicharan", 4.0), 3.0);
    }

    private void AddDriver(Driver d, double distance)
    {
        drivers.Add(d);

        distance = Normalize(distance);

        if (!distanceMap.ContainsKey(distance))
            distanceMap.Add(distance, new List<Driver>());

        distanceMap[distance].Add(d);
    }

    // ASSIGN DRIVER 
    private void AssignNearestDriver()
    {
        if (distanceMap.Count == 0)
        {
            Console.WriteLine("No drivers available");
            return;
        }

        foreach (var entry in distanceMap)
        {
            List<Driver> sameDistanceDrivers = entry.Value;

            Driver best = null;

            for (int i = 0; i < sameDistanceDrivers.Count; i++)
            {
                Driver d = sameDistanceDrivers[i];

                if (!d.IsAvailable)
                    continue;

                if (best == null || d.Rating > best.Rating)
                    best = d;
            }

            if (best != null)
            {
                best.IsAvailable = false;
                Console.WriteLine("Assigned Driver: " + best.Name);
                return;
            }
        }

        Console.WriteLine("No available drivers");
    }

    // Cancellation and Penality 
    private void CancelRide(int driverId)
    {
        for (int i = 0; i < drivers.Count; i++)
        {
            Driver d = drivers[i];

            if (d.Id == driverId)
            {
                d.IsAvailable = true;
                d.CancellationCount++;

                if (d.CancellationCount >= 3)
                {
                    d.Rating -= 0.5;
                    Console.WriteLine(d.Name + " penalized for cancellations");
                }

                Console.WriteLine("Ride cancelled for " + d.Name);
                return;
            }
        }
    }

    
    private double Normalize(double value)
    {
        return Math.Round(value, 2);
    }
}
