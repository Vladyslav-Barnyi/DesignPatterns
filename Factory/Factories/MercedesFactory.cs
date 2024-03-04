using Factory.Entities;

namespace Factory.Factories;

// Concrete Mercedes factory class
public class MercedesFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new MercedesCar();
    }
}