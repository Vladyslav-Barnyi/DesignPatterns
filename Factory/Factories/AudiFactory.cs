using Factory.Entities;

namespace Factory.Factories;

// Concrete Audi factory class
public class AudiFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new AudiCar();
    }
}