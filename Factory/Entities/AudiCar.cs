namespace Factory.Entities;

// Concrete Audi car class
public class AudiCar : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling an Audi car.");

        // Add Audi-specific assembly logic here
    }
}