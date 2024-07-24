using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var carLotone = new CarLot();
            //TODO
            
            
            

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            Console.WriteLine($"Cars created : {CarLot._numberOfCars}");

            var carOne = new Car();
            carOne.Make = "Toyota";
            carOne.Model = "Camry";
            carOne.year = 2023;
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");
            
            Console.WriteLine($"Cars created : {CarLot._numberOfCars}");

            carLotone.parkinglot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Hyundai",
                Model = "Sonata",
                year = 2018,
                IsDriveable = true,
            };
            
            carTwo.MakeHonkNoise("Groom");
            carTwo.MakeHonkNoise("Beeeeep");
            
            Console.WriteLine($"Cars created : {CarLot._numberOfCars}");
            
            carLotone.parkinglot.Add(carTwo);

            var carThree = new Car(make: "Ford", model: "Fusion", year: 2017, isDriveable: true);
            
            carThree.MakeEngineNoise("Broom");
            carThree.MakeHonkNoise("peep peep");
            
            Console.WriteLine($"Cars created : {CarLot._numberOfCars}");
            
            carLotone.parkinglot.Add(carThree);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLotone.CheckCars();
        }
    }
}
