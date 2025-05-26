using System;
using System.Linq;

class Train : IComparable<Train>
{
    private string destination;
    private string trainNumber;
    private TimeSpan departureTime;

    public Train(string destination, string trainNumber, TimeSpan departureTime)
    {
        this.destination = destination;
        this.trainNumber = trainNumber;
        this.departureTime = departureTime;
    }

    public string Destination => destination;
    public string TrainNumber => trainNumber;
    public TimeSpan DepartureTime => departureTime;

    public int CompareTo(Train other)
    {
        return departureTime.CompareTo(other.departureTime);
    }

    public override string ToString()
    {
        return $"Поезд №{trainNumber}, Пункт назначения: {destination}, Время отправления: {departureTime}";
    }
}

class Station
{
    private Train[] trains;

    public Station(Train[] trains)
    {
        this.trains = trains.OrderBy(t => t.DepartureTime).ToArray(); 
    }

    public Train this[string trainNumber]
    {
        get
        {
            return trains.FirstOrDefault(t => t.TrainNumber == trainNumber)
                   ?? throw new ArgumentException("Поезд с указанным номером не найден.");
        }
    }

    public void GetTrainsAfter(TimeSpan time)
    {
        var filteredTrains = trains.Where(t => t.DepartureTime > time);
        Console.WriteLine("Поезда, отправляющиеся после " + time + ":");
        foreach (var train in filteredTrains)
        {
            Console.WriteLine(train);
        }
    }

    public void GetTrainsToDestination(string destination)
    {
        var filteredTrains = trains.Where(t => t.Destination == destination);
        Console.WriteLine("Поезда, отправляющиеся в пункт назначения: " + destination);
        foreach (var train in filteredTrains)
        {
            Console.WriteLine(train);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Train[] trains =
        {
            new Train("Минск", "123A", new TimeSpan(10, 30, 0)),
            new Train("Гродно", "456B", new TimeSpan(12, 15, 0)),
            new Train("Минск", "789C", new TimeSpan(8, 45, 0)),
            new Train("Витебск", "101D", new TimeSpan(14, 00, 0))
        };

        Station station = new Station(trains);

        try
        {
            Console.WriteLine(station["456B"]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        station.GetTrainsAfter(new TimeSpan(9, 0, 0));

        station.GetTrainsToDestination("Минск");
    }
}
