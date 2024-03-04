using Factory;
using Factory.Factories;

// Car Dealership
CarFactory dealership = new BMWFactory(); // Change factory to create different car brands

// Customer chooses a car and the factory creates it
Car customerCar = dealership.CreateCar();
customerCar.Assemble();

Console.ReadLine();