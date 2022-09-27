using Interfaces;

Car car = new Car();

car.Drive();

bool refuel = car.Refuel(50);

if (refuel)
{
    Console.WriteLine("Car successfully refueled.");
}

car.Drive();