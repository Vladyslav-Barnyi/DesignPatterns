using Strategy.Strategies;

namespace Strategy;

// Context class that uses a travel strategy
public class TravelPlanner
{
    private ITravelStrategy travelStrategy;

    public void SetTravelStrategy(ITravelStrategy strategy)
    {
        travelStrategy = strategy;
    }

    public void PlanTravel(string source, string destination)
    {
        travelStrategy.Travel(source, destination);
    }
}