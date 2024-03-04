namespace Observer.Station;
using IObserver = Observer.Observers.IObserver;

// Concrete weather station class
public class WeatherStation : IWeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private string weatherUpdate;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        var x = 1;
        foreach (var observer in observers)
        {
            observer.Update(weatherUpdate);

            //Simulation
            Thread.Sleep(1000);
            Console.WriteLine($"Update for {observer} n.{x}");
            x++;
        }
    }

    public void SetWeatherUpdate(string update)
    {
        weatherUpdate = update;
        NotifyObservers();
    }
}