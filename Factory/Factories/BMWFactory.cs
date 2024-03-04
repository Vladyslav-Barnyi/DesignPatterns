using Factory.Entities;

namespace Factory.Factories;

// Concrete BMW factory class
public class BMWFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new BMWCar();
    }
}