using System;

namespace CarLotSimulator;

public class Car
{
    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property

    public int year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"{Make}{Model} has an engine noise that sounds like {EngineNoise}.");

    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"{Make}{Model} has an honk noise that sounds like {HonkNoise}");
    }

    public Car()
    {
        CarLot._numberOfCars++;
    }

    public Car(string make, string model, int year, bool isDriveable)
    {
        CarLot._numberOfCars++;
        Make = make;
        Model = model;
        year = year;
        IsDriveable = isDriveable;
    }
}