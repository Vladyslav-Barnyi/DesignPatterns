using Command.Command;
using Command.Invoker;
using Command.Receiver;

// Create the kitchen staff
KitchenStaff kitchen = new KitchenStaff();

// Create the waiter (invoker)
Waiter waiter = new Waiter();

// Create specific order commands
ICommand order1 = new OrderCommand(kitchen, "Spaghetti Carbonara");
ICommand order2 = new OrderCommand(kitchen, "Grilled Salmon");
ICommand order3 = new OrderCommand(kitchen, "Tiramisu");
Console.WriteLine("Orders created");

// Place orders with the waiter
waiter.PlaceOrder(order1);
waiter.PlaceOrder(order2);
waiter.PlaceOrder(order3);
Console.WriteLine("Orders placed");
// Serve the orders
waiter.ServeOrders();
Console.WriteLine("Orders served");

Console.ReadLine();