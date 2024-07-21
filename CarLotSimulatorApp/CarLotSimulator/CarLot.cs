using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> parkinglot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var vehicle in parkinglot)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.year}");
        }
    }
}